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
            //comment
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Monster enemy = new Monster();
            enemy.strMonType = "Rat";
            enemy.intMonHP = 10;
            enemy.intMonAttack = 2;
        }
    }
    public class Monster
    {
        public string strMonType;
        public int intMonHP;
        public int intMonAttack;
    }
}
