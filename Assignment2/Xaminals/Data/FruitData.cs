using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class FruitData
    {
        public static IList<Grocery> Fruits { get; private set; }

        static FruitData()
        {
            Fruits = new List<Grocery>();

            Fruits.Add(new Grocery
            {
                Name = "Apple",
                Location = "Africa & Asia",
                Details = " .fhfjfjfjkjfjfj",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/32/Dark_apple.png"
            });

            Fruits.Add(new Grocery
            {
                Name = "Mango",
                Location = "Central & South America",
                Details = ".vhhhhh",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Mango_and_cross_section_edit.jpg/1600px-Mango_and_cross_section_edit.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Orange",
                Location = "Central and East Africa",
                Details = "",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Orange-Fruit-Pieces.jpg/1600px-Orange-Fruit-Pieces.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Pine Apple",
                Location = "Central & South America",
                Details = "",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e1/Ananas.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Grapes",
                Location = "Brazil",
                Details = "",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Wine_grapes03.jpg/794px-Wine_grapes03.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Banana",
                Location = "South America",
                Details = ".",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1c/Bananas_white_background.jpg"
            });

           

           
        }
    }
}
