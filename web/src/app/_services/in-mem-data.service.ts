import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class InMemDataService implements InMemoryDbService {
  createDb() {
    console.log("Creating database...")
    const drinks = [
      {name: "Strawberry Basil Mule", type: "vodka", image: 
      "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/1552320409.png?crop=0.699xw:0.992xh;0.206xw,0.00817xh&resize=980:*",
  recipe: "Ingredients:" + "\n" +
     "8 Strawberries"+ "\n" +
      "Half a Lime"+ "\n" +
      "Basil Sprig"+ "\n" +
      "1.5oz Premium Vodka"+ "\n" +
      "3.5oz Brooklyn Crafted Lemon Lime Ginger Beer"+  "\n" +
      "Instructions:" + "\n" +
      "Muddle fresh strawberries (roughly 6), 2 lime wedges and basil in a copper mule mug. Top with ice, vodka and Brooklyn Crafted. Garnish with strawberry and lime wedge and basil leaves."
       },
       {name: "Black Cherry Beast", type: "vodka", image: 
        "https://hips.hearstapps.com/mac.h-cdn.co/assets/17/05/black-cherry-effen-beast_rs.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
  recipe: "Ingredients:"+ "\n" +
      " 1.5 parts EFFEN Black Cherry Vodka"+ "\n" +
      "2 parts White Cranberry Juice"+ "\n" +
      "0.5 parts Vanilla Simple Syrup"+ "\n" +
      "0.5 parts Fresh Lemon Juice"+ "\n" +
      "Brandied Cherries, for garnish"+ "\n" + "\n" +
      "Instructions:"+ "\n" +
      "Shake and strain all ingredients over fresh ice in a rocks glass. Garnish with brandied cherries"
      },
        {name: "Raspberry Smash", type: "vodka", image: 
        "https://hips.hearstapps.com/mac.h-cdn.co/assets/16/44/raspberry-smash_rs.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
  recipe: "Ingredients:"+ "\n" +
      "6-8 Mint Leaves"+ "\n" +
      "6 Fresh Raspberries"+ "\n" +
      "2 oz. 50 Bleu Vodka"+ "\n" +
      "1 oz. Fresh Lemon Juice"+ "\n" +
      "1 oz. Pomegranate Juice"+ "\n" +
      "½ oz. Simple Syrup"+ "\n" +
      "Garnish: Lemon Wheel, Raspberry, Mint Sprig"+ "\n" + "\n" +
      "Instructions:"+ "\n" +
      "Add mint and raspberries into mixing tin. Lightly muddle, to press berries and to release the oils from mint. Now add the rest of the ingredients. Add ice and shake vigorously. Now strain over crushed ice and garnish with lemon, raspberry, and mint."
      },
      {name: "Fresca Frizz", type: "vodka", image:
      "https://hips.hearstapps.com/mac.h-cdn.co/assets/16/42/bottiglia-fresca-fizz.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
  recipe: "Ingredients:"+ "\n" +
      "4-6 Raspberries"+ "\n" +
      "10-12 Mint Leaves"+ "\n" +
      "1 ½ oz. Grey Goose Vodka"+ "\n" +
      "¾ oz. Fresh Lime Juice"+ "\n" +
      "¾ oz. Wilks & Wilson Raspberry Gomme Syrup"+ "\n" +
      "1 ½ oz. Prosecco (Add after shake)"+ "\n" +
      "Garnish: Raspberry, Mint Sprig"+ "\n" + "\n" +
      "Instructions:"+ "\n" +
      "Add raspberries, six mint leaves, and raspberry syrup into mixing tin, then lightly muddle. Add the rest of the ingredients, except for the prosecco. Add ice and shake vigorously. Now add 1 ½ oz prosecco into mixing tin, and strain over crushed ice with 6 mint leaves on the bottom of the glass. Garnish with raspberry and mint."       
      },
      {name : "Smoked & Salted", type : "whiskey", image : 
                    "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/181115-ibl-f-b-372-1554261182.jpg?crop=0.536xw:1.00xh;0.276xw,0&resize=980:*",
                recipe : "Ingredients"+ "\n" +
                    "2 oz Four Roses Bourbon"+ "\n" +
                    ".25 oz maple syrup (slightly thinned out with hot water ahead of time)"+ "\n" +
                    "5 dashes Crude Smoke & Salt Bitters"+ "\n" + "\n" +
                    "Instructions"+ "\n" +
                    "Stir with ice to chill and dilute. Strain into a double rocks glass with a large ice cube. Garnish with an orange twist"
    },
    {name : "The Hobnail", type : "whiskey", image : 
    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/05/hongkongthepontiachobnail.jpg?crop=1xw:0.8342391304347826xh;center,top&resize=980:*",
recipe : "Ingredients:"+ "\n" +
    "1.5 oz Pig's Nose blended Scotch"+ "\n" +
    ".75 oz ginger syrup"+ "\n" +
    ".75 oz lemon juice"+ "\n" +
    "1 teaspoon Averna Amaro"+ "\n" +
    "2 dashes Angostura bitters"+ "\n" + "\n" +
    "Instructions"+ "\n" +
    "Shake and double strain into a bucket, add ice, and garnish with a healthy swath of orange."
    },
    {name : "Brassmonkey", type : "whiskey", image :
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/05/hongkongstocktonbrassmonkey.jpg?crop=0.445xw:1.00xh;0.156xw,0&resize=980:*",
                recipe : "Ingredients"+ "\n" +
                    "1.5 oz Johnnie Walker Black"+ "\n" +
                    ".75 oz lime juice"+ "\n" +
                    ".75 oz egg whites"+ "\n" +
                    ".5 oz vanilla syrup*"+ "\n" +
                    "3 dashes Chuncho bitters"+ "\n" +
                    ".5 barspoon maca powder"+ "\n" +
                    ".5 barspoon lucuma powder"+ "\n" + "\n" +
                    "Instructions"+ "\n" +
                    "Mix all the ingredients in a mixing glass. Dry shake first, then hard shake with ice. Fine strain into a glass with ice. Garnish with a dash of bitters."+ "\n" + "\n" +
                    "*To make vanilla syrup: combine 2 cups raw sugar, 1 cup water, and 1 vanilla stick that has been sliced open. Slow cook over low heat for 15 minutes."
    },
    {name : "Chad’s Drink", type : "whiskey", image :
                    "https://drivito2.imgix.drizly.com/070500db587880f7/d0e78c297d26/WR-Neat_Hero.png?auto=format%2Ccompress&dpr=2&fm=jpeg&q=30&w=375",
                recipe : "Ingredients:"+ "\n" +
                    "2 oz of Woodford Reserve"+ "\n" +
                    "Instructions:"+ "\n" +
                    "Teach 3610 for a whole semester. Find your finest cocktail glass. Pour and enjoy!"
    },
    {name : "The Lamborn", type : "rum", image :
                    "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/thelamborn-gk-1493417675.jpg?crop=1xw:1xh;center,top&resize=980:*",
                recipe : "Ingredients:"+ "\n" +
                    "2 oz Mount Gay Silver rum"+ "\n" +
                    "2 oz snap pea juice"+ "\n" +
                    "1 oz lime juice"+ "\n" +
                    ".5 oz jasmine syrup"+ "\n" + "\n" +
                    "Instructions:"+ "\n" +
                    "Shake with ice and strain into a highball glass over fresh ice. Garnish with pea shoots and flower."
    },
    {name : "Tropic Bowl", type : "rum", image :
    "https://hips.hearstapps.com/toc.h-cdn.co/assets/16/33/tropic-bowl2_1.jpg?crop=0.447xw:1.00xh;0.401xw,0&resize=*:2136",
recipe : "Ingredients:"+ "\n" +
    "1.5 oz Banks 5 Rum"+ "\n" +
    ".75 oz spiced pineapple syrup"+ "\n" +
    ".5 oz honey syrup"+ "\n" +
    ".5 oz fresh lime juice"+ "\n" +
    "1 strawberry, muddled"+ "\n" +
    "1 mint sprig"+ "\n" +
    "1 pinch Salt"+ "\n" + "\n" +
    "Instructions:"+ "\n" +
    "Muddle, shake, fine strain on crushed ice in a tiki mug. Optional: garnish with two pineapple leaves, orchid and tiki straw."
    },
    {name : "Paid Vacation Days", type : "rum", image :
                    "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/atfohnyc-0796-1491932215.jpg?crop=0.447xw:1.00xh;0.366xw,0&resize=*:2136",
                recipe : "Ingredients:"+ "\n" +
                    "1.5 oz Don Q Rum"+ "\n" +
                    "1.5 oz pineapple juice"+ "\n" +
                    ".75 oz orange juice"+ "\n" +
                    ".5 oz hazelnut liqueur"+ "\n" +
                    "Club soda, to fill"+ "\n" +
                    "Mint, to garnish"+ "\n" + "\n" +
                    "Instructions:"+ "\n" +
                    "Combine rum, pineapple, orange and hazelnut into a shaking tin. Fill halfway with ice and shake for 5 seconds. Strain into a Collins glass with ice. Top with club soda and garnish with a mint sprig."
    },
    {name : "Boozy Affagato", type : "rum", image :
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/16/33/boozy-affogato-naren-young-credit-steven-freihon_1.jpg?crop=0.512xw:0.638xh;0.231xw,0.362xh&resize=*:2136",
               recipe : "Ingredients:"+ "\n" +
                    ".5 oz Appleton Reserve rum"+ "\n" +
                    ".5 oz Fonseca LBV Port"+ "\n" +
                    ".5 oz Licor 43"+ "\n" +
                    ".5 oz agave nectar"+ "\n" +
                    "2 oz cold brew coffee"+ "\n" +
                    "Glass: Latte"+ "\n" +
                    "Garnish: Biscotti (serve with a spoon)"+ "\n" + "\n" +
                    "Instructions:"+ "\n" +
                    "Pour over 1 scoop of gelato."
    },
    {name : "It's Greek To Me", type : "tequila", image : "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/avra-madisons-its-greek-to-me-usd16_alan-battman.jpg?crop=1.0xw:1xh;center,top&resize=980:*",
                   recipe : "Ingredients"+ "\n" +
                    "4 slices ginger"+ "\n" +
                    "1 oz Maestro Dobel Tequila"+ "\n" +
                    ".5 oz Mavrakis Tsipouro"+ "\n" +
                    "1 oz lime juice"+ "\n" +
                    ".75 oz Chambord"+ "\n" +
                    ".5 oz agave"+ "\n" +
                    "1 dash Angostura bitters"+ "\n" +
                    "Instructions"+ "\n" +
                    "Muddle ginger into the bottom of a shaker. Combine all other ingredients in shaker over ice and shake. Strain into a cocktail glass and garnish with sage."
    },
    {name : "The Magui Cactus", type : "tequila", image :
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/andazmayakobamaguicactuscocktailphoto.jpg?crop=0.9652582159624413xw:1xh;center,top&resize=980:*",
                recipe : "Ingredients"+ "\n" +
                    "5 mint leaves"+ "\n" +
                    "1 oz lime juice "+ "\n" +
                    "1 oz Xtanbentum (an anise liqueur made in Mexico's Yucatan region)"+ "\n" +
                    "1 oz simple syrup"+ "\n" +
                    "1.5 oz white tequila"+ "\n" +
                    "2 oz cactus puree"+ "\n" +
                    "Instructions:"+ "\n" +
                    "Shake all ingredients and serve in a rocks glass whose edge is half salted and garnished with mint leaves."
    },
    {name : "The Mystic Marvel", type : "tequila", image :
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/fishbowl-at-dream-midtowns-mystic-marvel-usd13.jpg?crop=1xw:0.9728301886792453xh;center,top&resize=*:2136",
                recipe : "Ingredients"+ "\n" +
                   "1.5 oz Casamigos Tequila"+ "\n" +
                   "1 oz prickly pear purée"+ "\n" +
                    ".75 oz agave"+ "\n" +
                   ".75 oz lime juice"+ "\n" +
                    "Instructions"+ "\n" +
                    "Combine all ingredients in a shaker over ice and shake. Strain over fresh ice and garnish with a salt rim and lime."
    },
    {name : "Blood Orange Margarita", type : "tequila", image :
                    "https://hips.hearstapps.com/toc.h-cdn.co/assets/17/10/bloodorangemargaritajpg.jpeg?crop=1.0xw:1xh;center,top&resize=*:2136",
                 recipe : "Ingredients"+ "\n" +
                    "1.5 oz Silver Tequila"+ "\n" +
                    ".5 oz Cointreau"+ "\n" +
                    ".5 blood orange juice"+ "\n" +
                    ".75 oz simple syrup"+ "\n" +
                    "1 oz lime juice"+ "\n" +
                    "Instructions"+ "\n" +
                    "Fill a mixing tin with ice. Add all ingredients and shake vigorously. Empty shaker contents into a rocks glass with a salted rim. Garnish with a blood orange slice."
    }
    ]
    return {drinks};
  }
}
