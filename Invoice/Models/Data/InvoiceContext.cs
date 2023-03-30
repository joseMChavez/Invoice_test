using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Models.Data
{
    public class InvoiceContext :DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options):base(options) { }

        public virtual DbSet<Invoice> Invoices { get; set;}
        public virtual DbSet<InvoiceDetail> InvoicesDetails { get; set;}
        public virtual DbSet<Customer> Customers { get; set;}
    }
}
