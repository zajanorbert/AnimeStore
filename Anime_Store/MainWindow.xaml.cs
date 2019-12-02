﻿using System;
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

namespace Anime_Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();            
            sendAutoText();
            Autotxt.TextChanged += Search.Autotxt_TextChanged;
            lbSuggestion.SelectionChanged += Search.lbSuggestion_SelectionChanged;
        }

        /// <summary>
        /// Sends the text information for the Search class.
        /// </summary>
        private void sendAutoText()
        {
            Search.getAutoText(Autotxt, lbSuggestion);
        }


    }
}
