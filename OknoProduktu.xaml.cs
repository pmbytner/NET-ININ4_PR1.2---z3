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
using System.Xml;

namespace NET_ININ4_PR1._2___z3
{
    /// <summary>
    /// Logika interakcji dla klasy OknoProduktu.xaml
    /// </summary>
    public partial class OknoProduktu : Window
    {
        public OknoProduktu(XmlNode produkt)
        {
            DataContext = produkt;
            InitializeComponent();
        }
    }
}
