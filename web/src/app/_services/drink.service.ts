import { Injectable } from "@angular/core";
import { Drink } from "../_models/drink.model";
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: "root"
})
export class DrinkService {
  constructor(
    private http: HttpClient
    ){}
  /**
   * Get all the drinks for a specific liquor
   * @param {string} type - Liquor type for which we want drink list
   */

  private drinksUrl = 'https://localhost:5001/api/drinks';
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error('${operation} failed: ${error.message}');
      return of(result as T);
    };
  }

  getDbDrinks() {
    return this.http.get<Drink[]>(this.drinksUrl).pipe(
      tap(_ => console.log('fetched drinks')),
      catchError(this.handleError<Drink[]>('getDrinks', []))
    );
  }

  getArray() {
    this.getDbDrinks().subscribe(drinks => this.drinks = drinks);
  }

  drinks: Drink[] = new Array();
  vodkaDrinks: Drink[] = new Array();
  whiskeyDrinks: Drink[] = new Array();
  rumDrinks: Drink[] = new Array();
  tequilaDrinks: Drink[] = new Array();  

  getDrinks(type: string): Drink[] {
    console.log(`Fetching data for ${type}...`);

    if (type === 'vodka') {
      if (this.vodkaDrinks.length === 0) {
        for (let index = 0; index < this.drinks.length; index++) {
          if (this.drinks[index].type === 'vodka') {
            this.vodkaDrinks.push(this.drinks[index]);
          }
        }
      }
      console.log(this.vodkaDrinks);
      return this.vodkaDrinks;
    }

    if (type === 'whiskey') {
      if (this.whiskeyDrinks.length === 0) {
        for (let index = 0; index < this.drinks.length; index++) {
          if (this.drinks[index].type === 'whiskey') {
            this.whiskeyDrinks.push(this.drinks[index]);
          }
        }
      }
      console.log(this.whiskeyDrinks);
      return this.whiskeyDrinks;
    }

    if (type === 'rum') {
      if (this.rumDrinks.length === 0) {
        for (let index = 0; index < this.drinks.length; index++) {
          if (this.drinks[index].type === 'rum') {
            this.rumDrinks.push(this.drinks[index]);
          }
        }
      }
      console.log(this.rumDrinks);
      return this.rumDrinks;
    }

    if (type === 'tequila') {
      if (this.tequilaDrinks.length === 0) {
        for (let index = 0; index < this.drinks.length; index++) {
          if (this.drinks[index].type === 'tequila') {
            this.tequilaDrinks.push(this.drinks[index]);
          }
        }
      }
      console.log(this.tequilaDrinks);
      return this.tequilaDrinks;
    }
  }
}