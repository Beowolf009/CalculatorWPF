using System.Windows;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void zeroBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void oneBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void threeBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void decimalBtn_Click(object sender, RoutedEventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void additionBtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void subtractBtn_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void multiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void divideBtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void equalsBtn_Click(object sender, RoutedEventArgs e)
        {
            compute(count);
        }

        private void cBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
