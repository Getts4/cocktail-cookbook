using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocktailCookDrinks.Models;
using CocktailCookDrinks.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace CocktailCookDrinks.Api.Controllers
{
    [Route("api/drinks")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly DrinksContext db;
        public DrinksController(DrinkContext db)
        {
            this.db = db;

            if (this.db.Drinks.Count() == 0) {
                this.db.Drinks.Add(new Drinks()
                {
                    
                });
                this.db.Drinks.Add(new Drinks()
                {
                    
                });
                this.db.Drinks.Add(new Drinks()
                {
                    
                });
                this.db.SaveChanges();
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Drinks);
        }
        [HttpGet("{id}", Name = "GetDrinks")]
        public IActionResult GetDrinks(int id)
        {
            //try to find the correct Drinks
            var Drinks = db.Drinks.FirstOrDefault(b => b.Id == id);

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

            return CreatedAtRoute("GetDrinks", new {id=Drinks.Id},Drinks);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Drinks Drinks)
        {
            //validate the incoming Drinks
            if (Drinks == null || Drinks.Id != id)
            {
                return BadRequest();
            }

            //verify the Drinks is in the database
            var DrinksToEdit = db.Drinks.FirstOrDefault(b => b.Id == id);
            if (DrinksToEdit == null)
            {
                return NotFound();
            }

            DrinksToEdit.Title = Drinks.Title;
            DrinksToEdit.ISBN = Drinks.ISBN;

            db.Drinks.Update(DrinksToEdit);
            db.SaveChanges();

            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Drinks = db.Drinks.FirstOrDefault(b => b.Id == id);

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