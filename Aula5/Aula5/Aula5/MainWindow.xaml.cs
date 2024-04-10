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

namespace Aula5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Figura> _lista = new List<Figura>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemAdicionar_Click(object sender, RoutedEventArgs e)
        {
            Janela _janela = new Janela();

            if(_janela.ShowDialog() == true)
            {
                //_lista.Add(_janela.FiguraNova);
                //lbFiguras.Items.Add(_janela.FiguraNova.Nome);
            }

        }
    }
}