import { Component, OnInit, OnDestroy } from "@angular/core";
import { MatDialog } from "@angular/material";
import { ActivatedRoute } from "@angular/router";

import { DrinkComponent } from "../../_components/drink/drink.component";
import { Drink } from "../../_models/drink.model";
import { DrinkService } from "../../_services/drink.service";

@Component({
  selector: "app-drinks",
  templateUrl: "./drinks.component.html",
  styleUrls: ["./drinks.component.css"]
})
export class DrinksComponent implements OnInit, OnDestroy {
  type: string;
  private sub: any;

  drinks: Drink[] = new Array();

  breakpoint: number;

  constructor(
    public dialog: MatDialog,
    private route: ActivatedRoute,
    private drinkService: DrinkService
  ) {}

  ngOnInit() {
    this.drinkService.getDbDrinks();
    this.drinkService.getArray();
    this.sub = this.route.params.subscribe(params => {
      this.type = params["type"];

      // Set the drinks from route parameter
      this.drinks = this.drinkService.getDrinks(this.type);
      
    });
    this.setGridCols(window);
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  openDialog(dialogData: Drink): void {
    this.dialog.open(DrinkComponent, {
      width: "400px",
      data: dialogData
    });
  }

  onResize(event) {
    this.setGridCols(event.target);
  }

  /**
   * Set the number of columns for the drink grid
   * @param obj - Variable with current inner width
   */
  setGridCols(obj) {
    this.breakpoint =
      obj.innerWidth <= 600 ? 1 : obj.innerWidth <= 1325 ? 2 : 4;
  }
}
