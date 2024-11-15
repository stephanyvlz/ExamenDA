using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examenDA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Suma(object sender, EventArgs e)
        {
            double num1 = GetNumber("num1");
            double num2 = GetNumber("num2");
            Resultado(num1 + num2);
        }
        private void Resta(object sender, EventArgs e)
        {
            double num1 = GetNumber("num1");
            double num2 = GetNumber("num2");
            Resultado(num1 - num2);
        }
        private void Multiplicar(object sender, EventArgs e)
        {
            double num1 = GetNumber("num1");
            double num2 = GetNumber("num2");
            Resultado(num1 * num2);
        }
        private void Dividir(object sender, EventArgs e)
        {
            double num1 = GetNumber("num1");
            double num2 = GetNumber("num2");
            if(num1 != 0){

                Resultado(num1 / num2);

            }
        }

        private double GetNumber(string x)
        {
            var entry = this.FindByName<Entry>(x);
            return double.TryParse(entry?.Text, out double number) ? number : 0;
        }
        private void Resultado(double res) {
            var resEntry = this.FindByName<Entry>("res");
            resEntry.Text = res.ToString();
        }
    }
}
