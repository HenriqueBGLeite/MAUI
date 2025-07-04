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
        public ICommand MyCommand { get; }

        public CommunityBehaviorPageViewModel()
        {
            PressedCommand = new Command(Pressed);
            MyCommand = new Command(OnMyCommand);
        }

        private void Pressed()
        {
            App.Current.MainPage.DisplayAlert("Fui pressionado!", "Fui pressionado!", "OK");
        }
        private void OnMyCommand()
        {
            App.Current.MainPage.DisplayAlert("Fui pressionado!", "Fui pressionado!", "OK");
        }
    }
}
