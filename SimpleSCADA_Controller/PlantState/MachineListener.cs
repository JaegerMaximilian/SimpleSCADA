using Opc.UaFx.Client;
using Opc.UaFx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSCADA_SharedResources
{

    //Hier kommt der CODE der auf die SPS sensoren hört und an DBA schickt....
    public class MachineListener
    {

        

        #region Constructor
        public MachineListener()
        {

        }
        #endregion

        #region Subscribe Nodes
        public void SubscribeNodes()
        {
            OpcClient client;

            try
            {
                client = new OpcClient("opc.tcp://127.0.0.1:48102");
                client.Connect();
            }
            catch (Exception)
            {
                return;
            }

            OpcSubscribeDataChange []
            commands = new OpcSubscribeDataChange[] {

            #region Sensors
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_101_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_102_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_103_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_104_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_105_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_106_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_107_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_201_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_202_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_203_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_204_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_205_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_206_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_207_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_208_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_209_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_301_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_302_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_303_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_304_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_305_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_306_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_307_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_308_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:SE_309_S1", HandleDataChanged),
            #endregion

            #region Transferstations
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_101_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_102_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_201_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_202_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_203_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_204_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_301_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_302_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_303_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_304_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_401_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_402_S1", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:TS_501_S1", HandleDataChanged),
            #endregion

            #region Stations
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:Station_1_SO", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:Station_2_SO", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:Station_3_SO", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:Station_4_SO", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:Station_5_SO", HandleDataChanged),
            new OpcSubscribeDataChange("ns=6;s=::AsGlobalPV:Station_6_SO", HandleDataChanged),
            #endregion

            };

            OpcSubscription subscription = client.SubscribeNodes(commands);
}
        #endregion


        #region Event Handler
        PlantManager plantManager = new PlantManager();
        Plant plant;
        PlantState plantState = new PlantState();
        LogManager logManager = new LogManager();

        private void HandleDataChanged(object sender, OpcDataChangeReceivedEventArgs e)
        {

            OpcMonitoredItem item = (OpcMonitoredItem)sender;
            plant = new Plant();
            plant = plantManager.GetPlant();

            bool value = bool.Parse(e.Item.Value.ToString());
            string NodeId = item.NodeId.ToString();
            NodeId = NodeId.Substring(20, NodeId.Length-23);

            SensorData sensorData = new SensorData(NodeId, value);

            if (value)
            {
                plantManager.EditSensorData(sensorData);

                plant.ActualPlantState = plantState;
                plantManager.EditPlant(plant);

                //Log freshlog = LogManager.CreateLog(NodeId);
                //logManager.AddLog(freshlog);

            }
        }
        #endregion
    }




}
