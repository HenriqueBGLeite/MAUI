﻿using AppShoppingCenter.Models;
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
