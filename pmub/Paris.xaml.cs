using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pmub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Paris : ContentPage
    {
        public Paris()
        {
            InitializeComponent();
        }



        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "1";

            }
            else
            {
                Parier.Text += "1";

            }
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "2";

            }
            else
            {
                Parier.Text += "2";

            }
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "3";

            }
            else
            {
                Parier.Text += "3";

            }
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "4";

            }
            else
            {
                Parier.Text += "4";

            }
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "5";

            }
            else
            {
                Parier.Text += "5";

            }
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "6";

            }
            else
            {
                Parier.Text += "6";

            }
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "7";

            }
            else
            {
                Parier.Text += "7";

            }
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "8";

            }
            else
            {
                Parier.Text += "8";

            }
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "9";

            }
            else
            {
                Parier.Text += "9";

            }
        }

        private void Btn10_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "10";

            }
            else
            {
                Parier.Text += "10";

            }
        }

        private void Btn11_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "11";

            }
            else
            {
                Parier.Text += "11";

            }
        }

        private void Btn12_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "12";

            }
            else
            {
                Parier.Text += "12";

            }
        }

        private void Btn13_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "13";

            }
            else
            {
                Parier.Text += "13";

            }
        }

        private void Btn14_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "14";

            }
            else
            {
                Parier.Text += "14";

            }
        }

        private void Btn15_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "15";

            }
            else
            {
                Parier.Text += "15";

            }
        }

        private void Btn16_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "16";

            }
            else
            {
                Parier.Text += "16";

            }
        }

        private void Btn17_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "17";

            }
            else
            {
                Parier.Text += "17";

            }
        }

        private void Btn18_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "18";

            }
            else
            {
                Parier.Text += "18";

            }
        }

        private void Btn19_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "19";

            }
            else
            {
                Parier.Text += "19";

            }
        }

        private void Btn20_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "20";

            }
            else
            {
                Parier.Text += "20";

            }
        }

        private void BtnX_Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                Parier.Text = "X";

            }
            else
            {
                Parier.Text += "X";

            }
        }

        private void Btn__Clicked(object sender, EventArgs e)
        {
            if (Parier.Text == "" || Parier.Text == null)
            {

                DisplayAlert("Erreur", "Il faut un nombre d'abord", "OK");

            }
            else
            {
                Parier.Text += "/";

            }
        }

        private void BtnEffacer_Clicked(object sender, EventArgs e)
        {
            Parier.Text = "";
        }
    }

}