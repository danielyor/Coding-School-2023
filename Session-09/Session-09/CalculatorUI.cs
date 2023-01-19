using LibCalculator;

namespace Session_09 {
    public partial class CalculatorUI : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;
        private bool _opSelected = false;
        private string _strValue = string.Empty;

        private CalcOperation _calcOperation;

        enum CalcOperation {
            Add,
            Subtract,
            Multiply,
            Divide,
            Pow,
            SqRoot
        }

        public CalculatorUI() {
            InitializeComponent();
        }

        private void numberClick(object sender, EventArgs e) {
            resultTextBox.Text += ((Button)sender).Text;

            // fill string until operator or result is selected
            // update textbox
        }

        private void decimalClick(object sender, EventArgs e) {
            //resultTextBox.Text = "Decimal point clicked";

            // if string has no decimal point, insert it
            // update textbox

        }

        private void operatorClick(object sender, EventArgs e) {
            //resultTextBox.Text = "Operator clicked";

            // if value1 is not null and value2 is, convert string to value1 and update operator
            // update textbox
        }

        private void resultClick(object sender, EventArgs e) {
            //resultTextBox.Text = "Result clicked";
            //Addition addition = new();
            //resultTextBox.Text = Convert.ToString( addition.Do(5, (decimal) 5.25) );

            // if both values and operator are not null, convert string to value2 and calc result
            // update textbox
        }

        private void clearClick(object sender, EventArgs e) {
            resultTextBox.Text = string.Empty;
            _strValue = string.Empty;
            _value1 = null;
            _value2 = null;
            _result = null;
            _opSelected = false;
    }

    }
}