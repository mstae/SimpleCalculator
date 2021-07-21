using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoCalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        CalculatorLogic c1 = new CalculatorLogic();
        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            double result = c1.SimpleAddition(Double.Parse(num1.Text), Double.Parse(num2.Text));
            res.Text = result.ToString();
        }
        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            double result = c1.SimpleSubtraction(Double.Parse(num1.Text), Double.Parse(num2.Text));
            res.Text = result.ToString();
        }
        private void BtnMul_Clicked(object sender, EventArgs e)
        {
            double result = c1.SimpleMultiplication(Double.Parse(num1.Text), Double.Parse(num2.Text));
            res.Text = result.ToString();
        }
        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            double result = c1.SimpleDivision(Double.Parse(num1.Text), Double.Parse(num2.Text));
            res.Text = result.ToString();
        }
        private void BtnRem_Clicked(object sender, EventArgs e)
        {
            double result = c1.SimpleRemainder(Double.Parse(num1.Text), Double.Parse(num2.Text));
            res.Text = result.ToString();
        }
        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            res.Text = String.Empty;
        }
    }
}
