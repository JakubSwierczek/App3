using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QUIZ : Page
    {
        public QuestionContext question;
        private int i;
        public List<string> images;
        private string goodAnswers;
        public QUIZ()
        {
            this.InitializeComponent();
            question = new QuestionContext();
            images = new List<string>();

                images.Add("ms-appx:///Assets/quiz/Tablice AND.PNG");
                images.Add("ms-appx:///Assets/quiz/Tablice NAND.PNG");
                images.Add("ms-appx:///Assets/quiz/Tablice NOR.PNG");
                images.Add("ms-appx:///Assets/quiz/Tablice NOT.PNG");
                images.Add("ms-appx:///Assets/quiz/Tablice OR.PNG");
                images.Add("ms-appx:///Assets/quiz/Tablice XOR.PNG");

            randomButton_Click(this, null);
        }

        private void randomButton_Click(object sender, RoutedEventArgs e)
        {
            answer.Text = "";
            Random t = new Random();
            i = t.Next(0, 5);
            Question q = question.Questions[i];
            goodAnswers = q.RightAnswer;
            nameTextBlock.Text = q.LogicalGate.ToUpper() + " Gate";
            Uri uri = new Uri(images[i], UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            image.Source = imgSource;
        }


        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            if(goodAnswers == answer.Text)
            {
                answer.Text = "GOOD JOB!";
            }
            else { answer.Text = "WRONG!"; }
        }
    }
}
