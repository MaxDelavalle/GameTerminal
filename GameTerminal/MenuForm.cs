using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MenuForm : MetroFramework.Forms.MetroForm
    {
        GameForm gameWindow;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void TechnologyCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "COMPUTER", "STORAGE", "INTERNET", "TABLET", "WIFI", "PROGRAMMING", "SOFTWARE", "LAPTOP", "ETHERNET", "WINDOWS", "LINUX", "ANDROID", "HARDWARE", "SOFTWARE", "ROBOTICS", "AMISH", "ENGINEERING", "LASER", "AVIONICS", "BALLISTICS"  };

            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void AnimalCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "SKUNK", "TIGER", "GIRAFFE", "MONKEY", "TURTLE", "CAT", "DOG", "EAGLE", "BEAR", "HORSE", "DUCK", "LAMB", "PIG", "CHICKEN", "COW", "LION", "CROW", "ELEPHANT", "RHINOCEROS", "LEOPARD", "WILDEBEEST", "BUFFALO", "WARTHOG", "CHAMELEON", "FISH", "PENGUIN", "SEAL", "CROCODILE"  };
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void FoodCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "APPLE", "BANANA", "GRAPE","POTATO", "STEAK", "HAMBURGER", "CHEESE", "PIZZA", "PASTA", "FRIES", "AVOCADO", "RICE", "CHIPS", "POUTINE", "TACOS", "TOFU", "FAJITAS", "GYRO", "LASAGNA", "BROWNIE", "CROISSANT", "KEBAB", "LOBSTER"};
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void SportsCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "FOOTBALL", "SOCCER", "HOCKEY", "BASKETBALL", "JETS", "GIANTS", "PATRIOTS", "GOAL", "BASEBALL", "YANKEES", "METS", "REDSOX", "BARCELONA", "JUVENTUS", "PANTHERS", "STEELERS", "EAGLES", "RUGBY", "COWBOYS", "LAKERS", "ROCKETS", "WARRIORS", "CELTICS", "CAVELIERS", "KNICKS", "NETS" };
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void PoliticsCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "DEMOCRAT", "REPUBLICAN", "INDEPENDENT", "LIBERTARIAN", "OBAMA", "CLINTON", "BUSH", "REAGAN", "VOTE", "CONSERVATIVE", "LIBERAL", "CAMPAIGN", "BUSH", "KENNEDY", "LINCOLN", "PRESIDENT", "TRUMP", "BERNIE", "NIXON", "JACKSON", "DELEGATE", "FILIBUSTER", "LOBBY", "MUCKRAKER", "NOMINEE" };
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void CountriesCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "CANADA", "UGANDA", "IRAQ", "INDIA", "CHINA", "JAPAN", "RUSSIA", "GERMANY", "KOREA", "USA", "INDONESIA", "AUSTRALIA", "CHILE", "ZIMBABWE", "FRANCE", "BRAZIL", "ITALY", "SPAIN", "MEXICO", "TURKEY", "SWEDEN", "NIGERIA", "BELGIUM", "ARGENTINA"};
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
