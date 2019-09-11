using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class VegetableData
    {
        public static IList<Grocery> Vegetables { get; private set; }

        static VegetableData()
        {
            Vegetables = new List<Grocery>
            {
                new Grocery
                {
                    Name = "Onions",
                    Location = "Africa & Asia",
                    Details = "red and brown onions, with and without skin, whole and sliced and in rings",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Mixed_onions.jpg/1280px-Mixed_onions.jpg"
                },

                new Grocery
                {
                    Name = "Potatoes",
                    Location = "Central & South America",
                    Details = ".",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1920px-Patates.jpg"
                },

                new Grocery
                {
                    Name = "Garlic",
                    Location = "Central and East Africa",
                    Details = "",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Allium_sativum._Restra_de_allos_de_Oroso-_Galiza.jpg/1920px-Allium_sativum._Restra_de_allos_de_Oroso-_Galiza.jpg"
                },

                new Grocery
                {
                    Name = "Cabbage",
                    Location = "Central & South America",
                    Details = "",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Cabbages_Green_and_Purple_2120px.jpg/1024px-Cabbages_Green_and_Purple_2120px.jpg"
                },

                new Grocery
                {
                    Name = "Sweet Corn",
                    Location = "Brazil",
                    Details = "",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/79/VegCorn.jpg"
                },

                new Grocery
                {
                    Name = "Tomatoes",
                    Location = "South America",
                    Details = ".",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/50/%E0%B0%9F%E0%B0%AE%E0%B0%BE%E0%B0%9F%E0%B0%BE%E0%B0%B2%E0%B1%81_%282%29.jpg"
                }
            };




        }
    }
}
