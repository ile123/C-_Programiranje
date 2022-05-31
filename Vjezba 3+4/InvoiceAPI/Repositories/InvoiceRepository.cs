using Domain.Models;
using InvoiceAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceAPI.Repositories
{
    public class InvoiceRepository
    {
        private readonly InvoiceContext _invoiceContext;
        public InvoiceRepository(InvoiceContext invoiceContext)
        {
            _invoiceContext = invoiceContext;
        }
        public IEnumerable<Invoice> GetInvoices()
        {
            return _invoiceContext.Invoices.ToList();
        }

        public Invoice GetInvoice(int Invoiceid)
        {
            return _invoiceContext.Invoices.FirstOrDefault(invoice => invoice.ID.Equals(Invoiceid));
        }

        public void InsertInvoice(Invoice invoice)
        {
            _invoiceContext.Invoices.Add(invoice);
            _invoiceContext.SaveChanges();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            var InvoiceForUpdate = GetInvoice(invoice.ID);
            if(InvoiceForUpdate != null)
            {
                InvoiceForUpdate.PayerName = invoice.PayerName;
                InvoiceForUpdate.PayerAdress = invoice.PayerAdress;
                InvoiceForUpdate.PayerIBAN = invoice.PayerIBAN;
                InvoiceForUpdate.PayerNumber = invoice.PayerNumber;
                InvoiceForUpdate.RecieverName = invoice.RecieverName;
                InvoiceForUpdate.RecieverAdress = invoice.RecieverAdress;
                InvoiceForUpdate.RecieverNumber = invoice.RecieverNumber;
                InvoiceForUpdate.Emergency = invoice.Emergency;
                InvoiceForUpdate.Amount = invoice.Amount;
                InvoiceForUpdate.Date = invoice.Date;
                InvoiceForUpdate.Description = invoice.Description;
                InvoiceForUpdate.Model = invoice.Model;
                InvoiceForUpdate.Currency = invoice.Currency;

                _invoiceContext.SaveChanges();
            }
        }

        public void DeleteInvoice(int invoiceId)
        {
            var invoiceForDelete = GetInvoice(invoiceId);
            if(invoiceForDelete != null)
            {
                _invoiceContext.Invoices.Remove(invoiceForDelete);
                _invoiceContext.SaveChanges();
            }
        }

    }
}
