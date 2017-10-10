using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DialPad
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked1(object sender, EventArgs e)
        {
            DialText.Text += B1.Text;
        }
        private void Button_OnClicked2(object sender, EventArgs e)
        {
            DialText.Text += B2.Text;
        }
        private void Button_OnClicked3(object sender, EventArgs e)
        {
            DialText.Text += B3.Text;
        }
        private void Button_OnClicked4(object sender, EventArgs e)
        {
            DialText.Text += B4.Text;
        }
        private void Button_OnClicked5(object sender, EventArgs e)
        {
            DialText.Text += B5.Text;
        }
        private void Button_OnClicked6(object sender, EventArgs e)
        {
            DialText.Text += B6.Text;
        }
        private void Button_OnClicked7(object sender, EventArgs e)
        {
            DialText.Text += B7.Text;
        }
        private void Button_OnClicked8(object sender, EventArgs e)
        {
            DialText.Text += B8.Text;
        }
        private void Button_OnClicked9(object sender, EventArgs e)
        {
            DialText.Text += B9.Text;
        }
        private void Button_OnClicked0(object sender, EventArgs e)
        {
            DialText.Text += B0.Text;
        }
        private void Button_OnClickedDial(object sender, EventArgs e)
        {
            DialText.Text += "";
        }

        private void Button_OnClickedDel(object sender, EventArgs e)
        {
            var nLen = DialText.Text.Length;
            if (nLen > 0)
            {
                DialText.Text = DialText.Text.Substring(0, nLen - 1);
            }
        }
    }
}
