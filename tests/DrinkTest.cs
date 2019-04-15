using System;
using Xunit;
using CocktailCookDrinks.Api.Controllers;
using CocktailCookbook.Models;


namespace CocktailCookbook.Api.Tests
{
    
    public class DrinkTest
    {
       
        [Fact]
        public void ChangeRecipe()
        {
            //Arrange
            var drink = new Drinks()
            {
                id =1,
                name = "Cool glass of water",
                type = "water",
                recipe = "Water from the faucet"
            };
            //Act
            var newRecipe = "Water and Ice";
            drink.ChangeRecipe(newRecipe);

            //Assert
            var expectedRecipe = newRecipe.ToString();
            var actualRecipe = drink.recipe.ToString();

            Assert.Equal(expectedRecipe,actualRecipe);
        }
        [Fact]
        public void ChangeType()
        {
            //Arrange
            var drink = new Drinks()
            {
                id =1,
                name = "Cool glass of water",
                type = "water",
                recipe = "Water from the faucet"
            };
            //Act
            var newType = "Beer";
            drink.ChangeType(newType);

            //Assert
            var expectedType = newType.ToString();
            var actualType = drink.type.ToString();

            Assert.Equal(expectedType,actualType);
        }
        public void ChangeName()
        {
            //Arrange
            var drink = new Drinks()
            {
                id =1,
                name = "Cool glass of water",
                type = "water",
                recipe = "Water from the faucet"
            };
            //Act
            var newName = "Cranberry Cocktail";
            drink.ChangeName(newName);
            //Assert
            var expectedName = newName.ToString();
            var actualName = drink.name.ToString();

            Assert.Equal(expectedName,actualName);
        }
    }
}
