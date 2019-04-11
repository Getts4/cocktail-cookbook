import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import {
  MatButtonModule,
  MatCardModule,
  MatDialogModule,
  MatGridListModule,
  MatIconModule,
  MatToolbarModule
} from "@angular/material";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { LandingComponent } from "./_pages/landing/landing.component";
import { NavComponent } from "./_components/nav/nav.component";
import { DrinksComponent } from "./_pages/drinks/drinks.component";
import { DrinkComponent } from "./_components/drink/drink.component";

@NgModule({
  declarations: [
    AppComponent,
    LandingComponent,
    NavComponent,
    DrinksComponent,
    DrinkComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserAnimationsModule,
    BrowserModule,
    MatButtonModule,
    MatCardModule,
    MatDialogModule,
    MatGridListModule,
    MatIconModule,
    MatToolbarModule
  ],
  entryComponents: [DrinkComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
