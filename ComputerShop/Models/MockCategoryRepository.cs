using ComputerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryImage="/Images/category/Notebooks.png", CategoryName="Notebooks"},
                new Category{CategoryId=2, CategoryImage="/Images/category/Computers.png", CategoryName="Computers"},
                new Category{CategoryId=3, CategoryImage="/Images/category/Monitors.png", CategoryName="Monitors"},
                new Category{CategoryId=4, CategoryImage="/Images/category/ComputerHardware.png", CategoryName="Computer Hardware"},
                new Category{CategoryId=5, CategoryImage="/Images/category/Tablets.png", CategoryName="Tablets"}
            };

    }
}
