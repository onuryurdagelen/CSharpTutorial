using System;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customercustomer = new Customer() { Id=1,LastName="Yurdagelen",Age=23};

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customercustomer);
            Console.WriteLine("Hello World!");
        }
    }
    [ToTable("Customer")]
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("{0},{1},{2},{3} added",
                customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }

    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple = true)]
    class RequiredPropertyAttribute:Attribute
    {
        
    }
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName= tableName;
        }
    }
}
