import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

import { LandingComponent } from "./_pages/landing/landing.component";
import { DrinksComponent } from "./_pages/drinks/drinks.component";

const routes: Routes = [
  {
    path: "",
    redirectTo: "landing",
    pathMatch: "full"
  },
  {
    path: "landing",
    component: LandingComponent,
    pathMatch: "full"
  },
  {
    path: "drinks/:type",
    component: DrinksComponent,
    pathMatch: "full"
  },
  {
    path: "**",
    redirectTo: "landing"
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
