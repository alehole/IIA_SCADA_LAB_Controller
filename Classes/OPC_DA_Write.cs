using NationalInstruments.NetworkVariable;

namespace Controller
{
    class OPC_DA_Write
    {
        private NetworkVariableWriter<double> _writer;

        public void Connect(string TagAdress)
        {
            if (_writer == null)
            {
                _writer = new NetworkVariableWriter<double>(TagAdress);
                _writer.Connect();
            }
        }
        public void Disconnect()
        {
            _writer.Disconnect();
            _writer = null;
        }
        public void WriteValue(double val)
        {
            if (_writer != null)
                _writer.WriteValue(val);
        }

        public string Con_status()
        {
            if (_writer != null)
                return _writer.ConnectionStatus.ToString();
            else
                return null;
        }
    }
}
