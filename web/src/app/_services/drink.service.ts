import { Injectable } from "@angular/core";

import { Drink } from "../_models/drink.model";

@Injectable({
  providedIn: "root"
})
export class DrinkService {
  constructor() {}

  /**
   * Get all the drinks for a specific liquor
   * @param {string} type - Liquor type for which we want drink list
   */
  getDrinks(type: string): Drink[] {
    console.log(`Fetching data for ${type}...`);
    if (type === 'vodka') {
    return [
      {
        name: "Vodka Cranberry",
        image:
          "https://dinnersdishesanddesserts.com/wp-content/uploads/2017/12/Cranberry-Vodka-with-Lime-2-square.jpg"
      },
      {
        name: "Vodka Soda",
        image: "http://www.ketelone.com/media/1184/ketel-one-fizz-v2.jpg"
      },
      {
        name: "Vodka Cranberry",
        image:
          "https://dinnersdishesanddesserts.com/wp-content/uploads/2017/12/Cranberry-Vodka-with-Lime-2-square.jpg"
      },
      {
        name: "Vodka Soda",
        image: "http://www.ketelone.com/media/1184/ketel-one-fizz-v2.jpg"
      }
    ];
  }
  if (type === 'whiskey') {
    return [
      {
    name: "whiskey",
    image: ""
      }
    ]
  }
  }
}