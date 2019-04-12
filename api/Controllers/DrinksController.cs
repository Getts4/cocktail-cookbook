using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocktailCookbook.Models;
using CocktailCookbook.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace CocktailCookDrinks.Api.Controllers
{
    [Route("api/drinks")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly DrinksContext db;
        public DrinksController(DrinksContext db)
        {
            this.db = db;

            /*initial drinks added on startup
              drop and update entire database to show changes:
              dotnet ef database drop
              dotnet ef database update
            */
            if (this.db.Drinks.Count() == 0) {
                this.db.Drinks.Add(new Drinks() {name = "Vodka Cranberry", type = "vodka", image = 
                    "https://dinnersdishesanddesserts.com/wp-content/uploads/2017/12/Cranberry-Vodka-with-Lime-2-square.jpg",
                recipe = "vodka and cranberry" });
                this.db.Drinks.Add(new Drinks() {name = "Vodka Soda", type = "vodka", image = 
                    "http://www.ketelone.com/media/1184/ketel-one-fizz-v2.jpg",
                recipe = "vodka and soda" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "vodka", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "vodka", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "whiskey", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "whiskey", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "whiskey", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "whiskey", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "rum", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "rum", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "rum", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "rum", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "tequila", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "tequila", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "tequila", image = 
                    "",
                recipe = "" });
                this.db.Drinks.Add(new Drinks() {name = "hi", type = "tequila", image = 
                    "",
                recipe = "" });
                this.db.SaveChanges();
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Drinks);
        }
        [HttpGet("{id}", Name = "GetDrinks")]
        public IActionResult GetDrinks(string name)
        {
            //try to find the correct Drinks
            var Drinks = db.Drinks.FirstOrDefault(b => b.name == name);

            //if no Drinks is found with the id key, return HTTP 404 Not Found
            if (Drinks == null)
            {
                return NotFound();
            }

            //return the Drinks inside HTTP 200 OK
            return Ok(Drinks);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Drinks Drinks)
        {
            if (Drinks == null)
            {
                return BadRequest();
            }

            db.Drinks.Add(Drinks);
            db.SaveChanges();

            return CreatedAtRoute("GetDrinks", new {name=Drinks.name},Drinks);
        }

        [HttpPut("{id}")]
        public IActionResult Put(string name, [FromBody]Drinks Drinks)
        {
            //validate the incoming Drinks
            if (Drinks == null || Drinks.name != name)
            {
                return BadRequest();
            }

            //verify the Drinks is in the database
            var DrinksToEdit = db.Drinks.FirstOrDefault(b => b.name == name);
            if (DrinksToEdit == null)
            {
                return NotFound();
            }

            DrinksToEdit.name = Drinks.name;

            db.Drinks.Update(DrinksToEdit);
            db.SaveChanges();

            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(string name)
        {
            var Drinks = db.Drinks.FirstOrDefault(b => b.name == name);

            if (Drinks == null)
            {
                return NotFound();
            }

            db.Drinks.Remove(Drinks);
            db.SaveChanges();

            return NoContent();
        }
    }
}