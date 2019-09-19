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
                Details = "NUTRITION INFORMATION\n1 serving = 140 g (1 medium)\n\nSource of Vitamin C (6% Recommended Daily Intake per serving)\nHigh in fibre (3 g per serving)\nSodium-free (1 mg per serving)\nLOOK FOR\nWell shaped, smooth skinned fruit that is free of bruises. Brownish freckled areas do not affect flavour.\n\nTO STORE\nStore in perforated plastic bags in the refrigerator crisper. Cold, humid storage ensures that apples maintain their crispness, juicy texture and full flavour. Apples soften 10 times faster at room temperature.\n\nTO PREPARE\nRinse and eat. To prevent browning, coat cut surfaces with lemon juice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/32/Dark_apple.png"
            });

            Fruits.Add(new Grocery
            {
                Name = "Mango",
                Location = "Central & South America",
                Details = "NUTRITION INFORMATION\n1 serving = 140 g (1/2 large)\n\nHigh in Vitamin C (45% Recommended Daily Intake per serving)\nSodium-free (0 mg per serving)\nFat-free (0.5 g per serving)\nLOOK FOR\nPlump fruit without green background colour that yields to gentle pressure. Avoid soft, brusied or shrivelled fruit.\n\nTO STORE\nRipen fruit uncovered at room temperature. Cover, refrigerate ripe fruit for up to three days.\n\nTO PREPARE\nRinse. Score skin in four sections and peel like a banana or cut in half and remove pit. Fruit clings to pit so slice as much as possible from it.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Mango_and_cross_section_edit.jpg/1600px-Mango_and_cross_section_edit.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Orange",
                Location = "Central and East Africa",
                Details = "NUTRITION INFORMATION\n1 serving = 140 g (1 medium)\n\nVery high in Vitamin C (120% Recommended Daily Intake per serving)\nSource of fibre (3 g per serving)\nSource of potassium (230 mg per serving)\nSodium-free (0 mg per serving)\nFat-free (0 g per serving)\nLOOK FOR\nFirm fruit, heavy for size with smooth skin, free of soft spots.\n\nTO STORE\nKeep at room temperature for up to one week or refrigerate for up to one month. Room temperature fruit yields the most juice.\n\nTO PREPARE\nRinse, peel and eat. Squeeze thin skinned oranges for juice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Orange-Fruit-Pieces.jpg/1600px-Orange-Fruit-Pieces.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Pine Apple",
                Location = "Central & South America",
                Details = "NUTRITION INFORMATION\n1 serving = 140 g (2 medium slices)\n\nVery high in Vitamin C (70% Recommended Daily Intake per serving)\nLow in sodium(1 5 mg per serving)\nFat-free (0 g per serving)\nLOOK FOR\nLarge plump, fruit with sweet fragrance and crown of deep green (not brown) leaves. Colour is not an indication of ripeness.\n\nTO STORE\nUse immediately or refrigerate uncovered for two or three days.\n\nTO PREPARE\nRinse, discard crown and bottom end. Remove end on strips from top to bottom. Slice and core as desired.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e1/Ananas.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Grapes",
                Location = "Brazil",
                Details = "NUTRITION INFORMATION\n1 serving = 140 g (1 medium)\n\nVery high in Vitamin C (120% Recommended Daily Intake per serving)\nSource of fibre (3 g per serving)\nSource of potassium (230 mg per serving)\nSodium-free (0 mg per serving)\nFat-free (0 g per serving)\nLOOK FOR\nFirm fruit, heavy for size with smooth skin, free of soft spots.\n\nTO STORE\nKeep at room temperature for up to one week or refrigerate for up to one month. Room temperature fruit yields the most juice.\n\nTO PREPARE\nRinse, peel and eat. Squeeze thin skinned oranges for juice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Wine_grapes03.jpg/794px-Wine_grapes03.jpg"
            });

            Fruits.Add(new Grocery
            {
                Name = "Banana",
                Location = "South America",
                Details = "NUTRITION INFORMATION\n1 serving = 140 g (1 large)\n\nHigh in potassium (500 mg per serving)\nSource of Vitamin C (15% Recommended Daily Intake per serving)\nSource of fibre (3 g per serving)\nSodium-free (0 mg per serving)\nFat-free (0 g per serving)\nLOOK FOR\nFirm, unblemished bananas. Yellow with brown speckles indicates a sweet tender fruit.\n\nTO STORE\nKeep at room temperature until desire ripeness. For longer storage, once ripe, refrigerate. The peel will darken but remains fresh.\n\nTO PREPARE\nPeel and eat. To prevent browning, coat surface with lemon juice. Use over ripe bananas in baking.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1c/Bananas_white_background.jpg"
            });




        }
    }
}
