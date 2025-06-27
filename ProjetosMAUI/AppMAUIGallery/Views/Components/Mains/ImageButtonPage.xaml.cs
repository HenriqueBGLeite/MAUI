namespace AppMAUIGallery.Views.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	bool buttonState = false;

	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		buttonState = !buttonState;

		var powerOff = "powerOff.png";
		var powerOn = "powerOn.png";

		var button = (ImageButton)sender;

		button.Source = buttonState ? ImageSource.FromFile(powerOn) : ImageSource.FromFile(powerOff);
    }
}