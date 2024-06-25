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

namespace pz1_penkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public class Professions//профессии
        {
            public string speciality { get; set; }//специальность
            public string job { get; set; }//работа
        }
        public class doctor : Professions//доктор
        {
            public int experience { get; set; }//опыт
            public int knowledge { get; set; }//знания

        }
        public class soldier : doctor//солдат
        {
            public bool helping = true;//помощь
            int pension = 35;//пенсия
        }
        public class police : doctor//полиция
        {
            public bool rank = true;//звание
            int resignation = 35;//отставка
        }
        public class firefighter : Professions//пожарный
        {
            public bool away = true;//выездной

        }
        public class entrepreneur : firefighter//предприниматель
        {
            public bool significant = true;//значимость
        }
        public class collector : firefighter//коллектор
        {
            public bool urban = true;//городской
        }
    }
}
