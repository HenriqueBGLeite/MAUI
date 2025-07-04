using CommunityToolkit.Maui.Views;

namespace AppMAUIGallery.Views.CommunityMaui.Popups;

public partial class MyPopup : Popup
{
	public MyPopup()
	{
		InitializeComponent();
	}

    private void OnClickedClose(object sender, EventArgs e)
    {
		this.Close();
    }

    private void OnClickedSaveEmailAndClose(object sender, EventArgs e)
    {
        this.Close();
    }
}