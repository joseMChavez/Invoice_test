using Invoice.Models;
using Invoice.Models.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Invoice
{
    public partial class Main : Form
    {
        private readonly ICustomerRepository _customerRepository;
       
        public Main(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerRepository = serviceProvider.GetService<ICustomerRepository>();
            Customer cust = new()
            {
                CustName = "Juan Perez",
                Adress="",
                Status=true,
                CustomerTypeId=1
                
            };
          var res=  _customerRepository?.Add(cust);

           if(res != null )
            {
                MessageBox.Show(res.CustName);
            }
        }
    }
}