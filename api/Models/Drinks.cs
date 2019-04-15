using System;

namespace CocktailCookbook.Models
 
{
    public class Drinks
    {
        public int id {get;set;}
        public string name {get;set;}
        public string type {get;set;}
        public string image {get;set;}
        public string recipe {get;set;} 
        public void ChangeRecipe (string recipe){
            this.recipe = recipe;
        }
        public void ChangeType (string type){
            this.type =type;
        }
        public void ChangeName(string name){
            this.name = name;
        }
    }
}