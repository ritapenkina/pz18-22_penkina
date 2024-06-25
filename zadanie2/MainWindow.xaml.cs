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

namespace pz2_penkina
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
        public interface Professions//профессии
        {
            string speciality { get; set; }//специальность
            string job { get; set; }//работа
        }
        public interface doctor//доктор
        {
            int experience { get; set; }//опыт
            int knowledge { get; set; }//знания

        }
        public interface soldier//солдат
        {
            bool helping { get; set; }//помощь
            int pension { get; set; }//пенсия
        }
        public interface police//полиция
        {
            bool rank { get; set; }//звание
            int resignation { get; set; }//отставка
        }
        public interface firefighter//пожарный
        {
            bool away { get; set; }//выездной

        }
        public interface entrepreneur//предприниматель
        {
            bool significant { get; set; }//значимость
        }
        public interface collector//коллектор
        {
            bool urban { get; set; }//городской
        }
    }
}
