using Invoice.Models.Data;
using Invoice.Models.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Invoice
{
    public static class ProgramHelpers
    {
        public static void ConfigureService(this IServiceCollection service)
        {


            service.AddDbContext<InvoiceContext>(options =>
                    options.UseSqlServer("Data Source=JOSEChavezPc\\SQLCODE;Initial Catalog=Test_Invoice;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true", null));
            service.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}