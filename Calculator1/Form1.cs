namespace Calculator1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        //bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = double.Parse(result.Text);
            //operation_pressed = true;
            equation.Text = value + " " + operation;
            result.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }
            //operation_pressed = false;
        }
    }
}