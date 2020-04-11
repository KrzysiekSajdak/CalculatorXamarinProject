using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Calculator keyboards functions

        string resultField = "";
        string showYourCalculationsField = "";

        void addNumber(string number)
        {
            resultField += number;
            lblResult.Text = resultField;
        }
        void addCalculationToPreviewField(string number, string countingOperators)
        {
            showYourCalculationsField += " " + resultField + " " + countingOperators;
            lblShowYourCalculations.Text = showYourCalculationsField;
            lblResult.Text = "";
            resultField = "";
        }
        void ClearOnClicked(object sender, EventArgs args)
        {
            lblResult.Text = "";
            resultField = "";
            lblShowYourCalculations.Text = "";
            showYourCalculationsField = "";
        }

        void PlusMinusOnClicked(object sender, EventArgs args)
        {

        }
        void PrecentOnClicked(object sender, EventArgs args)
        {

        }
        void DivideOnClicked(object sender, EventArgs args)
        {
            addCalculationToPreviewField(number: resultField, countingOperators: "/");
        }
        #region all numbers buttons
        void ZeroOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "0");
        }
        void OneOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "1");
        }
        void TwoOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "2");
        }
        void ThreeOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "3");
        }
        void FourOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "4");
        }
        void FiveOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "5");
        }
        void SixOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "6");
        }
        void SevenOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "7");
        }
        void EightOnClicked(object sender,EventArgs args)
        {
            addNumber(number: "8");
        }
        void NineOnClicked(object sender, EventArgs args)
        {
            addNumber(number: "9");
        }
        #endregion
    }
}
