﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        //GET
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonsByCategory(int categoryId);
        bool CategoryExists(int id);

        //POST
        bool CreateCategory(Category category);
        
        //UPDATE
        bool UpdateCategory(Category category);

        //DELETE
        bool DeleteCategory(Category category);
        
        bool Save();
    }
}
