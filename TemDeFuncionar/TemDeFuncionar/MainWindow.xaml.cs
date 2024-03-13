using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TemDeFuncionar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        string Antigo = " ";
        string Current = " ";
        string OP = " ";
        string simbolo = " ";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            Antigo = " ";
            Current = " ";
            OP = " ";
            LabelResulado.Content = Antigo;
            LabelAntigo.Content = Current;


        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch(name) {
                case "Btn0":
                    Antigo += "0";
                    break;

                case "Btn1":
                    Antigo += "1";
                    break;

                case "Btn2":
                    Antigo += "2";
                    break;

                case "Btn3":
                    Antigo += "3";
                    break;

                case "Btn4":
                    Antigo += "4";
                    break;

                case "Btn5":
                    Antigo += "5";
                    break;

                case "Btn6":
                    Antigo += "6";
                    break;

                case "Btn7":
                    Antigo += "7";
                    break;

                case "Btn8":
                    Antigo += "8";
                    break;

                case "Btn9":
                    Antigo += "9";
                    break;

            }

            LabelResulado.Content = Antigo;
        }

        private void BtnApagar_Click(object sender, RoutedEventArgs e)
        {
            Antigo = Antigo.Remove(Antigo.Length - 1);
            LabelResulado.Content = Antigo;
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            LabelAntigo.Content = Current + " " + simbolo + Antigo;
            switch (OP)
            {
                case "MUL":
                    Antigo = (float.Parse(Current) * float.Parse(Antigo)).ToString(); 
                    break;

                case "DIV":
                    Antigo = (float.Parse(Current) / float.Parse(Antigo)).ToString();
                    break;


                case "PLUS":
                    Antigo = (float.Parse(Current) + float.Parse(Antigo)).ToString();
                    break;


                case "MIN":
                    Antigo = (float.Parse(Current) - float.Parse(Antigo)).ToString();
                    break;


            }
            LabelResulado.Content = Antigo;

            Current = " ";
            OP = " ";
            
        }

        private void BtnOP_Click(object sender, RoutedEventArgs e)
        {
            

            string name = ((Button)sender).Name;
            switch(name) {

                case "BtnDiv":
                    OP = "DIV";
                    simbolo = "/";
                    
                    break;

                case "BtnMul":
                    OP = "MUL";
                    simbolo = "x";
                    break;

                case "BtnPlus":
                    OP = "PLUS";
                    simbolo = "+";
                    break;

                case "BtnMin":
                    OP = "MIN";
                    simbolo = "-";
                    break;
                

            }
            Current = Antigo;
            Antigo = " ";
            LabelResulado.Content = Antigo;
            LabelAntigo.Content = Current + " " + simbolo ;

        }
    }
}