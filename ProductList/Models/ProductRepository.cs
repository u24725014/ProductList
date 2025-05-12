using System.Collections.Generic;

namespace ProductList.Models
{
    public class ProductRepository
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
    {
        new Category { Id = 1, Name = "Electronics", Supplier_id= 1 },
        new Category { Id = 2, Name = "Stationery", Supplier_id = 1 },
        new Category { Id = 3, Name = "Kitchenware", Supplier_id = 2 },
        new Category { Id = 4, Name = "Outdoor Gear", Supplier_id = 2 },
        new Category { Id = 5, Name = "Fitness Equipment", Supplier_id = 3 },
        new Category { Id = 6, Name = "Toys & Games", Supplier_id = 1 },
        new Category { Id = 7, Name = "Pet Supplies", Supplier_id = 2 },
        new Category { Id = 8, Name = "Home Decor", Supplier_id = 3 },
        new Category { Id = 9, Name = "Computer Accessories", Supplier_id = 3 },
    };
        }


        public static List<Product> GetProducts()
        {
            return new List<Product>
    {
        new Product { Id = 1, Name = "Smartwatch", CategoryId = 1 },
        new Product { Id = 2, Name = "Bluetooth Speaker", CategoryId = 1 },
        new Product { Id = 3, Name = "Wireless Headphones", CategoryId = 1 },
        new Product { Id = 4, Name = "Gel Pen Set", CategoryId = 2 },
        new Product { Id = 5, Name = "A4 Notepad", CategoryId = 2 },
        new Product { Id = 6, Name = "Non-stick Frying Pan", CategoryId = 3 },
        new Product { Id = 7, Name = "Stainless Steel Knife Set", CategoryId = 3 },
        new Product { Id = 8, Name = "Cutting Board", CategoryId = 3 },
        new Product { Id = 9, Name = "Hiking Backpack", CategoryId = 4 },
        new Product { Id = 10, Name = "Camping Lantern", CategoryId = 4 },
        new Product { Id = 11, Name = "Resistance Bands", CategoryId = 5 },
        new Product { Id = 12, Name = "Wooden Puzzle", CategoryId = 6 },
        new Product { Id = 13, Name = "Dog Leash", CategoryId = 7 },
        new Product { Id = 14, Name = "LED Table Lamp", CategoryId = 8 },
        new Product { Id = 15, Name = "USB-C Hub", CategoryId = 9 },
        new Product { Id = 16, Name = "Wireless Mouse", CategoryId = 9 },
    };
        }


        public static List<Supplier> GetSuppliers()
        {
            return new List<Supplier>
    {
        new Supplier { Id = 1, Name = "Yaseen" },
        new Supplier { Id = 2, Name = "Joey" },
        new Supplier { Id = 3, Name = "Skipper" },

         };
        }
    }
}