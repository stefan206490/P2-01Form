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
        //settings
        public static bool att;
        //dungeon
        public static int level;
        //fight
        public static int hit;
        public MainWindow()
        {
            InitializeComponent();
            //comment
            level = 0;
            DungeonLvl.Content = level;
            NoMonster();
            NewPlayer();
        }

        public void NewPlayer()
        {
            //er komt een error omdat hier nog niets staat.
            Player speler = new Player();
            ShowPLA(speler.PLAType, speler.HP, speler.PLAttack);
        }

        public void ShowPLA(string playertypeVar, int playerHPVar, int playerattackVar)
        {
            playertype.Content = playertypeVar;
            playeratt.Content = playerattackVar;
            playerHP.Content = playerHPVar;
        }

        public void NoMonster()
        {
            Monster enemy = new Monster();
            enemy.strMonType = "geen";
            enemy.intMonHP = 0;
            enemy.intMonAttack = 0;
            att = false;
            ShowMon(enemy.strMonType, enemy.intMonHP, enemy.intMonAttack);
        }

        public void ShowMon(string strMonType, int intMonHP, int intMonAttack)
        {
            MonType.Content = strMonType;
            MonHP.Content = intMonHP;
            MonAttack.Content = intMonAttack;
        }

        private void dungeon_Click(object sender, RoutedEventArgs e)
        {
            Monster enemy = new Monster();

            ShowMon(enemy.strMonType, enemy.intMonHP, enemy.intMonAttack);
        }

        private void attack_Click(object sender, RoutedEventArgs e)
        {
            if (att)
            {
                //de hero heeft een attack van 5
                Random RanAtt = new Random();
                hit = RanAtt.Next(Convert.ToInt32(playeratt.Content) + 1);
                MonHP.Content = Convert.ToInt32(MonHP.Content) - hit;
                CheckDead();
                MonsterAttack();
            }
            else
            {
                MessageBox.Show("What do you want to attack??", "stupido");
            }
        }

        public void MonsterAttack()
        {
            //hier verder gaan
        }

        public void CheckDead()
        {
            if (Convert.ToInt32(MonHP.Content) <= 0)
            {
                NoMonster();
                MessageBox.Show("You killed the Monster", "Congrats");
            }
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
            MainWindow.att = true;
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

    public class Player
    {
        public int HP;
        public int PLAttack;
        public string PLAType;
        public Player()
        {
            this.PLAType = "Warrior";
            this.PLAttack = 5;
            this.HP = 100;
        }
    }
}
