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
        public static int level;
        public MainWindow()
        {
            InitializeComponent();
            //comment
            level = 0;
            NoMonster();
        }

        public void NoMonster()
        {
            Monster enemy = new Monster();
            enemy.strMonType = "Montype: " + "geen";
            enemy.intMonHP = 0;
            enemy.intMonAttack = 0;
        }

        private void dungeon_Click(object sender, RoutedEventArgs e)
        {
            Monster enemy = new Monster();

            MonType.Content = "Type: " + enemy.strMonType;
            MonHP.Content = "HP: " + enemy.intMonHP;
            MonAttack.Content = "Attack: " + enemy.intMonAttack;
        }
    }
    public class Monster
    {
        public string strMonType;
        public int intMonHP;
        public int intMonAttack;
        public Monster()
        {
            //later wil ik meer monsters die ik vanuit hier met een random nummer aan kan spreken
            //RanMon * floor level zo krijg ik voor elke floor level een x aantal monsters.
            Random RanMon = new Random();
            //voor elke depth 10 monsters alleen voor depth 0 ratten.
            int MonIndx = MainWindow.level * RanMon.Next(1, 11); //creates a number between 1 and 10.
            Monsterindex(MonIndx);
        }
        public void Monsterindex(int MonIndx)
        {
            switch(MonIndx)
            {
                case 0:
                    Rat();
                    break;
            }
        }
        public void Rat()
        {
            this.strMonType = "Rat";
            this.intMonHP = 10;
            this.intMonAttack = 2;
        }
    }
}
