using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTen.Services;

namespace EightToTen.Services
{
    public class serviceThree
    {
        private readonly Dictionary<string, List<string>> _restaurantCategories = new()
        {
           { "Italian", new List<string> { "Olive Garden", "Carbone", "Eataly", "Mama Mia", "La Trattoria", "Fratelli", "Luigi's", "Napoli", "Bella Vita", "Ciao Ciao" } },
            { "Japanese", new List<string> { "Sushi Zanmai", "Ippudo", "Nobu", "Katsuya", "Ichiban", "Umi Sushi", "Matsuri", "Sakura", "Yoshino", "Tokyo Grill" } },
            { "Mexican", new List<string> { "Chipotle", "Taco Bell", "La Taqueria", "El Camino", "Cantina Laredo", "Casa Bonita", "Mi Cocina", "Pueblo", "Agave", "Cielito Lindo" } },
            { "American", new List<string> { "Cheesecake Factory", "TGI Friday's", "Applebee's", "Shake Shack", "In-N-Out", "Five Guys", "Burger King", "Wendy's", "Denny's", "Red Robin" } }
             
        };  
        public string Pick(string category)
        {
            if (!_restaurantCategories.ContainsKey(category))
            {
                throw new ArgumentException("Category not found.");
            }

            var formattedCategory = char.ToUpper(category[0]) + category.Substring(1).ToLower();

            if (!_restaurantCategories.ContainsKey(formattedCategory))
            {
                throw new ArgumentException("Category not found.");
            }

            var restaurants = _restaurantCategories[category];
            var random = new Random();
            int index = random.Next(restaurants.Count);
            return restaurants[index];
        }

        public List<string> GetCategories()
        {
            return _restaurantCategories.Keys.ToList();
        }
    }
}