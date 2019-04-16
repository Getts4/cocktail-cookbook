import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Drink } from '../_models/drink.model';
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
       }
    ]
    return {drinks};
  }
}
