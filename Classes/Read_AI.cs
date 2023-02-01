using NationalInstruments.DAQmx;

namespace Controller
{
    public class Read_AI
    {
        private Task analogInTask = new Task();
        private AIChannel MyAIChannel;
        private AnalogSingleChannelReader _reader;

        public void Connect(string pinName)
        {
            MyAIChannel = analogInTask.AIChannels.CreateVoltageChannel(
                    pinName, 
                     "MyAIChannel",
                    AITerminalConfiguration.Rse,
                    0,
                    5,
                    AIVoltageUnits.Volts
            );

            _reader = new AnalogSingleChannelReader(analogInTask.Stream);
        }
        public double Read_AO_Value()
        {
            return _reader.ReadSingleSample();
        }
        public void Disconnect()
        {
            if(_reader != null)
                _reader = null;
            if(analogInTask != null)
            {
                analogInTask.Stop();
                analogInTask = null;
            }
            if(MyAIChannel != null)
                MyAIChannel = null;

        }
    }
}
