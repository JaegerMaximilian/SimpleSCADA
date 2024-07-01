using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSCADA_SharedResources
{
    public class SensorData
    {
        #region Properties
        //public int Id { get; private set; }
        public string sensorName { get;  private set; }
        public bool sensorState { get;  set; }
        #endregion

        #region Constructor
        public SensorData(string sensorName, bool sensorState)
        {
            this.sensorName = sensorName;
            this.sensorState = sensorState;
        }
        #endregion
    }
}
