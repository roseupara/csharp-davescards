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

namespace DavesCardsProjekt.Controllers
{
    public class ShopController : Controller
    {

        public IActionResult Pokemon()
        {
            using (ShopModel db = new ShopModel()) 
            {
                var query = from st in db.Cards  //Hämtar kolumner i tabellen Cards i databasen
                            where st.CategoryId == 1  //Där kategorin är lika med 1
                            select st;                  //Välj kolumner.
                List<Card> cards = query.ToList();      // Lägg till hämtat innehåll i listan
                return View(cards);                     // Skriv ut lista
            }
            
        }

        public IActionResult DragonBall()
        {
            using (ShopModel db = new ShopModel())
            {
                var query = from st in db.Cards
                            where st.CategoryId == 2 //Där kategorin är lika med 2
                            select st;
                List<Card> cards = query.ToList();
                return View(cards);
            }

        }

        public IActionResult Tillbehor()
        {
            using (ShopModel db = new ShopModel())
            {
                var query = from st in db.Cards
                            where st.CategoryId == 3 //Där kategorin är lika med 3
                            select st;
                List<Card> cards = query.ToList();
                return View(cards);
            }

        }
    }   
}









