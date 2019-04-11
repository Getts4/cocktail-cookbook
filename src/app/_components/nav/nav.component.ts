import { Component, OnInit } from "@angular/core";
import { Location } from "@angular/common";
import { Router } from "@angular/router";

@Component({
  selector: "app-nav",
  templateUrl: "./nav.component.html",
  styleUrls: ["./nav.component.css"]
})
export class NavComponent implements OnInit {
  constructor(private location: Location, public router: Router) {}

  ngOnInit() {}

  /**
   * Navigate to the previous page in router history
   */
  backClicked() {
    if (window.history.length > 2) {
      this.location.back();
    } else {
      this.router.navigate(["/landing"]);
    }
  }
}
