using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DavesCardsProjekt.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace DavesCardsProjekt.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [Authorize]
        public IActionResult PreOrder()
        {
            using(ShopModel db = new ShopModel())
            {
                var query = from st in db.Cards         //Hämtar innehåll från tabellen Cards i databasen
                            where st.CategoryId == 4    //Där kategorin är lika med 4
                            select st;                  //Välj innehållet
                List<Card> cards = query.ToList();      //Lägg till valt innehåll i till listan
                return View(cards);                     //Returnera lista
            }
        }

        [HttpPost] //Hämta användarinmatning
        public async Task<IActionResult> Login(Customer userInfo, string returnUrl = null)
        {
            bool userOk = CheckUser(userInfo); //Skapar bool för att kontrollera
            if(userOk == true) //OM true, användaren loggas in
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, userInfo.Username));

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity));

                //Skicka användaren till returnUrl
                if (returnUrl != null)
                    return Redirect(returnUrl);
                else
                    return RedirectToAction("Index", "Home"); //Skicka inloggade användaren till Index

            }
            ViewBag.ErrorMessage = "Inloggning misslyckades"; //Visa ifall inmatade uppgifter inte stämmer
            return View();
        }

        private bool CheckUser(Customer userInfo)
        {
            //Kontrollera mot databas.
            using (ShopModel db = new ShopModel())
            {
                var query = from st in db.Customers  //Välj från tabellen Customers
                            where st.Username.Equals(userInfo.Username) // där kolumn Username ska vara lika med inmatade Username
                            select st; 

                Customer customer = query.FirstOrDefault(); 

                if (userInfo.Passw.Equals(customer.Passw)) //OM lösenordet matchar
                {
                return true;
                }
                else
                {
                return false;
                }

            }
            
        }

        public async Task<IActionResult> SignOut() //Logga ut
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home"); //Gå till Index 
        }


        [HttpPost] //Hämtar användarinmatning
        public async Task<IActionResult> Register(Customer newUser) //Skapa konto
        {
            using (ShopModel db = new ShopModel()) 
            {
                db.Customers.Add(newUser);  //Lägg till nya användare till databasen
                db.SaveChanges();           //Spara ändringar

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, newUser.Username));

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity));

                return RedirectToAction("Login", "Home"); //Skicka hem 
            }

        }
    }
}