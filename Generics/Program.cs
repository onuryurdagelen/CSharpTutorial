using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Izmir", "Adana");
            //List<int> result2 = utilities.BuildList<int>(1,2,3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(
                                    new Customer { CustomerId = 1, CustomerName = "Onur Yurdagelen" }, new Customer { CustomerId = 2, CustomerName = "Bekir Yurdagelen" });

            foreach (var item in result2)
            {
                Console.WriteLine(item.CustomerName);
            }
        }
        class Utilities
        {
            public List<T> BuildList<T>(params T[] items) {

                return new List<T>(items);
            }
        }

        class Product : IEntity
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }
        interface IProductDal:IRepository<Product>
        {
            
        }

        interface ICustomerDal:IRepository<Customer>
        {
            void Custom();
        }
        interface IStudentDal:IRepository<Customer>
        {

        }
        class Student:IEntity
        {

        }
        interface IEntity
        {

        }
        class Customer : IEntity
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Custom()
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }

        //Generics T => Type
        interface IRepository<T> where T:class, IEntity,new() //==> T bir class olmali ve new'lenebilir olmali demektir.IEntity'den implemente edilmeli
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);

            void Update(T entity);
        }
    }
}
