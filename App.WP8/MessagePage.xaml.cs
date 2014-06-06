using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using App.WP8.Tool;
using App.WP8.ViewModels;

namespace App.WP8
{
    public partial class MessagePage : PhoneApplicationPage
    {
        public MessagePage()
        {
            InitializeComponent();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.DataContext = new MessageViewModel();
        }
    }
}