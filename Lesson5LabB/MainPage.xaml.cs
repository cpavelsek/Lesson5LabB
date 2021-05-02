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

            //BindingContext = new MainPage();
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

            questionResults.Text = $"{testPercentage}% : You got {testResults} answers correct out of five! ";


        }

        void SwipeItem_InvokedOne(System.Object sender, System.EventArgs e)
        {
            //DisplayAlert("Swipe!", "Inovked", "Okay");

            
            SwipeAnswerOne.Text = "true!";

            //SwipeAnswer.Text;


        }

        //var swipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Left | SwipeDirection.Right };

        void SwipeGestureRecognizer_Swiped(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    SwipeAnswerOne.Text = "Please do something";
                    break;
            }
            


        }

        
        void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    // Handle the swipe
                    break;
                case SwipeDirection.Right:
                    // Handle the swipe
                    break;
                case SwipeDirection.Up:
                    // Handle the swipe
                    break;
                case SwipeDirection.Down:
                    // Handle the swipe
                    break;
            }
        }
    }
}
