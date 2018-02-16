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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Awale.UC
{
    /// <summary>
    /// Logique d'interaction pour CaseUC.xaml
    /// </summary>
    public partial class CaseUC : UserControl
    {
        private int nbGraines;
        private int position;

        public int NbGraines { get => nbGraines; set => nbGraines = value; }
        public int Position { get => position; set => position = value; }

        public CaseUC(int nbGraines, int position)
        {

            InitializeComponent();
            this.NbGraines = nbGraines;
            this.Position = position;
        }
    }
}
