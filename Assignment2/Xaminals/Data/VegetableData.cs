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
                    Details = "NUTRITION INFORMATION\n1 serving = 85 g (1/2 medium)\n\nSource of Vitamin C (10% Recommended Daily Intake per serving)\nSodium-free (0 mg per serving)\nFat-free (0 g per serving)\nLOOK FOR\nFirm, small necked onions with brittle outer leaves. Avoid dark spotted or sprouted bulbs.\n\nTO STORE\nKeep uncovered in a dry dark place for up to two months or at room temperature for up to three weeks. Cover cut portions and refrigerate for up to four days.\n\nTO PREPARE\nRinse, trim root and stem ends. Discard outer brittle leaves, Leave whole, cut into quarters, slice or chop.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Mixed_onions.jpg/1280px-Mixed_onions.jpg"
                },

                new Grocery
                {
                    Name = "Potatoes",
                    Location = "Central & South America",
                    Details = "NUTRITION INFORMATION\n1 serving = 79 g (125 mL)\n\nSource of Vitamin C (26% Recommended Daily Intake per serving)\nSource of magnesium (7% Recommended Daily Intake per serving)\nHigh in potassium (323 mg per serving)\nFat-free (0.1 g per serving)\nLOOK FOR\nClean, firm, smooth potatoes, without sprouts, green areas or blemishes.\n\nTO STORE\nKeep in a cool, dry, dark, ventilated place for up to two months or keep at room temperature for up to one week. Do not refrigerate except new potatoes for up to one week.\n\nTO PREPARE\nScrub well. Remove sprouts, decayed and green areas. Leave whole or peel cut as desired.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Patates.jpg/1920px-Patates.jpg"
                },

                new Grocery
                {
                    Name = "Carrot",
                    Location = "Europe",
                    Details = "NUTRITION INFORMATION\n1 serving = 85 g (1 medium or 8 baby carrots or 1 cup matchstick/Julienne carrots)\n\nSource of Vitamin C (10% Recommended Daily Intake per serving)\nSource of potassium (270 mg per serving)\nFat-free (0 g per serving)\nLOOK FOR\nFirm, clean, bright orange carrots that are well shaped. If tops are attached, they should be bright green, fresh looking.\n\nTO STORE\nRemove green leafy tops. Cover, refrigerate unwashed young carrots for up to two weeks. Mature carrots keep 3 to 4 weeks.\n\nTO PREPARE\nTrim root and stem ends. Rinse. Scrub or peel. Leave whole, shred or cut into coins or sticks.\n\n",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Vegetable-Carrot-Bundle-wStalks.jpg/1269px-Vegetable-Carrot-Bundle-wStalks.jpg"
                },

                new Grocery
                {
                    Name = "Green Cabbage",
                    Location = "Central & South America",
                    Details = "NUTRITION INFORMATION\n1 serving = 85 g (11/12 medium head)\n\nVery high in Vitamin C (70% Recommended Daily Intake per serving)\nFat-free (0 g per serving)\nLOOK FOR\nFirm, heavy head with fresh outer leaves and good colouring.\n\nTO STORE\nCover, refrigerate unwashed for up to two weeks.\n\nTO PREPARE\nRemove outer wilted leaves. Rinse. Cut head in half lengthwise and remove core. Cut into wedges or shred. Boil, microwave, steam or stir-fry.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Cabbages_Green_and_Purple_2120px.jpg/1024px-Cabbages_Green_and_Purple_2120px.jpg"
                },

                new Grocery
                {
                    Name = "Corn",
                    Location = "Brazil",
                    Details = "NUTRITION INFORMATION\n1 serving = 85 g (Kernels from 1 medium)\n\nSource of Vitamin C (10% Recommended Daily Intake per serving)\nSource of potassium (240 mg per serving)\nLOOK FOR\nCobs with fresh looking green husks and moist stems. Kernels should be juicy when pierced.\n\nTO STORE\nWrap unhusked ears with damp paper towel. Cover, refrigerate for up to two days.\n\nTO PREPARE\nRemove husks and silk, rinse. To remove kernels, slice lengthwise along cob.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/79/VegCorn.jpg"
                },

                new Grocery
                {
                    Name = "Tomatoes",
                    Location = "South America",
                    Details = "NUTRITION INFORMATION\n1 serving = 85 g (1/2 small; 1/3 medium; 1/5 large; 1 large cocktail tomato; 8 grape tomatoes)\n\nSource of Vitamin C (25% Recommended Daily Intake per serving)\nLow in sodium (10 mg per serving)\nFat-free (0 g per serving)\nLOOK FOR\nSmooth well formed, firm ones, heavy size and uniform in colour.\n\nTO STORE\nKeep tomatoes unwashed and uncovered at room temperature, out of direct sunlight, for up to one week. Do not refrigerate unless very ripe. To ripen, store in a paper bag at room temperature.\n\nTO PREPARE\nRinse. Remove stem. Leave whole or cut as desired. Blanching will remove skins.\n\n*Tomato is actually a fruit, but it is consumed as a veggie.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/50/%E0%B0%9F%E0%B0%AE%E0%B0%BE%E0%B0%9F%E0%B0%BE%E0%B0%B2%E0%B1%81_%282%29.jpg"
                }
            };




        }
    }
}
