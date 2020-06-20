using System;

namespace RecipeBook.Domain.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }   
        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}
