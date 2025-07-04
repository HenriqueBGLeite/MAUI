using AppShoppingCenter.Models;
using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShoppingCenter.ViewModels.Stores
{
    public partial class ListPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textSearch;

        private List<Establishment> establishmentsFull;

        [ObservableProperty]
        private List<Establishment> establishmentsFiltered;

        [ObservableProperty]
        string name = string.Empty;

        private bool IsNameLengthValid { get; set; }

        [RelayCommand]
        private void NameChanged()
        {

            if (Name.Length >= 3)
                IsNameLengthValid = true;
            else
                IsNameLengthValid = false;
        }

        [RelayCommand(CanExecute = nameof(IsNameLengthValid))]
        async Task Submit()
        {
            
        }

        public ListPageViewModel()
        {
            var service = new StoreService();
            establishmentsFull = service.GetStores();
            establishmentsFiltered = establishmentsFull.ToList();
        }

        [RelayCommand]
        private void OnTextSearchChangedFilterList()
        {
            EstablishmentsFiltered = establishmentsFull
                .Where(
                    a => a.Name.ToLower().Contains(TextSearch.ToLower())
                )
                .ToList();
        }
    }
}
