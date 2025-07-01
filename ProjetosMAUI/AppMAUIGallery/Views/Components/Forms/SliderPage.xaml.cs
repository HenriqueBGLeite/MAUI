namespace AppMAUIGallery.Views.Components.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void Slider_DragStarted(object sender, EventArgs e)
    {
        LblStatus.Text = $"Iniciou o arrasto!";
    }

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
        LblStatus.Text = $"Finalizou o arrasto!";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (LblValue != null)
            LblValue.Text = "Valor: " + e.NewValue;
    }
}