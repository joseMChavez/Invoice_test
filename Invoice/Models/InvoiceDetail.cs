using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
        public float Itbis { get; set; }
        public decimal SubTotal { get; set; }
    }
}
