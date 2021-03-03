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
    public partial class ReactionGamePage01 : ContentPage
    {
        List<string> images = new List<string> { "Image1", "Image2", "Image3", "Image4", "Image5", "Image6", "Image7", "Image8", "Image8", "Image9", "Image10" };

        public ReactionGamePage01()
        {

            InitializeComponent();
            //BindingContext = new ReactionGamePageModel01();
        }
        private void thirdBtn_Clicked(object sender, EventArgs e)
        {
            var rand = new Random();
            var next = rand.Next(10);
            var image = images[next];

            RandomImg.Source = ImageSource.FromFile(image);
        }
    }
}