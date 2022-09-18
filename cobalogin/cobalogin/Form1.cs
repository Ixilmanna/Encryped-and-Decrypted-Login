using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace cobalogin
{
    //simple example of encryption and decryption without server side setting.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //taking variable from textbox 
            string username = textboxUser.Text;
            string password = textboxPass.Text;
            
            string encrypted = username +password;
            string decrypted;
            
            //encryption and decryption from a textbox
            encrypted = Convert.ToBase64String(Encoding.Unicode.GetBytes(encrypted));
            decrypted = Encoding.Unicode.GetString(Convert.FromBase64String(encrypted));
            //showing result
            Console.Write(encrypted);
            Console.WriteLine(decrypted);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textboxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
