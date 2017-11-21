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

namespace MyFirstApp
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

        private void AirRune_Click(object sender, RoutedEventArgs e)
        {
            //als ik op deze knop klik koop ik een airrune crate.
            ListViewItem li = new ListViewItem();
            li.Content = "je koopt: 1 X airrune crate";
            lvwMylistvieuw.Items.Add(li);
        }

        private void FoodCrate_Click(object sender, RoutedEventArgs e)
        {
            //als ik op deze knop klik koop ik een food crate.
            ListViewItem li = new ListViewItem();
            li.Content = "je koopt: 1 X Food crate";
            lvwMylistvieuw.Items.Add(li);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //als ik op deze knop klik clear ik de lijst
            lvwMylistvieuw.Items.Clear();
        }
    }
}
