using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tip = typeof(DortIslem);

            //var dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla());

            var instance = Activator.CreateInstance(tip,6,7);

            //MethodInfo methodInfo = instance.GetType().GetMethod("Topla");
            //Console.WriteLine(methodInfo.Invoke(instance, null));

            var metotlar = tip.GetMethods();

            foreach (var item in metotlar)
            {
                Console.WriteLine("Metot Adı: "+item.Name);
                foreach (var parametre in item.GetParameters())
                {
                    Console.WriteLine("Parametre adı: "+parametre.Name);
                }
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Adı: "+attribute.GetType().Name);
                }
            }
           

            Console.WriteLine("Hello World!");
        }
    }
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1= sayi1;
            _sayi2= sayi2;
        }


        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;   
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla()
        {
            return _sayi1 + _sayi2;
        }
    }
}
