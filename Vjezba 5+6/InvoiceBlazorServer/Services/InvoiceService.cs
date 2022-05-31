using Domain.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InvoiceBlazorServer.Services
{
    public class InvoiceService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44377/api/Invoice";
        public InvoiceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Invoice>> GetInvoices()
        {
            return await _httpClient.GetFromJsonAsync<List<Invoice>>(BaseApiUrl);
        }
        public async Task AddInvoiceAsync(Invoice invoice)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(invoice), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Invoice> GetInvoiceAsync(int invocieId)
        {
            return await _httpClient.GetFromJsonAsync<Invoice>($"{BaseApiUrl}/{invocieId}");
        }
        public async Task UpdateInvoiceAsync(Invoice invoice)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(invoice), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteInvoiceAsync(int invoiceId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{invoiceId}");
            await _httpClient.SendAsync(httpRequest);
        }

    }
}
