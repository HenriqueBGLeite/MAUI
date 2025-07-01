namespace AppMAUIGallery.Views.Components.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        if(LblValue != null)
            LblValue.Text = "Nova data: " + e.NewDate.ToString();
    }
}