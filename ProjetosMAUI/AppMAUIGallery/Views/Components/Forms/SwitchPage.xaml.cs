namespace AppMAUIGallery.Views.Components.Forms;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		var value = e.Value;

		Img.Source = ImageSource.FromFile(value ? "powerOn.png" : "powerOff.png");
    }

    private void Switch_Toggled_Label(object sender, ToggledEventArgs e)
    {
        LblStatus.Text = $"Marcado: {e.Value}";
    }
}