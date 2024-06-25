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

namespace pz4_penkina
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
            string helping { get; set; }//помощь
            int pension { get; set; }//пенсия
        }
        public interface police//полиция
        {
            string rank { get; set; }//звание
            int resignation { get; set; }//отставка
        }
        public interface firefighter//пожарный
        {
            bool away { get; set; }//выездной

        }
        public interface entrepreneur//предприниматель
        {
            string significant { get; set; }//значимость
        }
        public interface collector//коллектор
        {
            bool urban { get; set; }//городской
        }
        public class People : Professions, doctor, soldier
        {
            public string speciality { get; set; }
            public string job { get; set; }
            public int experience { get; set; }
            public int pension { get; set; }
            public int knowledge { get; set; }
            public string helping { get; set; }
            public override string ToString()
            {
                return $"Человек: {speciality}, рабочее состояние: {job}, опыт: {experience}, пенсия: {pension}";
            }
        }
        public class Param
        {
            public string helping { get; set; }
            public string rank { get; set; }
            public int resignation { get; set; }
            public bool away { get; set; }
            public string significant { get; set; }
            public bool urban { get; set; }
        }
        private void ShowPeople(object sender, RoutedEventArgs e)
        {
            People people = new People()
            {
                speciality = "Доктор",
                job = "Работает",
                experience = 5,
                pension = 45

            };
            MessageBox.Show($"Человек: {people.job}, Специальность: {people.speciality}, Опыт работы: {people.experience}, Пенсия: {people.pension}");
        }
        private void ShowParametrs(object sender, RoutedEventArgs e)
        {
            Param param = new Param()
            {
                helping = "Награждён",
                rank = "Майор",
                resignation = 55,
                away = true,
                significant = "Высокая",
                urban = true,
            };
            MessageBox.Show($"Данные: {param.helping}, Ранг: {param.rank}, Отставка: {param.resignation}, Выездной: {param.away}, Значимость: {param.significant}, Городской: {param.urban}");
        }
    }
}
    

