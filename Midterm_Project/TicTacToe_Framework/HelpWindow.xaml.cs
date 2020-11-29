using System;
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
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Net.Http;

namespace TicTacToe_Framework
{
    /// <summary>
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        public void DisplayRules()
        {
            using (var client = new HttpClient())
            {
                string rulesURL = @"http://pcbstuou.w27.wh-2.com/webservices/3033/api/TicTacToe";

                string jsonResults = client.GetStringAsync(rulesURL).Result;

                RulesAPI rules = JsonConvert.DeserializeObject<RulesAPI>(jsonResults);


                lblRulesTitle.Content = rules.title;
                txtblkRules.Text = $"1. {rules.rule1}\n\n2. {rules.rule2}\n\n3. {rules.rule3}\n\n4. {rules.rule4}";

                Uri uri = new Uri(rules.graphic);
                BitmapImage picture = new BitmapImage(uri);
                imgRules.Source = picture;
            }
        }
    }
}
