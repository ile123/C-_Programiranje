using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public string PayerName { get; set; }
        public string PayerAdress { get; set; }
        public string PayerIBAN { get; set; }
        public string PayerNumber { get; set; }
        public string RecieverName { get; set; }
        public string RecieverAdress { get; set; }
        public string RecieverNumber { get; set; }
        public bool Emergency { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Currency { get; set; }
    }
}
