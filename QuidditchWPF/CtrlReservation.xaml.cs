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

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour CtrlReservation.xaml
    /// </summary>
    public partial class CtrlReservation : UserControl
    {
        public CtrlReservation()
        {
            InitializeComponent();
        }

        public event EventHandler CoupesChanged;

        private void comboCoupes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.CoupesChanged != null)
                this.CoupesChanged(new object(), new EventArgs());
        }
    }
}
