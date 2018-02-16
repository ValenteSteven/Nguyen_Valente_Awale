using Awale.UC;
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

namespace Awale
{
    /// <summary>
    /// Logique d'interaction pour GameConsole.xaml
    /// </summary>
    public partial class GameConsole : Window
    {/*
        Case case1Player1;
        Case case2Player1;
        Case case3Player1;
        Case case4Player1;
        Case case5Player1;
        Case case6Player1;

        Case case1Player2;
        Case case2Player2;
        Case case3Player2;
        Case case4Player2;
        Case case5Player2;
        Case case6Player2;*/

        private String toto;
        private CaseUC caseUC;
        private int nbGraines;

        public GameConsole()

        {

            InitializeComponent();
            this.DataContext = this;
            toto =  "/Images/awale.png";
            CaseUC = new CaseUC(4, 2);
            this.test.Content = CaseUC;
        }

        public string Toto { get => toto; set => toto = value; }
        public CaseUC CaseUC { get => caseUC; set => caseUC = value; }
        public int NbGraines { get => nbGraines; set => nbGraines = value; }

        private void Button_ClickTest(object sender, RoutedEventArgs e)
        {
            String s = testEnabled.Margin.ToString();
            testEnabled.IsEnabled = false;
        }
    }
}
