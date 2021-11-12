using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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

namespace RegistroJugadores
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Data d;
        public MainWindow()
        {
            InitializeComponent();
            d = new Data("LAPTOP-PC8SL5H1", "registroJugadores");
            this.WindowStyle = WindowStyle.None;
            foreach(Jugador j in d.GetJugadores())
            {
                Debug.WriteLine(j.Nombre);
            }
        }
    }
}
