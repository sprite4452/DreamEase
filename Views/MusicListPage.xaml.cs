using CustomIconFont;
using DreamEase.Models;
using Plugin.Maui.Audio;

namespace DreamEase.Views;

public partial class MusicListPage : ContentPage
{
    readonly IAudioManager audioManager;
    private IAudioPlayer currentPlayer;
    public MusicListPage(IAudioManager audioManager)
	{
		InitializeComponent();
		this.audioManager = audioManager;
	}
    
    public async void MoonClick(object sender, EventArgs e)
    {
        if (currentPlayer != null && currentPlayer.IsPlaying) 
        {
            currentPlayer.Pause();
            moonstatus.Text = IconFont.Play_arrow;
            waterstatus.Text = IconFont.Play_arrow;
            medstatus.Text = IconFont.Play_arrow;
            rainstatus.Text = IconFont.Play_arrow;
            windstatus.Text = IconFont.Play_arrow;
            return;
        }

        var file = await FileSystem.OpenAppPackageFileAsync("moon.mp3");
        currentPlayer = audioManager.CreatePlayer(file);
        currentPlayer.Play();
        moonstatus.Text = IconFont.Pause;
    }
    public async void WaterClick(object sender, EventArgs e)
    {
        if (currentPlayer != null && currentPlayer.IsPlaying)
        {
            currentPlayer.Pause();
            moonstatus.Text = IconFont.Play_arrow;
            waterstatus.Text = IconFont.Play_arrow;
            medstatus.Text = IconFont.Play_arrow;
            rainstatus.Text = IconFont.Play_arrow;
            windstatus.Text = IconFont.Play_arrow;
            return;
        }

        var file = await FileSystem.OpenAppPackageFileAsync("waterfall.mp3");
        currentPlayer = audioManager.CreatePlayer(file);
        currentPlayer.Play();
        waterstatus.Text = IconFont.Pause;
    }
    public async void MeditationClick(object sender, EventArgs e)
    {
        if (currentPlayer != null && currentPlayer.IsPlaying)
        {
            currentPlayer.Pause();
            moonstatus.Text = IconFont.Play_arrow;
            waterstatus.Text = IconFont.Play_arrow;
            medstatus.Text = IconFont.Play_arrow;
            rainstatus.Text = IconFont.Play_arrow;
            windstatus.Text = IconFont.Play_arrow;
            return;
        }

        var file = await FileSystem.OpenAppPackageFileAsync("meditation.mp3");
        currentPlayer = audioManager.CreatePlayer(file);
        currentPlayer.Play();
        medstatus.Text = IconFont.Pause;
    }
    public async void RainClick(object sender, EventArgs e)
    {
        if (currentPlayer != null && currentPlayer.IsPlaying)
        {
            currentPlayer.Pause();
            moonstatus.Text = IconFont.Play_arrow;
            waterstatus.Text = IconFont.Play_arrow;
            medstatus.Text = IconFont.Play_arrow;
            rainstatus.Text = IconFont.Play_arrow;
            windstatus.Text = IconFont.Play_arrow;
            return;
        }

        var file = await FileSystem.OpenAppPackageFileAsync("rain.mp3");
        currentPlayer = audioManager.CreatePlayer(file);
        currentPlayer.Play();
        rainstatus.Text = IconFont.Pause;
    }
    public async void WindClick(object sender, EventArgs e)
    {
        if (currentPlayer != null && currentPlayer.IsPlaying)
        {
            currentPlayer.Pause();
            moonstatus.Text = IconFont.Play_arrow;
            waterstatus.Text = IconFont.Play_arrow;
            medstatus.Text = IconFont.Play_arrow;
            rainstatus.Text = IconFont.Play_arrow;
            windstatus.Text = IconFont.Play_arrow;
            return;
        }

        var file = await FileSystem.OpenAppPackageFileAsync("wind.mp3");
        currentPlayer = audioManager.CreatePlayer(file);
        currentPlayer.Play();
        windstatus.Text = IconFont.Pause;
    }
}