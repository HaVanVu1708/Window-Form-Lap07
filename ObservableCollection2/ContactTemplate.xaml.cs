﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ObservableCollection2
{
    public sealed partial class ContactTemplate : UserControl
    {
        public Models.Contact Contact { get{ return this.DataContext as Models.Contact; } }

        public ContactTemplate()
        {
            this.InitializeComponent();

            this.DataContextChanged += (s, e) => Bindings.Update();
        }
    }
}
