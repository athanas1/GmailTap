using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GmailTap
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string Message = "";
        string DotsnDashs = "";

        protected void onDot(object sender, EventArgs e)
        {
            DotsnDashs += ".";
            dotsAndDashs.Text = DotsnDashs;
       }
        protected void onDash(object sender, EventArgs e)
        {
            DotsnDashs += "-";
            dotsAndDashs.Text = DotsnDashs;
        }
        protected void onSpace(object sender, EventArgs e)
        {
            Message += Morse.MorseCoder(DotsnDashs);
            message.Text = Message;
            DotsnDashs = "";
            dotsAndDashs.Text = DotsnDashs;
        }
    }
}
