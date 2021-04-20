using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lesson5LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnToggled(object sender, ToggledEventArgs e)
        {
            // Perform an action after examining e.Value

            if (QuestionOne.IsToggled)
            {
                questionResults.Text = " You answered true to the first Question.";
            }
        }

        void CalculateResults_Clicked(System.Object sender, System.EventArgs e)
        {
            bearQuestions.IsVisible = !bearQuestions.IsVisible;
            double testResults = 0;

            if (QuestionOne.IsToggled)
            {
                testResults++;
            }
            if (QuestionTwo.IsToggled)
            {
                testResults++;
            }
            if (!QuestionThree.IsToggled)
            {
                testResults++;
            }
            if (QuestionFour.IsToggled)
            {
                testResults++;
            }
            if (QuestionFive.IsToggled)
            {
                testResults++;
            }

            double testPercentage = (testResults / 5) * 100;

            questionResults.Text = $"{testPercentage}% : You got {testResults} answers correct out of five ";


        }
    }
}
