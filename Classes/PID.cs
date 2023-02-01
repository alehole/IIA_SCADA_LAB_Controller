using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PID
    {
        public double K_p { get; set; } = 3;
        public double T_i { get; set; } = 40;
        public double T_d { get; set; } = 0;
        public double T_s { get; set; } = 1;
        public double y_Sp { get; set; } = 20;

        public double MaxU { get; set; } = 5;
        public double MinU { get; set; } = 0;

        private double u_i_k;
        private double error_k1 = 0;
        public double U(double y_mf_k)
        {
            double error_k = y_Sp - y_mf_k;     // error
            double u_p_k = K_p * error_k;       // P-Term
            double u_d_k = K_p * T_d * (error_k - error_k1) / T_s;  // D-Term
            error_k1 = error_k;                            // Last error
            u_i_k += (K_p * error_k * T_s) / T_i;         // I-Term
            u_i_k = Clip(u_i_k, MaxU, MinU);              // Anti windup of I-term 
            return Clip(u_p_k + u_i_k + u_d_k, MaxU, MinU);
        }
        private double Clip(double u, double max, double min)   // Limit
        {
            u = (u > max) ? max : u;
            u = (u < min) ? min : u;
            return u;
        }
    }
}
