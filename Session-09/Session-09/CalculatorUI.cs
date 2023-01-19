using LibCalculator;

namespace Session_09 {
    public partial class CalculatorUI : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;

        enum CalcOperation {
            Add,
            Subtract,
            Multiply,
            Divide,
            Pow,
            Root2
        }

        public CalculatorUI() {
            InitializeComponent();
        }

        private void numberClick(object sender, EventArgs e) {
            resultTextBox.Text = "Number clicked";
        }

        private void operatorClick(object sender, EventArgs e) {
            resultTextBox.Text = "Operator clicked";
        }

        private void resultClick(object sender, EventArgs e) {
            resultTextBox.Text = "Result clicked";
        }

        private void decimalClick(object sender, EventArgs e) {
            resultTextBox.Text = "Decimal point clicked";
        }

        private void clearClick(object sender, EventArgs e) {
            resultTextBox.Text = "";
        }

    }
}