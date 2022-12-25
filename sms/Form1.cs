using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
namespace sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient request = new WebClient())
            {
                byte[] response = request.UploadValues("http://textbelt.com/text", new NameValueCollection() {
               { "phone", phone_number.Text },{ "message", message.Text },{ "key", "textbelt" },});

                string result = System.Text.Encoding.UTF8.GetString(response);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
