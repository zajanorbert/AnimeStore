using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Anime_Store 
{
    class Search
    {
        private static TextBox Autotxt;
        static ListBox lbSuggestion;
        static List<string> titleList = new List<string>
            {
                "a", "b", "c", "d", "eee", "elem", "cucc", "valami"
            };

        public static void lbSuggestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbSuggestion.ItemsSource != null)
            {
                lbSuggestion.Visibility = Visibility.Collapsed;
                Autotxt.TextChanged -= new TextChangedEventHandler(Autotxt_TextChanged);

                if (lbSuggestion.SelectedIndex != -1)
                {
                    Autotxt.Text = lbSuggestion.SelectedItem.ToString();
                }
                Autotxt.TextChanged += new TextChangedEventHandler(Autotxt_TextChanged);
            }
        }

        /// <summary>
        /// Auto completion Search box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void  Autotxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedString = Autotxt.Text;
            List<string> autoList = new List<string>();
            autoList.Clear();

            foreach (string item in titleList)
            {
                if (!string.IsNullOrEmpty(Autotxt.Text))
                {
                    if (item.StartsWith(typedString))
                    {
                        autoList.Add(item);
                    }
                }
            }
            if (autoList.Count > 0)
            {
                lbSuggestion.ItemsSource = autoList;
                lbSuggestion.Visibility = Visibility.Visible;
            }
            else if (Autotxt.Text.Equals(""))
            {
                lbSuggestion.Visibility = Visibility.Collapsed;
                lbSuggestion.ItemsSource = null;
            }
            else
            {
                lbSuggestion.Visibility = Visibility.Collapsed;
                lbSuggestion.ItemsSource = null;
            }
        }

        /// <summary>
        /// Receives the TextBox & ListBox from the Main form.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="lbs"></param>
        public static void getAutoText(TextBox text, ListBox lbs)
        {
            Autotxt = text;
            lbSuggestion = lbs;
        }
    }
}
