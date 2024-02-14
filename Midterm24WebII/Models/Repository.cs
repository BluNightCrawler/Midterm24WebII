namespace Midterm24WebII.Models
{
    public class Repository
    {
        private CustomerDbContext context;
        public Repository(CustomerDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Customer> Info => context.Infos;
    }
}
