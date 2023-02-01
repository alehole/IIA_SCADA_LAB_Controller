namespace Controller
{
    public class Filter
    {
        private static double y_k = 20;

        public static double LowPassFilter(double y_m, double T_f, double T_s)
        {
            double a;
            double y_fm;

            a = T_s / (T_s + T_f);
            y_fm = (1 - a) * y_k + a * y_m;
            y_k = y_fm;
            return y_fm;
        }
    }
}
