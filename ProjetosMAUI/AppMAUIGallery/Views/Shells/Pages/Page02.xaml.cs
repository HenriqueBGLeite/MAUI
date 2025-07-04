using AppMAUIGallery.Models;
using System.Web;

namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page02 : ContentPage
{
	public Page02()
	{
		InitializeComponent();
	}

    private void GoToStep1WithSimpleParameters(object sender, EventArgs e)
    {
		var texto = "Este é um parâmetro passado pela tela anterior!";
		var textoCodificado = HttpUtility.UrlEncode(texto);

		Shell.Current.GoToAsync($"//page02/page02step01?msg={textoCodificado}");
    }

    private void GoToStep1WithComplexParameters(object sender, EventArgs e)
    {
		var person = new Person() { Id = 1, Name = "Henrique Batista", Email = "henrique.batista@gmail.com" };

		var parameters = new Dictionary<string, object>
		{
			{ "msg", "Este é um parâmetro passado de forma complexa!" },
			{ "person", person }
		};

		Shell.Current.GoToAsync("//page02/page02step01", parameters);
    }
}