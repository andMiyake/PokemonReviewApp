using AutoMapper;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Controllers;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Tests.Controller
{
    public class CategoryControllerTests
    {
        //[Fact]
        //public void GetCategories_The_Correct_Number_Of_Recipes()
        //{
        //    // Arrange
        //    int count = 3;
        //    var dataStore = A.Fake<ICategoryRepository>();
        //    var mapper = A.Fake<IMapper>();
        //    var controller = new CategoryController(dataStore, mapper);

        //    // Act
        //    var actionResult = controller.GetCategories();

        //    // Assert
        //    var result = actionResult as OkObjectResult;
        //    var returnCategories = result.Value as IEnumerable<Category>;
        //    Assert.Equal(count, returnCategories.Count());
        //}
    }
}