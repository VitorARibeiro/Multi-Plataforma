using Microsoft.Win32;
using System.Windows;

namespace FilePicker
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = ("Pls Pick a file"); //aparece no titulo do picker
            ofd.Filter = "Text Files | *.txt"; //so aparece .txt
            bool? success = ofd.ShowDialog(); // para abrir o file picker


            if (success == true)
            {
                string path = ofd.FileName;
                string fileName = ofd.SafeFileName;

                TxtInfo.Text = path;
            }
            else
            {

                //nao abriu nada
            }


        }
    }
}