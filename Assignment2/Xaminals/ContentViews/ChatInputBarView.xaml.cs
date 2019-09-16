using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.ViewModels;

namespace Xaminals.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatInputBarView : Xamarin.Forms.ContentView
    {
        public ChatInputBarView()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                this.SetBinding(HeightRequestProperty, new Binding("Height", BindingMode.OneWay, null, null, null, chatTextInput));
            }
        }

        public void Handle_Completed(object sender, EventArgs e)
        {
            (this.Parent.Parent.BindingContext as ChatPageViewModel).OnSendCommand.Execute(null);
            chatTextInput.Focus();
        }

        public void UnFocusEntry()
        {
            chatTextInput?.Unfocus();
        }
    }
}
