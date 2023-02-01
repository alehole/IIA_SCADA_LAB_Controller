using System;
using System.Windows.Forms;

namespace Controller
{
    public partial class Form1 : Form
    {
        readonly OPC_DA_Write _opc_Write_TempSP = new OPC_DA_Write();
        readonly OPC_DA_Write _opc_Write_Temp = new OPC_DA_Write();
        readonly OPC_DA_Write _opc_Write_U = new OPC_DA_Write();

        readonly PID _PID_Controller = new PID();

        readonly Write_AO _Write_U_Heater = new Write_AO();
        readonly Read_AI _Read_Temperature = new Read_AI();

        readonly SimTempProcess _SimProcess = new SimTempProcess();

        double Temperature;
        double Control_U;
        double[] Delay_Array = new double[20];
           
        bool online, realProcess, manualMode;
        public Form1()
        {
            InitializeComponent();
            InitValues();
            timer1.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _opc_Write_TempSP.Disconnect();
            _opc_Write_Temp.Disconnect();
            _opc_Write_U.Disconnect();
            _Write_U_Heater.Disconnect();
            _Read_Temperature.Disconnect();
        }
        private void InitValues()
        {
            online = false;
            realProcess = false;
            manualMode = false;

            sb_TempSP.Value = 25;

            // PID
            sb_Kp.Value = 3;
            sb_Ti.Value = 45;
            sb_Td.Value = 0;
            _PID_Controller.MaxU = 5;
            _PID_Controller.MinU = 0;
            _PID_Controller.y_Sp = Convert.ToDouble(sb_TempSP.Value);

            // Simulator
            SB_T_Env.Value = 21;
            SB_t_Delay.Value = 2;
            SB_KCV.Value = 3;
            SB_TimeConstant.Value = 23;

            _SimProcess.T_env = Convert.ToDouble(SB_T_Env.Value);
            _SimProcess.t_delay = Convert.ToDouble(SB_t_Delay.Value);
            _SimProcess.K_h = Convert.ToDouble(SB_KCV.Value);
            _SimProcess.Time_Constant = Convert.ToDouble(SB_TimeConstant.Value);

            for (int i = 0; i < Delay_Array.Length -1; i++)
            {
                Delay_Array[i] = 0;
            }
            if(CB_Mode  != null)
            {
                CB_Mode.SelectedIndex = 0;
            }
            if(CB_RealProc != null)
            {
                CB_RealProc.SelectedIndex = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (online)
            {
                Control(realProcess,manualMode);
                Process(realProcess);
                Visualization();
                Write_To_OPC();
            }
        }

        private void Control(bool RealProcess, bool manualMode)
        {
            _PID_Controller.T_s = Convert.ToDouble(timer1.Interval) / 1000;

            if (!manualMode)
            {
                if (RealProcess)
                {
                    Control_U = _PID_Controller.U(Temperature);
                }
                else
                {
                    Control_U = Delay_u(_PID_Controller.U(Temperature));
                }
            }
            else
            {
                Control_U = Convert.ToDouble(sb_ManModeVolt.Value);
            }
            
            if (RealProcess)
            {
                _Write_U_Heater.Write_AO_Value(Control_U);
            }
        }

        private void Process(bool RealProcess)
        {
            double Filter_Tf = 2;

            if (!RealProcess)
            {
                Temperature =  Filter.LowPassFilter( _SimProcess.ProcessModel(Control_U, _PID_Controller.T_s), Filter_Tf ,  _PID_Controller.T_s);
                TxtBx_ActualTemp.Text =  Convert.ToString(Math.Round(Temperature, 2));
            }
            else
            {
                Temperature = Conv.Volt_To_Temp2(Filter.LowPassFilter( _Read_Temperature.Read_AO_Value(), Filter_Tf, _PID_Controller.T_s));
                TxtBx_ActualTemp.Text = Convert.ToString(Math.Round(Temperature, 1));
            }
        }
        private void Visualization()
        {
            Graph_Temperature.PlotYAppend( Math.Round( Temperature, 1) , 0.1);
            Graph_U.PlotYAppend(Math.Round( Control_U, 2), 0.1);
        }

        // OPC
        private void Write_To_OPC()
        {
            _opc_Write_U.WriteValue(Convert.ToDouble(Math.Round(Control_U, 2)));
            _opc_Write_TempSP.WriteValue(Convert.ToDouble(_PID_Controller.y_Sp));
            _opc_Write_Temp.WriteValue(Convert.ToDouble(Math.Round(Temperature, 2)));
        }

        // Temperature
        private void sb_TempSP_ValueChanged(object sender, EventArgs e)
        {
            _PID_Controller.y_Sp = Convert.ToDouble(sb_TempSP.Value);
        }

        // PID
        private void TxtBx_TempSP_TextChanged(object sender, EventArgs e)
        {
            _PID_Controller.y_Sp = Convert.ToDouble(sb_TempSP.Value);
        }
        private void sb_Kp_ValueChanged(object sender, EventArgs e)
        {
            _PID_Controller.K_p = Convert.ToDouble(sb_Kp.Value);
        }

        private void sb_Ti_ValueChanged(object sender, EventArgs e)
        {
            _PID_Controller.T_i = Convert.ToDouble(sb_Ti.Value);
        }

        private void sb_Td_ValueChanged(object sender, EventArgs e)
        {
            _PID_Controller.T_d = Convert.ToDouble(sb_Td.Value);
        }

        // Simulation
        private void SB_T_Env_ValueChanged(object sender, EventArgs e)
        {
            _SimProcess.T_env = Convert.ToDouble(SB_T_Env.Value);
        }

        private void SB_t_Delay_ValueChanged(object sender, EventArgs e)
        {
            _SimProcess.t_delay = Convert.ToDouble(SB_t_Delay.Value);
        }

        private void SB_KCV_ValueChanged(object sender, EventArgs e)
        {
            _SimProcess.K_h = Convert.ToDouble(SB_KCV.Value);
        }

        private void SB_TimeConstant_ValueChanged(object sender, EventArgs e)
        {
            _SimProcess.Time_Constant = Convert.ToDouble(SB_TimeConstant.Value);
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            online = (online  == false) ? true : false;
            if (online)
            {
                TxtBx_Status.Text = "ONLINE";
                Btn_Start.Text = "Stop";

                _opc_Write_TempSP.Connect(@"\\MSI\OPCProcess\t_sp");
                _opc_Write_Temp.Connect(@"\\MSI\OPCProcess\T_measured");
                _opc_Write_U.Connect(@"\\MSI\OPCProcess\u");

                if (realProcess)
                {
                    _Write_U_Heater.Connect("dev5/ao0");
                    _Read_Temperature.Connect("dev5/ai0");
                }
            }
            else
            {
                TxtBx_Status.Text = "OFFLINE";
                Btn_Start.Text = "Start";
                
               _opc_Write_TempSP.Disconnect();
               _opc_Write_Temp.Disconnect();
               _opc_Write_U.Disconnect();

               _Write_U_Heater.Disconnect();
               _Read_Temperature.Disconnect();
            }
        }

        private void CB_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CB_Mode.SelectedIndex == 0)
            {
                manualMode = false;
            }
            else
            {
                manualMode = true;
            }
        }

        private void CB_RealProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CB_RealProc.SelectedIndex == 0)
            {
                realProcess = false;
            }
            else
            {
                realProcess = true;
            }
        }

        private double Delay_u(double U)
        {
            for (int i = Delay_Array.Length-1; i >= 1 ; i--)
            {
                Delay_Array[i] = Delay_Array[i - 1];
            }
            Delay_Array[0] = U;
            return Delay_Array[Delay_Array.Length-1];
        }
    }
}
