﻿using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RememberGamees
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellApp : Shell
    {
        public ShellApp()
        {
            InitializeComponent();
        }
    }
}