using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();

        private int tenthOfSecondsElapsed;
        private int matchesFound;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthOfSecondsElapsed++;
            timeTextBlock.Text = (tenthOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>(){
                "🦁","🦁",
                "🐦","🐦",
                "🐍","🐍",
                "🔥","🔥",
                "♥","♥",
                "👑","👑",
                "⭐","⭐",
                "🚽","🚽",
            };
            //Random random = new Random();
            //foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            //{
            //    int index = random.Next(animalEmoji.Count);
            //    string nextEmoji = animalEmoji[index];
            //    textBlock.Text = nextEmoji;
            //    animalEmoji.RemoveAt(index);
            //}

            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int i = random.Next(animalEmoji.Count);
                textBlock.Text = animalEmoji[i];
                animalEmoji.RemoveAt(i);
            }
        }

        public TextBlock lastTextBlockClicked;
        public bool findingMatch = false;

        public void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock currentTextBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                currentTextBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = currentTextBlock;
                findingMatch = true;
            }
            else if (currentTextBlock.Text == lastTextBlockClicked.Text)
            {
                currentTextBlock.Visibility = Visibility.Hidden;
                matchesFound++;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
            }
        }
    }
}