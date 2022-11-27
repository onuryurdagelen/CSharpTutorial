using System;
using System.Net.NetworkInformation;

namespace Delegates
{
    public delegate void Mydelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);
    //Parametre almayan ve void döndüren operasyonlara elçilik yapıyor denilebilir.


    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cManager= new CustomerManager();
            cManager.SendMessage();
            cManager.ShowAlert();
            Console.WriteLine("*****************");
            Mydelegate myDelegate = cManager.SendMessage;
            //Bir tane elçi oluşturduk.myDelegate örneği cManager.SendMessage metodunu delege etmiş durumda.
            //myDelegate.Invoke(); //ÇIKTI --> SELAAAMM!
            myDelegate(); //ÇIKTI --> SELAAAMM!
            Console.WriteLine("*****************");
            myDelegate += cManager.ShowAlert;
            myDelegate();
            //ÇIKTI --> SELAAMM!
            //ÇIKTI --> DİKKAT!

            /*myDelegate() === myDelegate().Invoke() */

            /* Delegate işleminden istediğimiz metodu çıkartabiliriz. */
            Console.WriteLine("*****************");
            myDelegate -= cManager.SendMessage;
            myDelegate();

            /* DEFENSIVE PROGRAMMING */
            Console.WriteLine("*****************");
            MyDelegate2 myDelegate2 = cManager.SendMessage;

            myDelegate2("SENT MESSAGE BY ONUR");

            Console.WriteLine("*****************");
            myDelegate2 += cManager.ShowAlert;
            myDelegate2("ALERT MY SYSTEM");

            Console.WriteLine("*****************");

            MyDelegate3 myDelegate3 = cManager.Topla;
            Console.WriteLine(myDelegate3(3,4));

        }
    }
    public class CustomerManager
    {
        public void SendMessage() 
        {
            Console.WriteLine("SELAAAMM!");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert()
        {
            Console.WriteLine("DİKKAT!");
        }
        public void ShowAlert(string alert)
        {
            Console.WriteLine(alert);
        }
        public int Topla(int nmb1,int nmb2)
        {
            return nmb1 + nmb2;
        }
    }

}
