using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Expanses_analyzator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //JObject o1 = JObject.Parse(File.ReadAllText(@"C:\Users\bguzd\source\repos\Expanses analyzator\test.json"));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText(@"C:\Users\bguzd\source\repos\Expanses analyzator\test.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JToken o2 = JToken.ReadFrom(reader);
                var usersArray = o2.ToObject<RootObject[]>();
                int i = 0;
            }
        }
    }
}
