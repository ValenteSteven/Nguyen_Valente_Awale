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
using System.Windows.Shapes;

namespace Awale
{
    /// <summary>
    /// Logique d'interaction pour NameWindow.xaml
    /// </summary>
    public partial class NameWindow : Window
    {
        String namePlayer;
        public NameWindow()
        {
            namePlayer = "bosgsg";
            this.DataContext = this;
            this.DataContext = namePlayer;
            
            InitializeComponent();
        }

        public string NamePlayer { get => namePlayer; set => namePlayer = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IFormatter formatterSave = new BinaryFormatter();
            Stream streamSave = new FileStream("namePlayer",
                 FileMode.Create,
                 FileAccess.Write,
                 FileShare.None);
            formatterSave.Serialize(streamSave, namePlayer);
            streamSave.Close();

            MainWindow mainMenu = new MainWindow();
            this.Close();
            mainMenu.Show();
        }
    }
}
