using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace ZadanieTKExam
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        public int CheckMarks(string FirstMark, string SecondMark, string ThirdMark)
        {

            int intFirstMark, intSecondMark, intThirdMark;

            if (!int.TryParse(FirstMark, out intFirstMark) || !int.TryParse(SecondMark, out intSecondMark) || !int.TryParse(ThirdMark, out intThirdMark))
            {

                MessageBox.Show("Ошибка ввода оценок!");
                return -1;
            }
            if (intFirstMark < 0 || intFirstMark > 22 || intSecondMark < 0 || intSecondMark > 38 || intThirdMark < 0 || intThirdMark > 20)
            {
                MessageBox.Show("Выход за границы баллов.");
                return -1;
            }
            int SumMark = intFirstMark + intSecondMark + intThirdMark;
            if (SumMark > +56)
            {
                return 5;
            }
            else if (SumMark > 32)
            {
                return 4;
            }
            else if (SumMark > 16)
            {
                return 3;

            }
            else if (SumMark >= 0 || SumMark <= 16)
            {
                return 2;
            }
            else { return -1; }



        }
        private void Execute_Click(object sender, RoutedEventArgs e)
        {
            Mark.Content = $"Оценка: {CheckMarks(FirstMark.Text, SecondMark.Text, ThirdMark.Text)}";

        }
    }
}
