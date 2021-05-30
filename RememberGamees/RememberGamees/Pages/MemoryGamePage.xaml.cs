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
        private readonly List<DateTime> tapTimes;
        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4" };
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

            Content = new AbsoluteLayout
            {
                Children = { Rand, }
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