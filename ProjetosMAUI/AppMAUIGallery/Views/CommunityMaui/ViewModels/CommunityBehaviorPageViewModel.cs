using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppMAUIGallery.Views.CommunityMaui.ViewModels
{
    public class CommunityBehaviorPageViewModel : BindableObject
    {
        public ICommand PressedCommand { get; set; }

        public CommunityBehaviorPageViewModel()
        {
            PressedCommand = new Command(Pressed);
        }

        private void Pressed()
        {
            App.Current.MainPage.DisplayAlert("Fui pressionado!", "Fui pressionado via Behavior!", "OK");
        }
    }
}
