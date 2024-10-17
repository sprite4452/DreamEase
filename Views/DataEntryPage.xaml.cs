using DreamEase.Models;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace DreamEase.Views
{
    public partial class DataEntryPage : ContentPage
    {
        private List<string> imageSources;

        public DataEntryPage()
        {
            InitializeComponent();
            
            imageSources = new List<string>

            {
                "face_1",
                "face_2",
                "face_3",
                "face_4",
                "face_5"
            };
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is Note note)
            {
                SleepQualitySlider.Value = note.SleepQuality; 
                SleepQualityImage.Source = note.ImageSource; 
            }
        }

        private void SleepQualitySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int index = (int)e.NewValue - 1; 
            if (index >= 0 && index < imageSources.Count)
            {
                Note note = (Note)BindingContext;
                note.ImageSource = imageSources[index];
                SleepQualityImage.Source = note.ImageSource; 
            }
        }

        async void SubmitData(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

           
            note.SleepQuality = (int)SleepQualitySlider.Value;

            bool isSuccess = await App.Database.SaveNoteAsync(note) > 0;
            await DisplayAlert("Information", isSuccess ? "Save successful" : "Failed", "Ok");

            await Navigation.PopAsync();
        }

        async void OnDeleted(System.Object sender, System.EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}
