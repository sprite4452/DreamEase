using DreamEase.Models;
using System.Collections.ObjectModel;   

namespace DreamEase.Views;

public partial class HistoryPage : ContentPage
{
    ObservableCollection<Note> Notes { get; set; }
    public HistoryPage()
    {
        InitializeComponent();
        Notes = new ObservableCollection<Note>();
        listView.ItemsSource = Notes;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        Notes.Clear();

        listView.ItemsSource = await App.Database.GetNotesAsync();
    }
    async void OnNewNoteClicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new DataEntryPage()
        {
            BindingContext = new Note()
        });
    }

    async void listView_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            var selectedNote = e.SelectedItem as Note;

            await Navigation.PushAsync(new DataEntryPage
            {
                BindingContext = selectedNote
            });
        }
    }
}