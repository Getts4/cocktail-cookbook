import { Component, Inject, OnInit } from "@angular/core";
import { MatDialogRef, MAT_DIALOG_DATA } from "@angular/material";
import { DrinkService } from '../../_services/drink.service';
import { Drink } from "../../_models/drink.model";

@Component({
  selector: "app-drink",
  templateUrl: "./drink.component.html",
  styleUrls: ["./drink.component.css"]
})
export class DrinkComponent implements OnInit {
  constructor(
    private drinkService: DrinkService,
    public dialogRef: MatDialogRef<DrinkComponent>,
    @Inject(MAT_DIALOG_DATA) public drink: Drink
  ) {}

  ngOnInit() {
    this.drinkService.getDbDrinks();
    this.drinkService.getArray();
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
