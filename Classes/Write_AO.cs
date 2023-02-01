using NationalInstruments.DAQmx;

namespace Controller
{
   public class Write_AO
    {
        private Task analogOutTask = new Task();
        private AOChannel MyAOChannel;
        private AnalogSingleChannelWriter _writer;

        public void Connect(string pinName)
        {
             MyAOChannel = analogOutTask.AOChannels.CreateVoltageChannel(
                        pinName,
                        "myAOChannel",
                        0,
                        5,
                        AOVoltageUnits.Volts
                        );
            _writer = new AnalogSingleChannelWriter(analogOutTask.Stream);
        }
        public void Write_AO_Value(double AO_Value)
        {
            _writer.WriteSingleSample(true, AO_Value);
        }
        public void Disconnect()
        {
            if (_writer != null)
                _writer = null;

            if (analogOutTask != null)
            {
                analogOutTask.Stop();
                analogOutTask = null;
            }
            if(MyAOChannel != null)
                MyAOChannel = null;

        }
    }
}
