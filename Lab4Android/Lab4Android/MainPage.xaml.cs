using CountNumbersLib;
using System;
using System.Linq;
using Xamarin.Forms;

namespace Lab4Android
{
    public partial class MainPage : ContentPage
    {
        double result;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnCalculate(object sender, EventArgs e)
        {
            Count countLib = new Count();
            int countSpaces = countLib.CountSpaces(input.Text);
            int countWords = countLib.CountWords(input.Text);
            int a1 = Math.Min(countSpaces, countWords);
            int an = Math.Max(countSpaces, countWords);
            
            result = countLib.CountSum(a1, an);
            output.Text = $"There are {countWords} words and {countSpaces} spaces in the string.\n" +
                $"The sum of numbers between {a1} and {an} is {result}";
        }

    }
}