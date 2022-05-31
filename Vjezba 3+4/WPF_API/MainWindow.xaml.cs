using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Upisi_Click(object sender, RoutedEventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.PayerName = PayerName.Text;
            invoice.PayerAdress = PayerAdress.Text;
            invoice.PayerIBAN = PayerIBAN.Text;
            invoice.PayerNumber = PayerNumber.Text;
            invoice.RecieverName = RecieverName.Text;
            invoice.RecieverAdress = RecieverAdress.Text;
            invoice.RecieverNumber = RecieverNumber.Text;
            invoice.Emergency = (bool)Emergency.IsChecked;
            invoice.Amount = Amount.Text;
            invoice.Date = Date.Text;
            invoice.Description = Description.Text;
            invoice.Model = Model.Text;
            invoice.Currency = Currency.Text;
            AddInvoiceAsync(invoice);

        }
        private static async void AddInvoiceAsync(Invoice invoice)
        {
            var body = JsonConvert.SerializeObject(invoice);
            var httpContent = new StringContent(body, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PostAsync("https://localhost:44377/api/Invoice", httpContent);

            if (httpResponse.Content != null)
            {
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
            }
        }

        private void Ispisi_Click(object sender, RoutedEventArgs e)
        {
            DisplayInvoice temp = new DisplayInvoice();
            temp.Show();
        }
    }
}
