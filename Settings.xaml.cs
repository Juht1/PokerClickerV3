using Plugin.Maui.Audio;

namespace PokerClickerV3;

public partial class Settings : ContentPage
{
    int count = 0;
    private IAudioManager audioManager;

    public Settings(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("FTech.mp3"));

        player.Play();
    }
}
