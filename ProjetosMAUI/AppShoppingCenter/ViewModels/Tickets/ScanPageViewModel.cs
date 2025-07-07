using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShoppingCenter.ViewModels.Tickets
{
    public partial class ScanPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string ticketNumber;

        [RelayCommand]
        private void Scan()
        {
            //TODO - Abrir a câmera
            Shell.Current.GoToAsync("pay");
        }

        partial void OnTicketNumberChanged(string value)
        {
            if (TicketNumber?.Length < 15)
                return;

            var service = App.Current.Handler.MauiContext.Services.GetService<TicketService>();
            var ticket  = service.GetTicket(TicketNumber);

            if (ticket == null)
            {
                App.Current.MainPage.DisplayAlert("Ticket não encontrado!", $"Não localizamos o ticket com o número {TicketNumber}!", "OK");
                return;
            }

            var param = new Dictionary<string, object>()
            {
                { "ticket", ticket }
            };

            Shell.Current.GoToAsync("pay", param);
            TicketNumber = string.Empty;
        }

        [RelayCommand]
        private void List()
        {
            Shell.Current.GoToAsync("list");
        }
    }
}
