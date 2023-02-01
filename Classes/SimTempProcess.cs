namespace Controller
{
    public class SimTempProcess
    {
        public double T_init { get; set; }
        public double T_env { get; set; }
        public double K_h { get; set; }
        public double t_delay { get; set; }
        public double Time_Constant { get; set; }

        private double t_k = 20;

        public double ProcessModel(double U, double T_s)
        {
            double Temperature = t_k + ((1 / Time_Constant) * (-1 * t_k + K_h * U + T_env))* T_s ;
            Temperature = Clip(Temperature, 50 , 0);
            t_k = Temperature;
            return Temperature;
        }
        private double Clip(double u, double max, double min)   // Limit
        {
            u = (u > max) ? max : u;
            u = (u < min) ? min : u;
            return u;
        }
    }
}
