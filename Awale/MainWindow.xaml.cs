using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace Awale
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //String namePlayer;


        public MainWindow()
        {
            if (new FileInfo("namePlayer").Exists)
            {
                IFormatter formatterLoad = new BinaryFormatter();
                Stream streamLoad = new FileStream("namePlayer",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read);

                if (new FileInfo("namePlayer").Length > 0)
                {
                    String personneLoad = (String)formatterLoad.Deserialize(streamLoad);
                    streamLoad.Close();
                    
                }

            }


            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameWindow name = new NameWindow();
            this.Close();
            name.Show();
        }

        private void Launch_Local_Game(object sender, RoutedEventArgs e)
        {
            GameConsole gC = new GameConsole();
            this.Close();
            gC.Show();
        }
    }
}
