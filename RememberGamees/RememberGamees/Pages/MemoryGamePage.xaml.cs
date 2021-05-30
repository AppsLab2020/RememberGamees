using RememberGamees.PageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemoryGamePage : ContentPage
    {
        private double _number { get; set; }
        private double _RandWidthNumber { get; set; }
        public MemoryGamePage()
        {
            InitializeComponent();
            BindingContext = new MemoryGamePageModel(Navigation);

            GenerateRandNum();
            Image Rand = new Image { WidthRequest = 50, HeightRequest = 50 };
            Rand.SetBinding(Image.SourceProperty, "RandomImage_Source");
            AbsoluteLayout.SetLayoutBounds(Rand, new Rectangle(_RandWidthNumber, _number, 100, 50));
            AbsoluteLayout.SetLayoutFlags(Rand, AbsoluteLayoutFlags.PositionProportional);

            Image Brain1 = new Image { WidthRequest = 50, HeightRequest = 50 };
            Brain1.SetBinding(Image.SourceProperty, "FirstBrainImage_Source");
            AbsoluteLayout.SetLayoutBounds(Brain1, new Rectangle(0.1, 0, 100, 50));
            AbsoluteLayout.SetLayoutFlags(Brain1, AbsoluteLayoutFlags.PositionProportional);

            Image Brain2 = new Image { WidthRequest = 50, HeightRequest = 50 };
            Brain2.SetBinding(Image.SourceProperty, "SecondBrainImage_Source");
            AbsoluteLayout.SetLayoutBounds(Brain2, new Rectangle(0.3, 0, 100, 50));
            AbsoluteLayout.SetLayoutFlags(Brain2, AbsoluteLayoutFlags.PositionProportional);

            Image Brain3 = new Image { WidthRequest = 50, HeightRequest = 50 };
            Brain3.SetBinding(Image.SourceProperty, "ThirdBrainImage_Source");
            AbsoluteLayout.SetLayoutBounds(Brain3, new Rectangle(0.5, 0, 100, 50));
            AbsoluteLayout.SetLayoutFlags(Brain3, AbsoluteLayoutFlags.PositionProportional);

            Image Brain4 = new Image { WidthRequest = 50, HeightRequest = 50 };
            Brain4.SetBinding(Image.SourceProperty, "FourthBrainImage_Source");
            AbsoluteLayout.SetLayoutBounds(Brain4, new Rectangle(0.7, 0, 100, 50));
            AbsoluteLayout.SetLayoutFlags(Brain4, AbsoluteLayoutFlags.PositionProportional);

            Image Brain5 = new Image { WidthRequest = 50, HeightRequest = 50 };
            Brain5.SetBinding(Image.SourceProperty, "FifthBrainImage_Source");
            AbsoluteLayout.SetLayoutBounds(Brain5, new Rectangle(0.9, 0, 100, 50));
            AbsoluteLayout.SetLayoutFlags(Brain5, AbsoluteLayoutFlags.PositionProportional);

            Label Description = new Label { Text = "Is the picture matches with previous?", FontSize = 17 };
            AbsoluteLayout.SetLayoutBounds(Description, new Rectangle(0.5, 0.4, 300, 50));
            AbsoluteLayout.SetLayoutFlags(Description, AbsoluteLayoutFlags.PositionProportional);

            Button Yes_Button = new Button { Text = "Yes", BorderColor = Color.Black, BorderWidth = 2, BackgroundColor = Color.White };
            Yes_Button.Clicked += (sender, args) =>
            {
                _number = rnd.NextDouble() * (0.4 - 0.8) + 1;
                _RandWidthNumber = rnd.NextDouble() * (0.9 - 0.1) + 0.1;
                AbsoluteLayout.SetLayoutBounds(Rand, new Rectangle(_RandWidthNumber, _number, 100, 50));
            };
            Yes_Button.SetBinding(Button.CommandProperty, "Yes_Clicked");
            AbsoluteLayout.SetLayoutBounds(Yes_Button, new Rectangle(0.7, 0.5, 110, 50));
            AbsoluteLayout.SetLayoutFlags(Yes_Button, AbsoluteLayoutFlags.PositionProportional);

            Button No_Button = new Button { Text = "No", BorderColor = Color.Black, BorderWidth = 2, BackgroundColor = Color.White };
            No_Button.Clicked += (sender, args) =>
            {
                _number = rnd.NextDouble() * (0.4 - 0.8) + 1;
                _RandWidthNumber = rnd.NextDouble() * (0.9 - 0.1) + 0.1;
                AbsoluteLayout.SetLayoutBounds(Rand, new Rectangle(_RandWidthNumber, _number, 100, 50));
            };
            No_Button.SetBinding(Button.CommandProperty, "No_Clicked");
            AbsoluteLayout.SetLayoutBounds(No_Button, new Rectangle(0.3, 0.5, 110, 50));
            AbsoluteLayout.SetLayoutFlags(No_Button, AbsoluteLayoutFlags.PositionProportional);

            //Label to write "score:"
            Label label = new Label { FontSize = 23, Text = "Score:", TextColor = Color.FromHex("#2BB0F3"), FontAttributes = FontAttributes.Bold };
            AbsoluteLayout.SetLayoutBounds(label, new Rectangle(0.7, 0.3, 100, 100));
            AbsoluteLayout.SetLayoutFlags(label, AbsoluteLayoutFlags.PositionProportional);

            //Score Label
            Label score = new Label { FontSize = 23 };
            score.SetBinding(Label.TextProperty, "Experiences2_Text");
            AbsoluteLayout.SetLayoutBounds(score, new Rectangle(0.95, 0.3, 100, 100));
            AbsoluteLayout.SetLayoutFlags(score, AbsoluteLayoutFlags.PositionProportional);

            Label timeInfo = new Label { TextColor = Color.FromHex("#2BB0F3"), FontSize = 23, Text = "Time:", FontAttributes = FontAttributes.Bold };
            AbsoluteLayout.SetLayoutBounds(timeInfo, new Rectangle(0.1, 0.3, 100, 100));
            AbsoluteLayout.SetLayoutFlags(timeInfo, AbsoluteLayoutFlags.PositionProportional);

            //Time label 
            Label time = new Label { FontSize = 23, };
            time.SetBinding(Label.TextProperty, "Time_Text");
            AbsoluteLayout.SetLayoutBounds(time, new Rectangle(0.3, 0.3, 100, 100));
            AbsoluteLayout.SetLayoutFlags(time, AbsoluteLayoutFlags.PositionProportional);

            Content = new AbsoluteLayout
            {
                Children = { Rand, Brain1, Brain2, Brain3, Brain4, Brain5, Description, Yes_Button, No_Button, label, score, timeInfo, time }
            };
        }
        Random rnd = new Random();
        private void GenerateRandNum()
        {
            _number = rnd.NextDouble() * (0.4 - 0.8) + 1;
            _RandWidthNumber = rnd.NextDouble() * (0.9 - 0.1) + 0.1;
        }
    }
}