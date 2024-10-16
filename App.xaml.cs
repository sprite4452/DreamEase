using DreamEase.Data;
using DreamEase.Views;


namespace DreamEase
{
    public partial class App : Application
    {
        public static NoteDatabase Database { get; private set; }
        public App()
        {

            InitializeComponent();
            Database = new NoteDatabase();
            MainPage = new AppShell();
        }

       
    }
}
