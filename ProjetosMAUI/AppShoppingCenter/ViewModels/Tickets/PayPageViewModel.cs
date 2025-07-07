using AppShoppingCenter.Libraries.Storages;
using AppShoppingCenter.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShoppingCenter.ViewModels.Tickets
{
    [QueryProperty(nameof(Ticket), "ticket")]
    public partial class PayPageViewModel : ObservableObject
    {
        private Ticket ticket;
        private double HourValue = 0.07;

        public Ticket Ticket
        {
            get { return ticket;  }
            set
            {
                GenerateDateOutAndTolerance(value);
                GeneratePrice(value);
                SetProperty(ref ticket, value);
            }
        }

        [ObservableProperty]
        private string pixCode = "00020126360014BR.GOV.BCB.PIX0114+5561999...";

        [RelayCommand]
        private async void CopyAndPaste()
        {
            await Clipboard.Default.SetTextAsync(PixCode);

            //await Task.Delay(30000);
            await Task.Delay(300);

            var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPerferenceStorage>();
            storage.Save(Ticket);

            var param = new Dictionary<string, object>()
            {
                { "ticket", ticket }
            };

            await Shell.Current.GoToAsync("../result", param);
        }

        private void GenerateDateOutAndTolerance(Ticket ticket)
        {
            var random = new Random();
            var hour = random.Next(0, 12);
            var minute = random.Next(0, 59);

            ticket.DateOut = ticket.DateIn.AddHours(hour).AddMinutes(minute);
            ticket.DateTolerance = ticket.DateOut.AddMinutes(30);
        }

        private void GeneratePrice(Ticket ticket)
        {
            var dif = ticket.DateOut.Ticks - ticket.DateIn.Ticks;
            var difTs = new TimeSpan(dif);

            ticket.Price = difTs.TotalMinutes * HourValue;
        }
    }
}
