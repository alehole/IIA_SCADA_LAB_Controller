namespace Controller
{
    public class Conv
    {
        public static double Volt_To_Temp(double V) // 1-5 V 20-50 cels
        {
            return  ((15 / 2) * V + (25 / 2));
        }
        public static double Temp_To_Volt(double T)
        {
            return ((4 / 30) * T - (5 / 3));
        }

        public static double Volt_To_Temp2(double V) // 1-5V = 0-50 Cels
        {
            return ((25 / 2) * V - (25 / 2));
        }
    }
}
