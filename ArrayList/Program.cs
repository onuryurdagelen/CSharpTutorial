using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace ArrayListFeatures
{
    class Program
    {
        public static object JsonConvert { get; private set; }
        public static string fullName { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            object[] arr = new object[5];
            int[] arr1 = { 1, 3, 5, 6, 7, };

            //ArrayList
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Onur");
            arrayList.Add("Yurdagelen");
            arrayList.Add(22);
            arrayList.Add("Tokat");
            arrayList.Add(null);
            arrayList.Add(true);

            arrayList.AddRange(arr1); // AddRange dizinin sonuna eleman ekler


            string value1 = (string)arr[0];
            value1 = "asd";
            arrayList.Insert(1, "Abdullah"); // Belirli index'e eleman ekler.
            arrayList.Remove("Abdullah"); // arrayList'teki belirli objeyi siler.
            arrayList.RemoveRange(1, 2); // belirli indeksten baslayarak kac tane eleman silinecegini belirler.
            arrayList.RemoveAt(3); // kacinci indeksteki elemani silecegimizi belirler.
            Console.WriteLine(value1);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********************");
            //List

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*********************");
            var cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Londra");
            cities.Add("Berlin");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Student> values = new List<Student>()
            {
                new Student(){firstName = "Onur",ID = 25},
                new Student(){firstName = "Onur",ID = 25}
            };

            foreach (var value in values)
            {
                Console.WriteLine($"FirstName: {value.firstName} ID: {value.ID}");
            }
            dynamic output = new List<dynamic>();
            dynamic row = new ExpandoObject();
            row.NAME = "My name";
            row.Age = "42";
            output.Add(row);
        }
            public class Student
        {
            public string firstName { get; set; }
            public int ID { get; set; }
            
        }
        interface IStudent
        {
            public string fullName { get; set; }
            public int Identity  { get; set; }
        }
    }
}
