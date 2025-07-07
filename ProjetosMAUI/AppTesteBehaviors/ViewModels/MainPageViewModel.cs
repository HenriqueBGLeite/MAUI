using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTesteBehaviors.ViewModels
{
    public class MainPageViewModel
    {
        [RelayCommand]
        private void OnTextSearchChangedFilterList()
        {
            Console.WriteLine("Entrou no metodo");
        }
    }
}
