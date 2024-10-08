using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models.Repositories
{
    public static class ShirtRepository
    {
        public static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId = 1, Brand = "My Brand", Color = "Red", Gender = "Men", Price = 30, Size = 9},
            new Shirt {ShirtId = 2, Brand = "My Brand", Color = "Blue", Gender = "Men", Price = 35, Size = 10},
            new Shirt {ShirtId = 3, Brand = "Your Brand", Color = "Black", Gender = "Women", Price = 29.5, Size = 8},
            new Shirt {ShirtId = 4, Brand = "Your Brand", Color = "Pink", Gender = "Women", Price = 37, Size = 6}
        };

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id); 
        }
    }
}