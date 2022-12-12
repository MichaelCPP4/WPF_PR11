using System.Text.RegularExpressions;
using System.Windows;

namespace WPF_PR10
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

        void Stroka1(string s)
        {
            Regex regex = new Regex(@"ahb|acb|aeb");
            s = textBoxDano.Text;
            Match match = regex.Match(s);
            MatchCollection mathes = regex.Matches(s);

            object[] mas = new object[mathes.Count];
            mathes.CopyTo(mas, 0);
            textBoxResult.Text = mas[0].ToString() + " " + mas[1].ToString() + " " + mas[2].ToString();
        }

        void Stroka2(string s)
        {
            Regex regex = new Regex(@"a\d*a");
            s = "aa a1a a22a a333a a4444a a55555a aba aca";
            Match match = regex.Match(s);
            MatchCollection mathes = regex.Matches(s);

            object[] mas = new object[mathes.Count];
            mathes.CopyTo(mas, 0);
            textBoxResult2.Text = mas[0].ToString() + " " + mas[1].ToString() + " " + mas[2].ToString() + " " + mas[3].ToString() + " " + mas[4].ToString() + " " + mas[5].ToString();
        }

        private void ButtonToFind_Click(object sender, RoutedEventArgs e)
        {
            const string S = "ahb acb aeb aeeb adcb axeb";
            Stroka1(S);
        }

        private void ButtonToFind2_Click(object sender, RoutedEventArgs e)
        {
            const string S = "aa a1a a22a a333a a4444a a55555a aba aca";
            Stroka2(S);
        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Задание 1:\nДана строка 'ahb acb aeb aeeb adcb axeb'. Напишите регулярное выражение, которое\n найдет строки ahb, acb, aeb.\nЗадание 2:\nДана строка 'aa a1a a22a a333a a4444a a55555a aba aca'\n.Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a',\nа между ними любое количество цифр(в том числе и ноль цифр, то есть строка 'aa').\nВыполнил: Иванов Михаил ИСП-31");
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
