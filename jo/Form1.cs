namespace jo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_number(object sender, EventArgs e)
        {
            Button button_number= (Button)sender;
            if (textBox1.Text=="0") {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + button_number.Text;
        }

        private void c_button(object sender, EventArgs e)
        {
            textBox1.Clear();

        }
        bool operator_click = false;
        string operatorStore;
        public void op_button(object sender, EventArgs e)
        {
            Button button_op = (Button)sender;


            if (operator_click == false)
            {
                //first click
                label1.Text = textBox1.Text;
                textBox1.Clear();
                operator_click = true;
            }
            else
            {
                //second click
                double result;
                //switch
                
                switch (operatorStore)
                {
                    case "+":

                        result = double.Parse(label1.Text) + double.Parse(textBox1.Text);
                        label1.Text = result.ToString();
                        break;

                    case "-":

                        result = double.Parse(label1.Text) - double.Parse(textBox1.Text);
                        label1.Text = result.ToString();
                        break;

                    case "*":

                        result = double.Parse(label1.Text) * double.Parse(textBox1.Text);
                        label1.Text = result.ToString();
                        break;

                    case "/":

                        result = double.Parse(label1.Text) / double.Parse(textBox1.Text);
                        label1.Text = result.ToString();
                        break;
                }

                textBox1.Clear();

            }
            operatorStore = button_op.Text;


        }

        private void button16_Click(object sender, EventArgs e)
        {
            operator_click = false;
            double result;
            switch (operatorStore)
            {
                case "+":

                    result = double.Parse(label1.Text) + double.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    label1.Text = "";
                    break;
                case "-":

                    result = double.Parse(label1.Text) - double.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    label1.Text = "";
                    break;
                case "*":

                    result = double.Parse(label1.Text) * double.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    label1.Text = "";
                    break;
                case "/":

                    result = double.Parse(label1.Text) * double.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    label1.Text = "";
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}