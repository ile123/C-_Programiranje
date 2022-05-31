using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_API
{
    /// <summary>
    /// Interaction logic for DisplayInvoice.xaml
    /// </summary>
    public partial class DisplayInvoice : Window
    {
        static HttpClient client = new HttpClient();
        public DisplayInvoice()
        {
            InitializeComponent();
        }

        private async void Ispis_Click(object sender, RoutedEventArgs e)
        {
            Invoice inovice = await GetInvoiceAsync($"https://localhost:44377/api/Invoice/{Int32.Parse(InvoiceID.Text)}");
            String sResult = "Api resoult on /api/Invoice/1: " + Environment.NewLine + "Payer Name: " + inovice.PayerName + " Paye Number: " + inovice.PayerNumber;
            Display.Text = sResult;
        }

        static async Task<Invoice> GetInvoiceAsync(string path)
        {
            Invoice invoice = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                invoice = await response.Content.ReadAsAsync<Invoice>();
            }
            return invoice;
        }
    }
}
