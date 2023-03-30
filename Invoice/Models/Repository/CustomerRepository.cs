using Invoice.Models.Data;


namespace Invoice.Models.Repository
{
    public interface ICustomerRepository
    {
        Customer Add(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
        Customer GetCustomer(int id);
        List<Customer> GetAll();
    }
    public class CustomerRepository : ICustomerRepository
    {
        private readonly InvoiceContext Context;
        public CustomerRepository(InvoiceContext context)
        {
            Context = context;
        }

        public Customer Add(Customer customer)
        {
            try
            {
                Context.Customers.Add(customer);
                Context.SaveChanges();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                if (id == 0) throw new ArgumentException("id is zero");
                var entity = Context.Customers.AsQueryable().Where(x => x.Id == id).FirstOrDefault();
                if (entity != null)
                {
                    Context.Customers.Remove(entity);

                    return Context.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Customer> GetAll()
        {
            try
            {
                return Context.Customers.AsQueryable().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Customer GetCustomer(int id)
        {
            try
            {
                if (id == 0) throw new ArgumentException("id is zero");
                var entity= Context.Customers.AsQueryable().Where(x => x.Id == id).FirstOrDefault();
                if(entity is null)
                {
                    return new Customer();
                }
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Customer customer)
        {
            try
            {
                if(customer == null) throw new ArgumentNullException(nameof(customer));
                 
                Context.Customers.Update(customer);
                return Context.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
