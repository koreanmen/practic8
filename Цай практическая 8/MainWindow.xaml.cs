﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Цай_практическая_8;

namespace Цай_практическая_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Father father;
        Kid kid;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Показывает окно с информацией об условии задания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Цай Владислав, Практическая 8, Вариант 11 \nСоздать интерфейс - человек, у которого есть имя, функция печати. Создать класс отец, у которого функция печати выводит имя." +
                "\nСоздать класс ребенок, у которого есть отец, отчество, функция печати выводит имя и отчество." +
                "\nКлассы должны включать конструкторы. Сравнение производить по фамилии.", "О программе",MessageBoxButton.OK);
        }
        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Вывод информации о ребенке и об отце в listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miOutputInformation_Click(object sender, RoutedEventArgs e)
        {
            if (father != null)
            {
                listFather.Items.Add(father.Print());
                listFather.Items.Add(father.Family);
            }
            else
            {
                MessageBox.Show("Создайте отца", "Ошибка", MessageBoxButton.OK);
            }
            if (kid != null)
            {
                listKid.Items.Add(kid.Print());
                listKid.Items.Add(kid.Family);
            }
            else
            {
                MessageBox.Show("Создайте ребенка", "Ошибка", MessageBoxButton.OK);
            }
        }
        /// <summary>
        /// Проверка на одинаковые фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miCheckLastnames_Click(object sender, RoutedEventArgs e)
        {
            if (father != null && kid != null)
            {
                if (kid.CompareTo(father) == 0)
                {
                    MessageBox.Show("Фамилии одинаковые");
                }
                else MessageBox.Show("Фамилии разные");
            }
        }
        /// <summary>
        /// Очищение listBox'ов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miClear_Click(object sender, RoutedEventArgs e)
        {
            listKid.Items.Clear();
            listFather.Items.Clear();
        }
        /// <summary>
        /// Создание ребенка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreateKid_Click(object sender, RoutedEventArgs e)
        {
            if (tbNameKid.Text != "" && tbMiddlenameKid.Text != "" && tbFamilyKid.Text != "")
                kid = new Kid(tbNameKid.Text, tbMiddlenameKid.Text, tbFamilyKid.Text);
            else MessageBox.Show("Введите все данные о ребёнке", "Ошибка", MessageBoxButton.OK);
        }
        /// <summary>
        /// Создание отца
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreateFather_Click(object sender, RoutedEventArgs e)
        {
            if (tbNameFather.Text != "" && tbFamilyFather.Text != "")
                father = new Father(tbNameFather.Text, tbFamilyFather.Text);
            else MessageBox.Show("Введите все данные об отце", "Ошибка", MessageBoxButton.OK);
        }
    }
}