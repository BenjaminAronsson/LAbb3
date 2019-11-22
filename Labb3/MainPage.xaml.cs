using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Labb3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MomsButton1.Clicked += OnButtonClick;
            MomsButton2.Clicked += OnButtonClick;
            MomsButton3.Clicked += OnButtonClick;
        }

        public void OnButtonClick(object sender, EventArgs args)
        {
            double.TryParse(inputField.Text, out double price);

            string momsString = ((Button)sender).Text;
            momsString = momsString.Remove(momsString.Length - 1);
            double.TryParse(momsString, out double moms);

            MakeCalculation(price, moms);
        }

        public void MakeCalculation(double price, double moms)
        {
            double i = 100 - moms;
            double priceValue = i * price / 100;
            double momsValue = price - priceValue;

            inputMomsLabel.Text = moms.ToString() + " %";
            inputPriceLabel.Text = price.ToString() + " Sek";
            outputMomsLabel.Text = momsValue.ToString() + " Sek";
            outPutPriceLabel.Text = priceValue.ToString() + " Sek";

            //Reset
            inputField.Text = "";
        }
    }
}
