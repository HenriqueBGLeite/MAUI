using System.Runtime.CompilerServices;

namespace AppShoppingCenter.Views.Cinemas;

public partial class DetailPage : ContentPage
{
    bool firstTime = false;

	public DetailPage()
	{
		InitializeComponent();
	}

    private void PlayPause(object sender, TappedEventArgs e)
    {
        var btn = (Image)sender;

        if (!firstTime)
        {
            var mediaWidthHalf = player.Width / 2 - btn.Width + 10;
            var mediaHeightHalf = player.Height / 2 - btn.Height - 20;

            btn_playpause.TranslateTo(-mediaWidthHalf, mediaHeightHalf, 500);
            firstTime = true;

            MovieText.TranslateTo(0, 40);
        }

        if (player.CurrentState == CommunityToolkit.Maui.Core.MediaElementState.Playing)
        {
            player.Pause();
            btn_playpause.Source = ImageSource.FromFile("play.png");
            SemanticProperties.SetHint(btn_playpause, "Botão de play do trailer.");
        }
        else
        {
            player.Play();
            btn_playpause.Source = ImageSource.FromFile("pause.png");
            SemanticProperties.SetHint(btn_playpause, "Botão de pause do trailer.");
        }
    }
}