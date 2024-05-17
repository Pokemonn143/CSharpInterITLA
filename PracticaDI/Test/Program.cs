// See https://aka.ms/new-console-template for more information
using PracticaDI;

Console.WriteLine("Hello, World!");

    
   CustomerRepository repository = new CustomerRepository();
    CustomerService customerService = new CustomerService(repository);
