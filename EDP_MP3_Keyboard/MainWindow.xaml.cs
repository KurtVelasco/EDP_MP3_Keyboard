using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace EDP_MP3_Keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<char> numbers = new List<char>() {'1', '2', '3', '4', '5', '6', '7', '8', '9','0'};
        private List<char> shift_numbers = new List<char>() { '!', '@', '#', '$', '_', '^', '&', '*', '(', ')', };
        private List<char> lowerLetters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private List<char> upperLetters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
    'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private List<char> unshift_symbols = new List<char>() { '-', '=', '[', ']', '\\', ';', '\'', ',', '.', '/' };
        private List<char> shift_symbols = new List<char>() { '_', '+', '{', '}', '|', ':', '"', '<', '>', '?' };
        private List<string> commandButtons = new List<string>() {"Tab", "Shift","Return","Back","Shift Lock","Space bar"};
        private string currentSentence = "";
        private Rectangle[] rectanglesArray = new Rectangle[52];
        private Label[] labelArray = new Label[52];
        private bool shiftLock = false;
        private bool shiftDown = false;
        private int nextRow = 0;
        private double nextColumn = 0;

        Rectangle rectangle_1 = new Rectangle();
        Rectangle rectangle_2 = new Rectangle();
        Rectangle rectangle_3 = new Rectangle();
        Rectangle rectangle_4 = new Rectangle();
        Rectangle rectangle_5 = new Rectangle();
        Rectangle rectangle_6 = new Rectangle();
        Rectangle rectangle_7 = new Rectangle();
        Rectangle rectangle_8 = new Rectangle();
        Rectangle rectangle_9 = new Rectangle();
        Rectangle rectangle_0 = new Rectangle();
        Rectangle rectangle_dash = new Rectangle();
        Rectangle rectangle_equals = new Rectangle();
        Rectangle rectangle_return = new Rectangle();
        Rectangle rectangle_q = new Rectangle();
        Rectangle rectangle_w = new Rectangle();
        Rectangle rectangle_e = new Rectangle();
        Rectangle rectangle_r = new Rectangle();
        Rectangle rectangle_t = new Rectangle();
        Rectangle rectangle_y = new Rectangle();
        Rectangle rectangle_u = new Rectangle();
        Rectangle rectangle_i = new Rectangle();
        Rectangle rectangle_o = new Rectangle();
        Rectangle rectangle_p = new Rectangle();
        Rectangle rectangle_openBracket = new Rectangle();
        Rectangle rectangle_closeBracket = new Rectangle();
        Rectangle rectangle_backLash = new Rectangle();
        Rectangle rectangle_back = new Rectangle();
        Rectangle rectangle_tab = new Rectangle();
        Rectangle rectangle_a = new Rectangle();
        Rectangle rectangle_s = new Rectangle();
        Rectangle rectangle_d = new Rectangle();
        Rectangle rectangle_f = new Rectangle();
        Rectangle rectangle_g = new Rectangle();
        Rectangle rectangle_h = new Rectangle();
        Rectangle rectangle_j = new Rectangle();
        Rectangle rectangle_k = new Rectangle();
        Rectangle rectangle_l = new Rectangle();
        Rectangle rectangle_semiColon = new Rectangle();
        Rectangle rectangle_apostrophe = new Rectangle();
        Rectangle rectangle_shiftlock = new Rectangle();
        Rectangle rectangle_shift = new Rectangle();
        Rectangle rectangle_z = new Rectangle();
        Rectangle rectangle_x = new Rectangle();
        Rectangle rectangle_c = new Rectangle();
        Rectangle rectangle_v = new Rectangle();
        Rectangle rectangle_b = new Rectangle();
        Rectangle rectangle_n = new Rectangle();
        Rectangle rectangle_m = new Rectangle();
        Rectangle rectangle_comma = new Rectangle();
        Rectangle rectangle_period = new Rectangle();
        Rectangle rectangle_slash = new Rectangle();
        Rectangle rectangle_spaceBar = new Rectangle();

        Label label_1 = new Label();
        Label label_2 = new Label();
        Label label_3 = new Label();
        Label label_4 = new Label();
        Label label_5 = new Label();
        Label label_6 = new Label();
        Label label_7 = new Label();
        Label label_8 = new Label();
        Label label_9 = new Label();
        Label label_0 = new Label();
        Label label_dash = new Label();
        Label label_equals = new Label();
        Label label_return = new Label();
        Label label_q = new Label();
        Label label_w = new Label();
        Label label_e = new Label();
        Label label_r = new Label();
        Label label_t = new Label();
        Label label_y = new Label();
        Label label_u = new Label();
        Label label_i = new Label();
        Label label_o = new Label();
        Label label_p = new Label();
        Label label_openBracket = new Label();
        Label label_closeBracket = new Label();
        Label label_backLash = new Label();
        Label label_back = new Label();
        Label label_tab = new Label();
        Label label_a = new Label();
        Label label_s = new Label();
        Label label_d = new Label();
        Label label_f = new Label();
        Label label_g = new Label();
        Label label_h = new Label();
        Label label_j = new Label();
        Label label_k = new Label();
        Label label_l = new Label();
        Label label_semiColon = new Label();
        Label label_apostrophe = new Label();
        Label label_shiftlock = new Label();
        Label label_shift = new Label();
        Label label_z = new Label();
        Label label_x = new Label();
        Label label_c = new Label();
        Label label_v = new Label();
        Label label_b = new Label();
        Label label_n = new Label();
        Label label_m = new Label();
        Label label_comma = new Label();
        Label label_period = new Label();
        Label label_slash = new Label();
        Label label_spaceBar = new Label();
        public MainWindow()
        {

            InitializeComponent();
            addtoArray();
            WriteRectangle1();

        }

        private void addtoArray()
        {
            rectanglesArray[36] = rectangle_dash;
            rectanglesArray[37] = rectangle_equals;
            rectanglesArray[38] = rectangle_return;
            rectanglesArray[39] = rectangle_openBracket;
            rectanglesArray[40] = rectangle_closeBracket;
            rectanglesArray[41] = rectangle_backLash;
            rectanglesArray[42] = rectangle_semiColon;
            rectanglesArray[43] = rectangle_apostrophe;
            rectanglesArray[44] = rectangle_shiftlock;
            rectanglesArray[45] = rectangle_shift;
            rectanglesArray[46] = rectangle_comma;
            rectanglesArray[47] = rectangle_period;
            rectanglesArray[48] = rectangle_slash;
            rectanglesArray[49] = rectangle_spaceBar;
            rectanglesArray[50] = rectangle_back;
            rectanglesArray[51] = rectangle_tab;
            /////////////////////
            rectanglesArray[0] = rectangle_1;
            rectanglesArray[1] = rectangle_2;
            rectanglesArray[2] = rectangle_3;
            rectanglesArray[3] = rectangle_4;
            rectanglesArray[4] = rectangle_5;
            rectanglesArray[5] = rectangle_6;
            rectanglesArray[6] = rectangle_7;
            rectanglesArray[7] = rectangle_8;
            rectanglesArray[8] = rectangle_9;
            rectanglesArray[9] = rectangle_0;

            rectanglesArray[10] = rectangle_a;
            rectanglesArray[11] = rectangle_b;
            rectanglesArray[12] = rectangle_c;
            rectanglesArray[13] = rectangle_d;
            rectanglesArray[14] = rectangle_e;
            rectanglesArray[15] = rectangle_f;
            rectanglesArray[16] = rectangle_g;
            rectanglesArray[17] = rectangle_h;
            rectanglesArray[18] = rectangle_i;
            rectanglesArray[19] = rectangle_j;
            rectanglesArray[20] = rectangle_k;
            rectanglesArray[21] = rectangle_l;
            rectanglesArray[22] = rectangle_m;
            rectanglesArray[23] = rectangle_n;
            rectanglesArray[24] = rectangle_o;
            rectanglesArray[25] = rectangle_p;
            rectanglesArray[26] = rectangle_q;
            rectanglesArray[27] = rectangle_r;
            rectanglesArray[28] = rectangle_s;
            rectanglesArray[29] = rectangle_t;
            rectanglesArray[30] = rectangle_u;
            rectanglesArray[31] = rectangle_v;
            rectanglesArray[32] = rectangle_w;
            rectanglesArray[33] = rectangle_x;
            rectanglesArray[34] = rectangle_y;
            rectanglesArray[35] = rectangle_z;

            rectanglesArray[36] = rectangle_dash;
            rectanglesArray[37] = rectangle_equals;
            rectanglesArray[38] = rectangle_openBracket;
            rectanglesArray[39] = rectangle_closeBracket;
            rectanglesArray[40] = rectangle_backLash;
            rectanglesArray[41] = rectangle_semiColon;
            rectanglesArray[42] = rectangle_apostrophe;
            rectanglesArray[43] = rectangle_comma;
            rectanglesArray[44] = rectangle_period;
            rectanglesArray[45] = rectangle_slash;

            rectanglesArray[46] = rectangle_tab;
            rectanglesArray[47] = rectangle_shift;
            rectanglesArray[48] = rectangle_return;
            rectanglesArray[49] = rectangle_back;
            rectanglesArray[50] = rectangle_shiftlock;
            rectanglesArray[51] = rectangle_spaceBar;
            //////////////////////////
            labelArray[0] = label_1;
            labelArray[1] = label_2;
            labelArray[2] = label_3;
            labelArray[3] = label_4;
            labelArray[4] = label_5;
            labelArray[5] = label_6;
            labelArray[6] = label_7;
            labelArray[7] = label_8;
            labelArray[8] = label_9;
            labelArray[9] = label_0;

            labelArray[10] = label_a;
            labelArray[11] = label_b;
            labelArray[12] = label_c;
            labelArray[13] = label_d;
            labelArray[14] = label_e;
            labelArray[15] = label_f;
            labelArray[16] = label_g;
            labelArray[17] = label_h;
            labelArray[18] = label_i;
            labelArray[19] = label_j;
            labelArray[20] = label_k;
            labelArray[21] = label_l;
            labelArray[22] = label_m;
            labelArray[23] = label_n;
            labelArray[24] = label_o;
            labelArray[25] = label_p;
            labelArray[26] = label_q;
            labelArray[27] = label_r;
            labelArray[28] = label_s;
            labelArray[29] = label_t;
            labelArray[30] = label_u;
            labelArray[31] = label_v;
            labelArray[32] = label_w;
            labelArray[33] = label_x;
            labelArray[34] = label_y;
            labelArray[35] = label_z;

            labelArray[36] = label_dash;
            labelArray[37] = label_equals;
            labelArray[38] = label_openBracket;
            labelArray[39] = label_closeBracket;
            labelArray[40] = label_backLash;
            labelArray[41] = label_semiColon;
            labelArray[42] = label_apostrophe;
            labelArray[43] = label_comma;
            labelArray[44] = label_period;
            labelArray[45] = label_slash;

            labelArray[46] = label_tab;
            labelArray[47] = label_shift;
            labelArray[48] = label_return;   
            labelArray[49] = label_back;
            labelArray[50] = label_shiftlock;
            labelArray[51] = label_spaceBar;         
        }
        private void WriteRectangle1()
        {
            int numberArrays = 0;
            //First Row Numbers
            for (int i = 0; i < 10; i++)
            {
                double widthMeme = 50;
                if(numberArrays == 12)
                {
                    widthMeme = 100;
                }
                rectanglesArray[numberArrays].Width = widthMeme;
                rectanglesArray[numberArrays].Height = 50;
                rectanglesArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                rectanglesArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                rectanglesArray[numberArrays].Stroke = Brushes.Black;
                rectanglesArray[numberArrays].Name = "rectangle_" + numbers[i];
                rectanglesArray[numberArrays].Margin = new Thickness(100 + (i * 55), 400, 0, 0);
                keyBoard.Children.Add(rectanglesArray[numberArrays]);

                labelArray[numberArrays].Width = widthMeme;
                labelArray[numberArrays].Height = 50;
                labelArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                labelArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                labelArray[numberArrays].Content = numbers[i];
                labelArray[numberArrays].Name = labelArray[numberArrays].Name.ToString();
                labelArray[numberArrays].Margin = new Thickness(100 + (i * 55), 400, 0, 0);
                keyBoard.Children.Add(labelArray[numberArrays]);
                numberArrays++;
            }
            // 2nd Row letters
            for (int i = 0; i < 26; i++)
            {
                if (i == 13)
                {
                    nextRow = 0;
                    nextColumn = 55;
                }
                
                rectanglesArray[numberArrays].Width = 50;
                rectanglesArray[numberArrays].Height = 50;
                rectanglesArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                rectanglesArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                rectanglesArray[numberArrays].Stroke = Brushes.Black;
                rectanglesArray[numberArrays].Name = "rectangle_" + numberArrays;
                rectanglesArray[numberArrays].Margin = new Thickness(100 + (nextRow * 55), 455 + nextColumn, 0, 0);
                keyBoard.Children.Add(rectanglesArray[numberArrays]);

                labelArray[numberArrays].Width = 50;
                labelArray[numberArrays].Height = 50;
                labelArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                labelArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                labelArray[numberArrays].Content = lowerLetters[i];
                labelArray[numberArrays].Name = labelArray[numberArrays].Name.ToString();
                labelArray[numberArrays].Margin = new Thickness(100 + (nextRow * 55), 455 + nextColumn, 0, 0);
                keyBoard.Children.Add(labelArray[numberArrays]);
                numberArrays++;
                nextRow++;
            }
            // 3rd Row Symbols
            for (int i = 0; i < 10; i++)
            {
                rectanglesArray[numberArrays].Width = 50;
                rectanglesArray[numberArrays].Height = 50;
                rectanglesArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                rectanglesArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                rectanglesArray[numberArrays].Stroke = Brushes.Black;
                rectanglesArray[numberArrays].Name = "rectangle_" + numberArrays;
                rectanglesArray[numberArrays].Margin = new Thickness(100 + (i * 55), 565, 0, 0);
                keyBoard.Children.Add(rectanglesArray[numberArrays]);

                labelArray[numberArrays].Width = 50;
                labelArray[numberArrays].Height = 50;
                labelArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                labelArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                labelArray[numberArrays].Content = unshift_symbols[i];
                labelArray[numberArrays].Name = labelArray[numberArrays].Name.ToString();
                labelArray[numberArrays].Margin = new Thickness(100 + (i * 55), 565, 0, 0);
                keyBoard.Children.Add(labelArray[numberArrays]);
                numberArrays++;
            }
            //4th Row
            for (int i = 0; i < 6; i++)
            {

                rectanglesArray[numberArrays].Width = 80;
                rectanglesArray[numberArrays].Height = 58;
                rectanglesArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                rectanglesArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                rectanglesArray[numberArrays].Stroke = Brushes.Black;
                rectanglesArray[numberArrays].Name = "rectangle_" + numberArrays;
                rectanglesArray[numberArrays].Margin = new Thickness(100 + (i * 85), 620, 0, 0);
                keyBoard.Children.Add(rectanglesArray[numberArrays]);

                labelArray[numberArrays].Width = 80;
                labelArray[numberArrays].Height = 50;
                labelArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                labelArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                labelArray[numberArrays].Content = commandButtons[i];
                labelArray[numberArrays].Name = labelArray[numberArrays].Name.ToString();
                labelArray[numberArrays].Margin = new Thickness(100 + (i * 85), 620, 0, 0);
                keyBoard.Children.Add(labelArray[numberArrays]);
                numberArrays++;
            }
        }
        private void upperCaps()
        {
            int count = 0;
            for (int i = 10; i < 36; i++)
            {
                labelArray[i].Content = upperLetters[count];
                count++;
            }
            count = 0;
            for (int i = 0; i < 10; i++)
            {
                labelArray[i].Content = shift_numbers[count];
                count++;
            }
            count = 0;
            for (int i = 36; i < 46; i++)
            {
                labelArray[i].Content = shift_symbols[count];
                count++;
            }

        }
        private void lowerCaps()
        {
            int count = 0;
            for (int i = 10; i < 36; i++)
            {
                labelArray[i].Content = lowerLetters[count];
                count++;
            }
            count = 0;
            for (int i = 0; i < 10; i++)
            {
                labelArray[i].Content = numbers[count];
                count++;
            }
            count = 0;
            for (int i = 36; i < 46; i++)
            {
                labelArray[i].Content = unshift_symbols[count];
                count++;
            }


        }
        private void backSpace()
        {           
            List<char> currentSentenceList = currentSentence.ToCharArray().ToList();
            if (currentSentenceList.Count > 0)
            {
                currentSentenceList.RemoveAt(currentSentenceList.Count - 1);
                currentSentence = new string(currentSentenceList.ToArray());
                label_userInput.Text = currentSentence;
            }
        }
        private char keyManager(Key key)
        {
            char returnKey = ' ';
            string keyString = key.ToString();
            if(shiftDown == true)
            {

            }
            switch (key.ToString())
            {
                case "Tab":
                    returnKey = '\t';
                    break;
                case "Space":
                    returnKey = ' ';
                    break;
                case "Capital":
                    shiftLock = !shiftLock;
                    if (shiftLock == true)
                    {
                        rectanglesArray[50].Fill = Brushes.IndianRed;
                        upperCaps();
                    }
                    else
                    {
                        rectanglesArray[50].Fill = Brushes.Transparent;
                        lowerCaps();
                    }
                    returnKey = '\b';
                    break;
                case "LeftShift":
                    returnKey = '\b';
                    break;
                case "Return":
                    returnKey = '\n';
                    break;
                case "Back":
                    backSpace();
                    break;
                case "D0":
                    returnKey = (char)labelArray[9].Content;
                    break;
                case "D1":
                    returnKey = (char)labelArray[0].Content;
                    break;
                case "D2":
                    returnKey = (char)labelArray[1].Content;
                    break;
                case "D3":
                    returnKey = (char)labelArray[2].Content;
                    break;
                case "D4":
                    returnKey = (char)labelArray[3].Content;
                    break;
                case "D5":
                    returnKey = (char)labelArray[4].Content;
                    break;
                case "D6":
                    returnKey = (char)labelArray[5].Content;
                    break;
                case "D7":
                    returnKey = (char)labelArray[6].Content;
                    break;
                case "D8":
                    returnKey = (char)labelArray[7].Content;
                    break;
                case "D9":
                    returnKey = (char)labelArray[8].Content;
                    break;
                case "A":
                    returnKey = (char)labelArray[10].Content;
                    break;
                case "B":
                    returnKey = (char)labelArray[11].Content;
                    break;
                case "C":
                    returnKey = (char)labelArray[12].Content;
                    break;
                case "D":
                    returnKey = (char)labelArray[13].Content;
                    break;
                case "E":
                    returnKey = (char)labelArray[14].Content;
                    break;
                case "F":
                    returnKey = (char)labelArray[15].Content;
                    break;
                case "G":
                    returnKey = (char)labelArray[16].Content;
                    break;
                case "H":
                    returnKey = (char)labelArray[17].Content;
                    break;
                case "I":
                    returnKey = (char)labelArray[18].Content;
                    break;
                case "J":
                    returnKey = (char)labelArray[19].Content;
                    break;
                case "K":
                    returnKey = (char)labelArray[20].Content;
                    break;
                case "L":
                    returnKey = (char)labelArray[21].Content;
                    break;
                case "M":
                    returnKey = (char)labelArray[22].Content;
                    break;
                case "N":
                    returnKey = (char)labelArray[23].Content;
                    break;
                case "O":
                    returnKey = (char)labelArray[24].Content;
                    break;
                case "P":
                    returnKey = (char)labelArray[25].Content;
                    break;
                case "Q":
                    returnKey = (char)labelArray[26].Content;
                    break;
                case "R":
                    returnKey = (char)labelArray[27].Content;
                    break;
                case "S":
                    returnKey = (char)labelArray[28].Content;
                    break;
                case "T":
                    returnKey = (char)labelArray[29].Content;
                    break;
                case "U":
                    returnKey = (char)labelArray[30].Content;
                    break;
                case "V":
                    returnKey = (char)labelArray[31].Content;
                    break;
                case "W":
                    returnKey = (char)labelArray[32].Content;
                    break;
                case "X":
                    returnKey = (char)labelArray[33].Content;
                    break;
                case "Y":
                    returnKey = (char)labelArray[34].Content;
                    break;
                case "Z":
                    returnKey = (char)labelArray[35].Content;
                    break;
                case "OemMinus":
                    returnKey = (char)labelArray[36].Content;
                    break;
                case "OemPlus":
                    returnKey = (char)labelArray[37].Content;
                    break;
                case "OemOpenBrackets":
                    returnKey = (char)labelArray[38].Content;
                    break;
                case "Oem6":
                    returnKey = (char)labelArray[39].Content;
                    break;
                case "Oem5": // Backslash
                    returnKey = (char)labelArray[40].Content;
                    break;
                case "Oem1":
                    returnKey = (char)labelArray[41].Content;
                    break;
                case "OemQuotes": // Apostrophe
                    returnKey = (char)labelArray[42].Content;
                    break;
                case "OemComma":
                    returnKey = (char)labelArray[43].Content;
                    break;
                case "OemPeriod":
                    returnKey = (char)labelArray[44].Content;
                    break;
                case "OemQuestion": // Slash
                    returnKey = (char)labelArray[45].Content;
                    break;
                default:
                    break;
            }
            return returnKey;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            int index = -1;
            foreach (var rectangle in rectanglesArray)
            {
                if (rectangle.Name != "rectangle_50")
                {
                    rectangle.Fill = Brushes.Transparent;
                }
            }
            if (e.Key == Key.Back)
            {
                backSpace();
            }
            else
            {
                if (e.Key == Key.LeftShift)
                {
                    shiftDown = !shiftDown;

                    if (shiftDown)
                    {
                        upperCaps();
                    }
                    else
                    {
                        lowerCaps();
                    }
                }
                else
                {
                    char keyChar = keyManager(e.Key);
                    if (shiftDown)
                    {
                        lowerCaps();
                    }

                    currentSentence += keyChar;
                }

            }
            label_userInput.Text = currentSentence;
            switch (e.Key)
            {
              
                case Key.D0:
                    index = 9;
                    break;
                case Key.D1:
                    index = 0;
                    break;
                case Key.D2:
                    index = 1;
                    break;
                case Key.D3:
                    index = 2;
                    break;
                case Key.D4:
                    index = 3;
                    break;
                case Key.D5:
                    index = 4;
                    break;
                case Key.D6:
                    index = 5;
                    break;
                case Key.D7:
                    index = 6;
                    break;
                case Key.D8:
                    index = 7;
                    break;
                case Key.D9:
                    index = 8;
                    break;
                case Key.A:
                    index = 10;
                    break;
                case Key.B:
                    index = 11;
                    break;
                case Key.C:
                    index = 12;
                    break;
                case Key.D:
                    index = 13;
                    break;
                case Key.E:
                    index = 14;
                    break;
                case Key.F:
                    index = 15;
                    break;
                case Key.G:
                    index = 16;
                    break;
                case Key.H:
                    index = 17;
                    break;
                case Key.I:
                    index = 18;
                    break;
                case Key.J:
                    index = 19;
                    break;
                case Key.K:
                    index = 20;
                    break;
                case Key.L:
                    index = 21;
                    break;
                case Key.M:
                    index = 22;
                    break;
                case Key.N:
                    index = 23;
                    break;
                case Key.O:
                    index = 24;
                    break;
                case Key.P:
                    index = 25;
                    break;
                case Key.Q:
                    index = 26;
                    break;
                case Key.R:
                    index = 27;
                    break;
                case Key.S:
                    index = 28;
                    break;
                case Key.T:
                    index = 29;
                    break;
                case Key.U:
                    index = 30;
                    break;
                case Key.V:
                    index = 31;
                    break;
                case Key.W:
                    index = 32;
                    break;
                case Key.X:
                    index = 33;
                    break;
                case Key.Y:
                    index = 34;
                    break;
                case Key.Z:
                    index = 35;
                    break;
                case Key.Back:
                    index = 49;
                    break;
                case Key.Enter:
                    index = 48;
                    break;
                case Key.LeftShift:
                    index = 47;
                    break;
                case Key.Tab:
                    index = 46;
                    break;

                default:
                    break;
            }
            if (index >= 0 && index < rectanglesArray.Length)
            {
                rectanglesArray[index].Fill = Brushes.Yellow;
            }

        }
    }
}