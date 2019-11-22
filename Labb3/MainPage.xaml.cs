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
            double formula = 1 / (moms / 100 + 1); 
            double priceValue = formula * price;
            double momsValue = price - priceValue;

            inputMomsLabel.Text = moms.ToString("0.00") + " %";
            inputPriceLabel.Text = price.ToString("0.00") + " Sek";
            outputMomsLabel.Text = momsValue.ToString("0.00") + " Sek";
            outPutPriceLabel.Text = priceValue.ToString("0.00") + " Sek";
        }
    }
}
