using System;
using Xamarin.Essentials;

namespace Xaminals.Helpers
{
    public class Settings
    {
        public Settings()
        {


        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = "yes";

        #endregion


        public static string GeneralSettings
        {
            get
            {
                return Preferences.Get(SettingsKey, SettingsDefault);
            }
            set
            {
                Preferences.Set(SettingsKey, value);
            }
        }


        public static string UserName
        {
            get => Preferences.Get(nameof(UserName), string.Empty);
            set => Preferences.Set(nameof(UserName), value);
        }

        public static string Password
        {
            get => Preferences.Get(nameof(Password), string.Empty);
            set => Preferences.Set(nameof(Password), value);
        }


        public static void ClearAllData()
        {
            Preferences.Clear();
        }

    }
}
