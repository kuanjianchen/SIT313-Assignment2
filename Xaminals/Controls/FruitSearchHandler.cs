﻿using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.Controls
{
    public class FruitSearchHandler : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = FruitData.Fruits
                    .Where(fruit => fruit.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList<Grocery>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            // Note: strings will be URL encoded for navigation (e.g. "Blue Monkey" becomes "Blue%20Monkey"). Therefore, decode at the receiver.
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"fruitdetails?name={((Grocery)item).Name}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/monkeys/monkeydetails?name={((Animal)item).Name}");
        }
    }
}