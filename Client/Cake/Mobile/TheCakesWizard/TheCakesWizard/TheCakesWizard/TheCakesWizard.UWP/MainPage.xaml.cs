﻿using System;
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
using Windows.UI.Xaml.Navigation;
using Syncfusion.SfBusyIndicator.XForms.UWP;

namespace TheCakesWizard.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            new SfBusyIndicatorRenderer();
            this.InitializeComponent();

            LoadApplication(new TheCakesWizard.App());
        }
    }
}
