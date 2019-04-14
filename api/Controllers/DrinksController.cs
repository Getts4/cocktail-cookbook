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
                this.db.Drinks.Add(new Drinks() {name = "Strawberry Basil Mule", type = "vodka", image = 
                    "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/1552320409.png?crop=0.699xw:0.992xh;0.206xw,0.00817xh&resize=980:*",
                recipe = "Ingredients:" + Environment.NewLine +
                   "8 Strawberries"+ Environment.NewLine +
                    "Half a Lime"+ Environment.NewLine +
                    "Basil Sprig"+ Environment.NewLine +
                    "1.5oz Premium Vodka"+ Environment.NewLine +
                    "3.5oz Brooklyn Crafted Lemon Lime Ginger Beer"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:" + Environment.NewLine +
                    "Muddle fresh strawberries (roughly 6), 2 lime wedges and basil in a copper mule mug. Top with ice, vodka and Brooklyn Crafted. Garnish with strawberry and lime wedge and basil leaves."
                     });
                this.db.Drinks.Add(new Drinks() {name = "Black Cherry Beast", type = "vodka", image = 
                    "https://hips.hearstapps.com/mac.h-cdn.co/assets/17/05/black-cherry-effen-beast_rs.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
                recipe = "Ingredients:"+ Environment.NewLine +
                   " 1.5 parts EFFEN Black Cherry Vodka"+ Environment.NewLine +
                    "2 parts White Cranberry Juice"+ Environment.NewLine +
                    "0.5 parts Vanilla Simple Syrup"+ Environment.NewLine +
                    "0.5 parts Fresh Lemon Juice"+ Environment.NewLine +
                    "Brandied Cherries, for garnish"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Shake and strain all ingredients over fresh ice in a rocks glass. Garnish with brandied cherries"
                    });
                this.db.Drinks.Add(new Drinks() {name = "Raspberry Smash", type = "vodka", image = 
                    "https://hips.hearstapps.com/mac.h-cdn.co/assets/16/44/raspberry-smash_rs.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
                recipe = "Ingredients:"+ Environment.NewLine +
                    "6-8 Mint Leaves"+ Environment.NewLine +
                    "6 Fresh Raspberries"+ Environment.NewLine +
                    "2 oz. 50 Bleu Vodka"+ Environment.NewLine +
                    "1 oz. Fresh Lemon Juice"+ Environment.NewLine +
                    "1 oz. Pomegranate Juice"+ Environment.NewLine +
                    "½ oz. Simple Syrup"+ Environment.NewLine +
                    "Garnish: Lemon Wheel, Raspberry, Mint Sprig"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Add mint and raspberries into mixing tin. Lightly muddle, to press berries and to release the oils from mint. Now add the rest of the ingredients. Add ice and shake vigorously. Now strain over crushed ice and garnish with lemon, raspberry, and mint."
 });
                this.db.Drinks.Add(new Drinks() {name = "Fresca Frizz", type = "vodka", image = 
                    "https://hips.hearstapps.com/mac.h-cdn.co/assets/16/42/bottiglia-fresca-fizz.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
                recipe = "Ingredients:"+ Environment.NewLine +
                    "4-6 Raspberries"+ Environment.NewLine +
                    "10-12 Mint Leaves"+ Environment.NewLine +
                    "1 ½ oz. Grey Goose Vodka"+ Environment.NewLine +
                    "¾ oz. Fresh Lime Juice"+ Environment.NewLine +
                    "¾ oz. Wilks & Wilson Raspberry Gomme Syrup"+ Environment.NewLine +
                    "1 ½ oz. Prosecco (Add after shake)"+ Environment.NewLine +
                    "Garnish: Raspberry, Mint Sprig"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Add raspberries, six mint leaves, and raspberry syrup into mixing tin, then lightly muddle. Add the rest of the ingredients, except for the prosecco. Add ice and shake vigorously. Now add 1 ½ oz prosecco into mixing tin, and strain over crushed ice with 6 mint leaves on the bottom of the glass. Garnish with raspberry and mint."
});
                this.db.Drinks.Add(new Drinks() {name = "Smoked & Salted", type = "whiskey", image = 
                    "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/181115-ibl-f-b-372-1554261182.jpg?crop=0.536xw:1.00xh;0.276xw,0&resize=980:*",
                recipe = "Ingredients"+ Environment.NewLine +
                    "2 oz Four Roses Bourbon"+ Environment.NewLine +
                    ".25 oz maple syrup (slightly thinned out with hot water ahead of time)"+ Environment.NewLine +
                    "5 dashes Crude Smoke & Salt Bitters"+ Environment.NewLine + Environment.NewLine +
                    "Instructions"+ Environment.NewLine +
                    "Stir with ice to chill and dilute. Strain into a double rocks glass with a large ice cube. Garnish with an orange twist"
 });
                this.db.Drinks.Add(new Drinks() {name = "The Hobnail", type = "whiskey", image = 
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/05/hongkongthepontiachobnail.jpg?crop=1xw:0.8342391304347826xh;center,top&resize=980:*",
                recipe = "Ingredients:"+ Environment.NewLine +
                    "1.5 oz Pig's Nose blended Scotch"+ Environment.NewLine +
                    ".75 oz ginger syrup"+ Environment.NewLine +
                    ".75 oz lemon juice"+ Environment.NewLine +
                    "1 teaspoon Averna Amaro"+ Environment.NewLine +
                    "2 dashes Angostura bitters"+ Environment.NewLine + Environment.NewLine +
                    "Instructions"+ Environment.NewLine +
                    "Shake and double strain into a bucket, add ice, and garnish with a healthy swath of orange."
 });
                this.db.Drinks.Add(new Drinks() {name = "Brassmonkey", type = "whiskey", image = 
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/05/hongkongstocktonbrassmonkey.jpg?crop=0.445xw:1.00xh;0.156xw,0&resize=980:*",
                recipe = "Ingredients"+ Environment.NewLine +
                    "1.5 oz Johnnie Walker Black"+ Environment.NewLine +
                    ".75 oz lime juice"+ Environment.NewLine +
                    ".75 oz egg whites"+ Environment.NewLine +
                    ".5 oz vanilla syrup*"+ Environment.NewLine +
                    "3 dashes Chuncho bitters"+ Environment.NewLine +
                    ".5 barspoon maca powder"+ Environment.NewLine +
                    ".5 barspoon lucuma powder"+ Environment.NewLine + Environment.NewLine +
                    "Instructions"+ Environment.NewLine +
                    "Mix all the ingredients in a mixing glass. Dry shake first, then hard shake with ice. Fine strain into a glass with ice. Garnish with a dash of bitters."+ Environment.NewLine + Environment.NewLine +
                    "*To make vanilla syrup: combine 2 cups raw sugar, 1 cup water, and 1 vanilla stick that has been sliced open. Slow cook over low heat for 15 minutes."
 });
                this.db.Drinks.Add(new Drinks() {name = "Chad’s Drink", type = "whiskey", image = 
                    "https://drivito2.imgix.drizly.com/070500db587880f7/d0e78c297d26/WR-Neat_Hero.png?auto=format%2Ccompress&dpr=2&fm=jpeg&q=30&w=375",
                recipe = "Ingredients:"+ Environment.NewLine +
                    "2 oz of Woodford Reserve"+ Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Teach 3610 for a whole semester. Find your finest cocktail glass. Pour and enjoy!"
 });
                this.db.Drinks.Add(new Drinks() {name = "The Lamborn", type = "rum", image = 
                    "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/thelamborn-gk-1493417675.jpg?crop=1xw:1xh;center,top&resize=980:*",
                recipe = "Ingredients:"+ Environment.NewLine +
                    "2 oz Mount Gay Silver rum"+ Environment.NewLine +
                    "2 oz snap pea juice"+ Environment.NewLine +
                    "1 oz lime juice"+ Environment.NewLine +
                    ".5 oz jasmine syrup"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Shake with ice and strain into a highball glass over fresh ice. Garnish with pea shoots and flower."
 });
                this
                .db.Drinks.Add(new Drinks() {name = "Tropic Bowl", type = "rum", image = 
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/16/33/tropic-bowl2_1.jpg?crop=0.447xw:1.00xh;0.401xw,0&resize=*:2136",
                recipe = "Ingredients:"+ Environment.NewLine +
                    "1.5 oz Banks 5 Rum"+ Environment.NewLine +
                    ".75 oz spiced pineapple syrup"+ Environment.NewLine +
                    ".5 oz honey syrup"+ Environment.NewLine +
                    ".5 oz fresh lime juice"+ Environment.NewLine +
                    "1 strawberry, muddled"+ Environment.NewLine +
                    "1 mint sprig"+ Environment.NewLine +
                    "1 pinch Salt"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Muddle, shake, fine strain on crushed ice in a tiki mug. Optional: garnish with two pineapple leaves, orchid and tiki straw."
 });
                this.db.Drinks.Add(new Drinks() {name = "Paid Vacation Days", type = "rum", image = 
                    "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/atfohnyc-0796-1491932215.jpg?crop=0.447xw:1.00xh;0.366xw,0&resize=*:2136",
                recipe = "Ingredients:"+ Environment.NewLine +
                    "1.5 oz Don Q Rum"+ Environment.NewLine +
                    "1.5 oz pineapple juice"+ Environment.NewLine +
                    ".75 oz orange juice"+ Environment.NewLine +
                    ".5 oz hazelnut liqueur"+ Environment.NewLine +
                    "Club soda, to fill"+ Environment.NewLine +
                    "Mint, to garnish"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Combine rum, pineapple, orange and hazelnut into a shaking tin. Fill halfway with ice and shake for 5 seconds. Strain into a Collins glass with ice. Top with club soda and garnish with a mint sprig."
 });
                this.db.Drinks.Add(new Drinks() {name = "Boozy Affagato", type = "rum", image = 
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/16/33/boozy-affogato-naren-young-credit-steven-freihon_1.jpg?crop=0.512xw:0.638xh;0.231xw,0.362xh&resize=*:2136",
               recipe = "Ingredients:"+ Environment.NewLine +
                    ".5 oz Appleton Reserve rum"+ Environment.NewLine +
                    ".5 oz Fonseca LBV Port"+ Environment.NewLine +
                    ".5 oz Licor 43"+ Environment.NewLine +
                    ".5 oz agave nectar"+ Environment.NewLine +
                    "2 oz cold brew coffee"+ Environment.NewLine +
                    "Glass: Latte"+ Environment.NewLine +
                    "Garnish: Biscotti (serve with a spoon)"+ Environment.NewLine + Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Pour over 1 scoop of gelato."  });

                this.db.Drinks.Add(new Drinks() {name = "It's Greek To Me", type = "tequila", image = "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/avra-madisons-its-greek-to-me-usd16_alan-battman.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
                   recipe = "Ingredients"+ Environment.NewLine +
                    "4 slices ginger"+ Environment.NewLine +
                    "1 oz Maestro Dobel Tequila"+ Environment.NewLine +
                    ".5 oz Mavrakis Tsipouro"+ Environment.NewLine +
                    "1 oz lime juice"+ Environment.NewLine +
                    ".75 oz Chambord"+ Environment.NewLine +
                    ".5 oz agave"+ Environment.NewLine +
                    "1 dash Angostura bitters"+ Environment.NewLine +
                    "Instructions"+ Environment.NewLine +
                    "Muddle ginger into the bottom of a shaker. Combine all other ingredients in shaker over ice and shake. Strain into a cocktail glass and garnish with sage."
});
                this.db.Drinks.Add(new Drinks() {name = "The Magui Cactus", type = "tequila", image = 
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/andazmayakobamaguicactuscocktailphoto.jpg?crop=0.9652582159624413xw:1xh;center,top&resize=980:*",
                recipe = "Ingredients"+ Environment.NewLine +
                    "5 mint leaves"+ Environment.NewLine +
                    "1 oz lime juice "+ Environment.NewLine +
                    "1 oz Xtanbentum (an anise liqueur made in Mexico's Yucatan region)"+ Environment.NewLine +
                    "1 oz simple syrup"+ Environment.NewLine +
                    "1.5 oz white tequila"+ Environment.NewLine +
                    "2 oz cactus puree"+ Environment.NewLine +
                    "Instructions:"+ Environment.NewLine +
                    "Shake all ingredients and serve in a rocks glass whose edge is half salted and garnished with mint leaves."
                     });
                this.db.Drinks.Add(new Drinks() {name = "The Mystic Marvel", type = "tequila", image = 
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/fishbowl-at-dream-midtowns-mystic-marvel-usd13.jpg?crop=1xw:0.9728301886792453xh;center,top&resize=*:2136",
                recipe = "Ingredients"+ Environment.NewLine +
                   "1.5 oz Casamigos Tequila"+ Environment.NewLine +
                   "1 oz prickly pear purée"+ Environment.NewLine +
                    ".75 oz agave"+ Environment.NewLine +
                   ".75 oz lime juice"+ Environment.NewLine +
                    "Instructions"+ Environment.NewLine +
                    "Combine all ingredients in a shaker over ice and shake. Strain over fresh ice and garnish with a salt rim and lime."
 });
                this.db.Drinks.Add(new Drinks() {name = "Blood Orange Margarita", type = "tequila", image = 
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/bloodorangemargaritajpg.jpeg?crop=1.0xw:1xh;center,top&resize=*:2136",
                 recipe = "Ingredients"+ Environment.NewLine +
                    "1.5 oz Silver Tequila"+ Environment.NewLine +
                    ".5 oz Cointreau"+ Environment.NewLine +
                    ".5 blood orange juice"+ Environment.NewLine +
                    ".75 oz simple syrup"+ Environment.NewLine +
                    "1 oz lime juice"+ Environment.NewLine +
                    "Instructions"+ Environment.NewLine +
                    "Fill a mixing tin with ice. Add all ingredients and shake vigorously. Empty shaker contents into a rocks glass with a salted rim. Garnish with a blood orange slice."
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