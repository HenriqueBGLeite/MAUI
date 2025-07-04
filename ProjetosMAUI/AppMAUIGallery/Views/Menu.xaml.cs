using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;
using System.Runtime.CompilerServices;

namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
	private IGroupComponentRepository _repository;

	public Menu()
	{
		InitializeComponent();

		_repository = new GroupComponentRepository();

		MenuCollection.ItemsSource = _repository.GetGroupComponent();
    }

	private void OnTapComponent(object sender, TappedEventArgs e)
	{
		var component = (Component)e.Parameter;

		if (!component.IsReplaceMainPage)
		{
			((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(component.Page));
			((FlyoutPage)App.Current.MainPage).IsPresented = false;
		}
		else
		{
			App.Current.MainPage = (Page)Activator.CreateInstance(component.Page);
		}
    }

    private void OnTapInicio(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMAUIGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}