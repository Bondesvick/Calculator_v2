namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentText;
        private string currentOperation;
        public Form1()
        {
            InitializeComponent();
        }

        private void ac_button_Click(object sender, EventArgs e)
        {
            this.calcDisplay.Text = string.Empty;
            currentText = string.Empty;
            currentOperation = string.Empty;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if(this.calcDisplay.Text.Length > 0)
            this.calcDisplay.Text = this.calcDisplay.Text.Substring(0, this.calcDisplay.Text.Length - 1);
        }

        private void modulus_Click(object sender, EventArgs e)
        {
            var previousValue = Convert.ToInt32(currentText);
            var currentValue = Convert.ToInt32(this.calcDisplay.Text);

            this.calcDisplay.Text = (previousValue % currentValue).ToString();
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var buttonText = button.Text;

            this.calcDisplay.Text += buttonText;
        }

        private void opperation_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var buttonText = button.Text;

            currentOperation = buttonText;
            currentText = this.calcDisplay.Text;
            this.calcDisplay.Text = "";

        }

        private void equals_Click(object sender, EventArgs e)
        {
            var previousValue = Convert.ToInt32(currentText);
            var currentValue = Convert.ToInt32(this.calcDisplay.Text);
            switch (currentOperation)
            {
                case "/":

                    this.calcDisplay.Text = (previousValue / currentValue).ToString();
                    break;

                case "X":
                    this.calcDisplay.Text = (previousValue * currentValue).ToString();
                    break;

                case "+":
                    this.calcDisplay.Text = (previousValue + currentValue).ToString();
                    break;

                case "-":
                    this.calcDisplay.Text = (previousValue - currentValue).ToString();
                    break;

                case "%":
                    this.calcDisplay.Text = (previousValue - currentValue).ToString();
                    break;
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var buttonText = button.Text;
            if (!this.calcDisplay.Text.Contains("."))
            {
                this.calcDisplay.Text += buttonText;
            }
        }
    }
}