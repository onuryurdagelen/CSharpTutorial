using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPhoneMethodExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCheckPhone_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBox1.Text;

            string phoneLast = CheckPhone(phoneNumber);
            if (phoneLast.Contains("Hata"))
            {
                MessageBox.Show(phoneLast);
            }
            else
            {
                //Kullaniciya sms gonderme islemi
                MessageBox.Show($"{phoneLast} telefona mesaj gonderilmistir.");
            }
            
        }
        public string CheckPhone(string phone)
        {

            try
            {
                if (phone == "")
                {
                    return "Hata Mesaji =>Lutfen telefon alanini doldurunuz!";
                }
                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");

                string firstCharacter = phone.Substring(0, 1);
                if (firstCharacter == "9")
                {
                    phone = phone.Substring(1, phone.Length - 1);
                }
                else if (firstCharacter != "0")
                {
                    phone = "0" + phone;
                }
                if (phone.Length == 11)
                {
                    Convert.ToDouble(phone);
                    return phone; 
                }
                return "Hata Mesaji.Lutfen girdiginiz telefon formatini kontrol ediniz.(11 haneli olmalidir.)";
            }
            catch (FormatException ex)
            {

                return ex.Message;
            }
            catch (Exception)
            {
                return "Bilinmeyen Hata!!!";
            }

               
        }
        //05553 355 22 22

        //0553 555 22 22
        //+90553 555 22 22
        //553 555 22 22
        //asdasdasdasd
    }
}
