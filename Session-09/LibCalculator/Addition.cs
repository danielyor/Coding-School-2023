namespace LibCalculator {
    public class Addition {
        public decimal Do(decimal? x, decimal? y) {

            decimal output = 0;

            if (x != null && y != null) {
                output = x.Value + y.Value;
            }

            return output;
        }
    }
}