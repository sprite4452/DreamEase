using DreamEase.Models;
using Plugin.Maui.Audio;

namespace DreamEase.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        async void entrypageclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataEntryPage()
            {
                BindingContext = new Note()
            });
        }
        async void musicpageclick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MusicListPage");
        }

        async void tippageclick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TipPage());
        }
    }
}
