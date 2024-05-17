namespace PracticaDI
{
    public class CustomerService
    {
        IRepository Repository;
        public CustomerService(IRepository repository)
        {
            Repository = repository;
        }

    }

  
}
