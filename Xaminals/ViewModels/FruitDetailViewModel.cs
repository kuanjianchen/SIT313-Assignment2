using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    [QueryProperty("FruitName", "name")]
    public class FruitDetailViewModel : INotifyPropertyChanged
    {
        public string Fruits
        {
            set
            {
                Grocery fruit = FruitData.Fruits.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));

                if (fruit != null)
                {
                    Name = fruit.Name;
                    Location = fruit.Location;
                    Details = fruit.Details;
                    ImageUrl = fruit.ImageUrl;
                    OnPropertyChanged("Name");
                    OnPropertyChanged("Location");
                    OnPropertyChanged("Details");
                    OnPropertyChanged("ImageUrl");
                }
            }
        }

        public string Name { get; set; }
        public string Location { get; private set; }
        public string Details { get; private set; }
        public string ImageUrl { get; private set; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
