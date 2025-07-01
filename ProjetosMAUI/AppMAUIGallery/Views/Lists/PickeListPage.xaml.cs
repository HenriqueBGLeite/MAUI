using AppMAUIGallery.Views.Lists.Models;

namespace AppMAUIGallery.Views.Lists;

public partial class PickeListPage : ContentPage
{
	public PickeListPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		PickerControl.ItemsSource = MovieList.GetList();
	}
}