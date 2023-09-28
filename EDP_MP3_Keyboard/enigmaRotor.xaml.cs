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
using System.Windows.Shapes;

namespace EDP_MP3_Keyboard
{
    /// <summary>
    /// Interaction logic for Class1.xaml
    /// </summary>
    public partial class Class1 : Window
    {
        private string control = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string rotor_1 = "DMTWSILRUYQNKFEJCAZBPGXOHV";
        private string rotor_2 = "HQZGPJTMOBLNCIFDYAWVEUSRKX";
        private string rotor_3 = "UQNTLSZFMREHDPXKIBVYGJCWOA";
        private char userInput = ' ';
        
        
        public Class1()
        {
            InitializeComponent();
        }
    }
}
