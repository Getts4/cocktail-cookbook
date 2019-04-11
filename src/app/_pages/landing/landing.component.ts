import { Component, OnInit } from "@angular/core";
import { Drink } from "../../_models/drink.model";

@Component({
  selector: "app-landing",
  templateUrl: "./landing.component.html",
  styleUrls: ["./landing.component.css"]
})
export class LandingComponent implements OnInit {
  defaultDrinks: Drink[] = [
    {
      name: "vodka",
      image:
        "https://images.pexels.com/photos/162986/vodka-ruska-alcohol-drunkenness-162986.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500"
    },
    {
      name: "whiskey",
      image:
        "https://images.pexels.com/photos/372959/pexels-photo-372959.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
    },
    {
      name: "rum",
      image:
        "https://images.britcdn.com/wp-content/uploads/2017/10/rum-myths-you-shouldnt-believe.jpg?w=1000&auto=format"
    },
    {
      name: "tequila",
      image:
        "https://res.cloudinary.com/sagacity/image/upload/c_crop,h_2848,w_4288,x_0,y_0/c_limit,dpr_auto,f_auto,fl_lossy,q_80,w_1080/tequila-shots_zqraxp.jpg"
    }
  ];

  breakpoint: number;

  constructor() {}

  ngOnInit() {
    this.setGridCols(window);
  }

  onResize(event) {
    this.setGridCols(event.target);
  }

  /**
   * Set the number of columns for the drink grid
   * @param obj - Variable with current inner width
   */
  setGridCols(obj) {
    this.breakpoint = obj.innerWidth <= 600 ? 1 : 2;
  }
}
