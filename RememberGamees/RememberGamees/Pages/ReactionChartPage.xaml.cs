﻿using RememberGamees.PageModel;
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
    public partial class ReactionChartPage : ContentPage
    {
        public ReactionChartPage()
        {
            InitializeComponent();
            BindingContext = new ReactionChartPageModel();
        }
        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    //await (BindingContext as ReactionChartPageModel).GetScoreOfReactionAsync();
        //}
    }
}