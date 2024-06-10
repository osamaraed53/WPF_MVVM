using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace MVVMProject.Views
{
    /// <summary>
    /// Interaction logic for MakeReservationView.xaml
    /// </summary>
    public partial class MakeReservationView : UserControl 
    {
        public MakeReservationView()
        {
            InitializeComponent();
            DataContext = this;
        }

        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set { myVar = value;
                           }
        }

    }
}
