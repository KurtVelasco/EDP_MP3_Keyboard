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

namespace EDP_MP3_Keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> numbers = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "return" };
        private List<string> secondRow = new List<string>() { "q", "w", "e", "r", "t", "y","u", "i", "o", "p", "[", "]", "\\", "Back" };
        private List<string> thirdRow = new List<string>() { "tab", "a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "'", "Shift Lock" };
        private List<string> fourthRow = new List<string>() { "shift", "z", "x", "c", "v", "b", "n", "m", ",", ".", "/", "spacebar" };
        private List<string> capsNumbers = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "return" };
        private List<string> capsSecondRow = new List<string>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "{", "}", "|", "Back" };
        private List<string> capsThirdRow = new List<string>() { "tab", "A", "S", "D", "F", "G", "H", "J", "K", "L", ":", "\"\"", "Shift Lock" };
        private List<string> capsFourthRow = new List<string>() { "shift", "Z", "X", "C", "V", "B", "N", "M", "<", ">", "/", "spacebar" };
        private string currentSentence = "";
        private Rectangle[] rectanglesArray = new Rectangle[52];
        private Label[] labelArray = new Label[52];
        private int initiateNumber = 0;
        private bool lightButton = false;
        private bool shiftLock = false;

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
            rectanglesArray[10] = rectangle_dash;
            rectanglesArray[11] = rectangle_equals;
            rectanglesArray[12] = rectangle_return;
            rectanglesArray[13] = rectangle_q;
            rectanglesArray[14] = rectangle_w;
            rectanglesArray[15] = rectangle_e;
            rectanglesArray[16] = rectangle_r;
            rectanglesArray[17] = rectangle_t;
            rectanglesArray[18] = rectangle_y;
            rectanglesArray[19] = rectangle_u;
            rectanglesArray[20] = rectangle_i;
            rectanglesArray[21] = rectangle_o;
            rectanglesArray[22] = rectangle_p;
            rectanglesArray[23] = rectangle_openBracket;
            rectanglesArray[24] = rectangle_closeBracket;
            rectanglesArray[25] = rectangle_backLash;
            rectanglesArray[26] = rectangle_back;
            rectanglesArray[27] = rectangle_tab;
            rectanglesArray[28] = rectangle_a;
            rectanglesArray[29] = rectangle_s;
            rectanglesArray[30] = rectangle_d;
            rectanglesArray[31] = rectangle_f;
            rectanglesArray[32] = rectangle_g;
            rectanglesArray[33] = rectangle_h;
            rectanglesArray[34] = rectangle_j;
            rectanglesArray[35] = rectangle_k;
            rectanglesArray[36] = rectangle_l;
            rectanglesArray[37] = rectangle_semiColon;
            rectanglesArray[38] = rectangle_apostrophe;
            rectanglesArray[39] = rectangle_shiftlock;
            rectanglesArray[40] = rectangle_shift;
            rectanglesArray[41] = rectangle_z;
            rectanglesArray[42] = rectangle_x;
            rectanglesArray[43] = rectangle_c;
            rectanglesArray[44] = rectangle_v;
            rectanglesArray[45] = rectangle_b;
            rectanglesArray[46] = rectangle_n;
            rectanglesArray[47] = rectangle_m;
            rectanglesArray[48] = rectangle_comma;
            rectanglesArray[49] = rectangle_period;
            rectanglesArray[50] = rectangle_slash;
            rectanglesArray[51] = rectangle_spaceBar;

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
            labelArray[10] = label_dash;
            labelArray[11] = label_equals;
            labelArray[12] = label_return;
            labelArray[13] = label_q;
            labelArray[14] = label_w;
            labelArray[15] = label_e;
            labelArray[16] = label_r;
            labelArray[17] = label_t;
            labelArray[18] = label_y;
            labelArray[19] = label_u;
            labelArray[20] = label_i;
            labelArray[21] = label_o;
            labelArray[22] = label_p;
            labelArray[23] = label_openBracket;
            labelArray[24] = label_closeBracket;
            labelArray[25] = label_backLash;
            labelArray[26] = label_back;
            labelArray[27] = label_tab;
            labelArray[28] = label_a;
            labelArray[29] = label_s;
            labelArray[30] = label_d;
            labelArray[31] = label_f;
            labelArray[32] = label_g;
            labelArray[33] = label_h;
            labelArray[34] = label_j;
            labelArray[35] = label_k;
            labelArray[36] = label_l;
            labelArray[37] = label_semiColon;
            labelArray[38] = label_apostrophe;
            labelArray[39] = label_shiftlock;
            labelArray[40] = label_shift;
            labelArray[41] = label_z;
            labelArray[42] = label_x;
            labelArray[43] = label_c;
            labelArray[44] = label_v;
            labelArray[45] = label_b;
            labelArray[46] = label_n;
            labelArray[47] = label_m;
            labelArray[48] = label_comma;
            labelArray[49] = label_period;
            labelArray[50] = label_slash;
            labelArray[51] = label_spaceBar;

        }
        private void WriteRectangle1()
        {
            int numberArrays = 0;
            //First Row
            for (int i = 0; i < 13; i++)
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
                rectanglesArray[numberArrays].Name = "rectangle" + numberArrays;
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
            // 2nd Row
            for (int i = 0; i < 13; i++)
            {
                double widthMeme = 50;
                if (i == 15)
                {
                    widthMeme = 100;
                }
                rectanglesArray[numberArrays].Width = widthMeme;
                rectanglesArray[numberArrays].Height = 50;
                rectanglesArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                rectanglesArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                rectanglesArray[numberArrays].Stroke = Brushes.Black;
                rectanglesArray[numberArrays].Name = "rectangle" + numberArrays;
                rectanglesArray[numberArrays].Margin = new Thickness(100 + (i * 55), 455, 0, 0);
                keyBoard.Children.Add(rectanglesArray[numberArrays]);

                labelArray[numberArrays].Width = widthMeme;
                labelArray[numberArrays].Height = 50;
                labelArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                labelArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                labelArray[numberArrays].Content = secondRow[i];
                labelArray[numberArrays].Name = labelArray[numberArrays].Name.ToString();
                labelArray[numberArrays].Margin = new Thickness(100 + (i * 55), 455, 0, 0);
                keyBoard.Children.Add(labelArray[numberArrays]);
                numberArrays++;
            }
            // 3rd Row
            for (int i = 0; i < 13; i++)
            {
                double widthMeme = 50;
                if (i == 12)
                {
                    widthMeme = 100;
                }
                rectanglesArray[numberArrays].Width = widthMeme;
                rectanglesArray[numberArrays].Height = 50;
                rectanglesArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                rectanglesArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                rectanglesArray[numberArrays].Stroke = Brushes.Black;
                rectanglesArray[numberArrays].Name = "rectangle" + numberArrays;
                rectanglesArray[numberArrays].Margin = new Thickness(100 + (i * 55), 510, 0, 0);
                keyBoard.Children.Add(rectanglesArray[numberArrays]);

                labelArray[numberArrays].Width = widthMeme;
                labelArray[numberArrays].Height = 50;
                labelArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                labelArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                labelArray[numberArrays].Content = thirdRow[i];
                labelArray[numberArrays].Name = labelArray[numberArrays].Name.ToString();
                labelArray[numberArrays].Margin = new Thickness(100 + (i * 55), 510, 0, 0);
                keyBoard.Children.Add(labelArray[numberArrays]);
                numberArrays++;
            }
            string meme = "meme";
            //4th Row
            for (int i = 0; i < 12; i++)
            {
                double widthMeme = 50;
                if (i == 11)
                {
                    widthMeme = 100;
                }
                rectanglesArray[numberArrays].Width = widthMeme;
                rectanglesArray[numberArrays].Height = 50;
                rectanglesArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                rectanglesArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                rectanglesArray[numberArrays].Stroke = Brushes.Black;
                rectanglesArray[numberArrays].Name = "rectangle" + numberArrays;
                rectanglesArray[numberArrays].Margin = new Thickness(100 + (i * 55), 570, 0, 0);
                keyBoard.Children.Add(rectanglesArray[numberArrays]);

                labelArray[numberArrays].Width = widthMeme;
                labelArray[numberArrays].Height = 50;
                labelArray[numberArrays].VerticalAlignment = VerticalAlignment.Top;
                labelArray[numberArrays].HorizontalAlignment = HorizontalAlignment.Left;
                labelArray[numberArrays].Content = fourthRow[i];
                labelArray[numberArrays].Name = labelArray[numberArrays].Name.ToString();
                labelArray[numberArrays].Margin = new Thickness(100 + (i * 55), 570, 0, 0);
                keyBoard.Children.Add(labelArray[numberArrays]);
                numberArrays++;
            }

        }
        private void upperCaps()
        {
            int numberArrays = 0;
            //First Row
            for (int i = 0; i < 13; i++)
            {
                labelArray[numberArrays].Content = capsNumbers[i];
                numberArrays++;
            }
            for (int i = 0; i < 13; i++)
            {
                labelArray[numberArrays].Content = capsSecondRow[i];
                numberArrays++;
            }
            for (int i = 0; i < 13; i++)
            {
                labelArray[numberArrays].Content = capsThirdRow[i];
                numberArrays++;
            }
            for (int i = 0; i < 12; i++)
            {
                labelArray[numberArrays].Content = capsFourthRow[i];
                numberArrays++;
            }

        }
        private void lowerCaps()
        {
            int numberArrays = 0;
            //First Row
            for (int i = 0; i < 13; i++)
            {
                labelArray[numberArrays].Content = numbers[i];
                numberArrays++;
            }
            for (int i = 0; i < 13; i++)
            {
                labelArray[numberArrays].Content = secondRow[i];
                numberArrays++;
            }
            for (int i = 0; i < 13; i++)
            {
                labelArray[numberArrays].Content = thirdRow[i];
                numberArrays++;
            }
            for (int i = 0; i < 12; i++)
            {
                labelArray[numberArrays].Content = fourthRow[i];
                numberArrays++;
            }

        }
        private char keyManager(Key key)
        {
            char returnKey = ' ';
            switch (key.ToString())
            {
                case "Space":
                    returnKey = ' ';
                    break;
                case "Capital":
                    returnKey = '\b';
                    break;
                default:
                    if (key >= Key.D0 && key <= Key.D9)
                    {
                        returnKey = (char)(key - Key.D0 + '0');
                    }
                    else if ((key >= Key.A && key <= Key.Z) || (key >= Key.NumPad0 && key <= Key.NumPad9))
                    {
                        returnKey = key.ToString().ToLower()[0];
                    }
                    break;
            }
            return returnKey;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (var rectangle in rectanglesArray)
            {
                if (rectangle.Name != "rectangle38")
                {
                    rectangle.Fill = Brushes.Transparent;
                }
            }

            currentSentence += keyManager(e.Key);
            label_userInput.Text = currentSentence;  
            switch (e.Key)
            {
                case Key.Capital:
                    shiftLock = !shiftLock;
                    if(shiftLock == true)
                    {
                        rectanglesArray[38].Fill = Brushes.IndianRed;
                        upperCaps();
                    }
                    else
                    {
                        rectanglesArray[38].Fill = Brushes.Transparent;
                        lowerCaps();
                    }
                 break;
                case Key.D1: // 1
                    rectanglesArray[0].Fill = Brushes.LightYellow;
                    break;
                case Key.D2: // 2
                    rectanglesArray[1].Fill = Brushes.LightYellow;
                    break;
                case Key.D3: // 3
                    rectanglesArray[2].Fill = Brushes.LightYellow;
                    break;
                case Key.D4: // 4
                    rectanglesArray[3].Fill = Brushes.LightYellow;
                    break;
                case Key.D5: // 5
                    rectanglesArray[4].Fill = Brushes.LightYellow;
                    break;
                case Key.D6: // 6
                    rectanglesArray[5].Fill = Brushes.LightYellow;
                    break;
                case Key.D7: // 7
                    rectanglesArray[6].Fill = Brushes.LightYellow;
                    break;
                case Key.D8: // 8
                    rectanglesArray[7].Fill = Brushes.LightYellow;
                    break;
                case Key.D9: // 9
                    rectanglesArray[8].Fill = Brushes.LightYellow;
                    break;
                case Key.D0: // 0
                    rectanglesArray[9].Fill = Brushes.LightYellow;
                    break;
                default:
                    break;
            }
           
        }
    }
}