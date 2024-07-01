using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;
using Opc.UaFx;
using System.ServiceModel.Channels;
using System.Security.Principal;

namespace SimpleSCADA_DesktopViewer.Control_f
{ 

    public class Paths
    {

        OpcClient _Client;

        public Paths()
        {
            ConnectToPLC();
        }

        private void ConnectToPLC()
        {
            try
            {
                _Client = new OpcClient("opc.tcp://127.0.0.1:48102");
                _Client.Connect();
            }
            catch (Exception)
            {                
                return;
            }
        }

        //horizonatl paths

        public void runPath_A()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_D", true);


            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_101_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_100_F", true);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_100_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_D", false);

        }

        public void runPath_B()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_303", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_D", true);


            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_304_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_300_F", true);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_300_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_303", false);



        }

        public void runPath_C()
        {

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_F", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_6_SO").ToString() == "False")
            {            
                _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_6_F", true);
            }


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_6_F", false);


        }

        public void runPath_D()
        {

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_102", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_D", true);


            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_203_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_200_F", true);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_200_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_102", false);

        }

        public void runPath_E()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_101", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_D", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_202_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_200_F", true);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_200_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_101", false);
        }

        public void runPath_F()
        {

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_D", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_201_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_200_F", true);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_200_F", false);
        }

        public void runPath_G()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_D", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_F", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_402_S1").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_F", false);
        }

        public void runPath_H()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_201", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_D", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_302_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_300_F", true);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_300_F", false);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_201", false);

        }

        public void runPath_J()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_202", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_D", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_303_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_300_F", true);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_300_F", false);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_202", false);
        }

        public void runPath_K()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_D", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_100_B", true);


            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_301_S1").ToString() == "False")
            {
                //nix
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_D", false);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_100_B", false);

        }

        public void runPath_L()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_B", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_501_S1").ToString() == "False")
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_6_B", true);
            }


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_6_B", false);


        }


        //vertical paths

        public void runPath_M()
        {
   
            for (int i = 0; i < 4; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_B", true);

                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_501_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }

                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_B", false);
           
                Thread.Sleep(1000);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_B", false);

        }

        public void runPath_N()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_B", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_501", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_F", true);

            for (int i = 0; i < 4; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_F", true);

                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_1_SO").ToString() == "False")
                {
                    //Wait until sensor true
                }

                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_F", false);
                Thread.Sleep(1000);
            }


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_B", false);
        }

        public void runPath_O()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", true);

            Thread.Sleep(3000);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_B", true);

            Thread.Sleep(4500);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_B", true);

            Thread.Sleep(7000);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_B", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_B", false);

        }

        public void runPath_P()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_D", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_B", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_U", true);



            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_201", true);

            for (int i = 0; i < 4; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_B", true);

                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_301_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_B", false);
                Thread.Sleep(1000);

            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_B", true);
            Thread.Sleep(1000);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_D", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_B", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_201", false);
        }

        public void runPath_Q()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_4_B", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_401_S1").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_4_B", false);

        }

        public void runPath_R()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_4_F", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_4_SO").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_4_F", false);
        }

        public void runPath_S()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_201_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_201_F", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_F", true);


            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_401_S1").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_201_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_201_F", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_301_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_F", false);



        } 

        public void runPath_T()
        {

            //_Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_B", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_B", true);


            Thread.Sleep(7000);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_U", true);


            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_202_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_B", false);
                Thread.Sleep(1000);
            }

            // Thread.Sleep(3000);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_B", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_B", false);
        }

        public void runPath_U()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_F", true);


            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_3_SO").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_202_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_D", false);
        }

        public void runPath_V()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_101", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_B", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_F", true);

            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_203_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_B", false);
                Thread.Sleep(1000);
            }

            // Thread.Sleep(3000);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_B", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_F", false);

            Thread.Sleep(500);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_101", false);

        }

        public void runPath_W()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_F", true);


            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_2_SO").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_D", false);
        }

        public void runPath_X()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_102", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_B", true);

            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_204_S1").ToString() == "False")
                {
                    //Wait until sensor true                
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_B", false);
                Thread.Sleep(1000);
            }

            //Thread.Sleep(500);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_B", false);

            Thread.Sleep(250);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_102", false);

        }

        public void runPath_Y()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_501", true); // Never Reset

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_F", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", true);

            for (int i = 0; i < 2; i++)
            {
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_501_S1").ToString() == "False")
                {
                    _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_F", true);
                }
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_F", false);

            Thread.Sleep(250);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", false);
        }

        public void runPath_Z()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_303", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_F", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_F", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", true);

            for (int i = 0; i < 4; i++)
            {
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_303_S1").ToString() == "False")
                {
                    _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_F", true);
                }
            }

            //Thread.Sleep(500);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_F", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", false);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_F", false);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_F", false);

            Thread.Sleep(250);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_303", false);
        }

        public void runPath_a()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_5_F", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_5_SO").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_5_F", false);
        }

        public void runPath_b()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_5_B", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_402_S1").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_402_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_5_B", false);
        }

        public void runPath_r()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_402", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_D", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_B", true);


            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_401_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_B", false);
                Thread.Sleep(1000);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_401_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_400_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_402", false);



        }

        public void runPath_s()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_302", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_F", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_3_SO").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_302", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_F", false);
        }

        public void runPath_t()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_202", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_F", true);

            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_302_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_B", false);
                Thread.Sleep(1000);
            }

            // Thread.Sleep(3000);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_302_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_3_F", false);

            Thread.Sleep(500);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_202", false);
        }

        public void runPath_u()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_203", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_F", true);

            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_303_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", false);
                Thread.Sleep(1000);
            }

            // Thread.Sleep(3000);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_F", false);

            Thread.Sleep(500);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_203", false);
        }

        public void runPath_v()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_204", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_102", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_U", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_B", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_B", true);

            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_102_S1").ToString() == "False")
                {
                    //Wait until sensor true                
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_B", false);
                Thread.Sleep(1000);
            }


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_B", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_204", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_102", false);


        }

        public void runPath_w()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_204", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_B", true);

            for (int i = 0; i < 2; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", true);
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_304_S1").ToString() == "False")
                {
                    //Wait until sensor true                
                }
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", false);
                Thread.Sleep(1000);
            }

            //Thread.Sleep(500);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_501_D", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:D_500_B", false);

            Thread.Sleep(250);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_204", false);
        }

        public void runPath_x()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_304", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_F", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_F", true);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", true);

            for (int i = 0; i < 4; i++)
            {
                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_304_S1").ToString() == "False")
                {
                    _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_F", true);
                }
            }

            //Thread.Sleep(500);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_F", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_304_U", false);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_102_F", false);


            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_204_F", false);

            Thread.Sleep(250);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_304", false);
        }

        public void runPath_y()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_101", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_203", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_U", true);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_F", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", true);





            for (int i = 0; i < 4; i++)
            {
                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_F", true);

                while (_Client.ReadNode("ns=6;s=::AsGlobalPV:TS_203_S1").ToString() == "False")
                {
                    //Wait until sensor true
                }

                _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_F", false);

                Thread.Sleep(1000);
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_U", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_101_F", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_101", false);
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_203", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_203_U", false);

        }

        public void runPath_z()
        {
            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_303", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_B", true);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_F", true);

            while (_Client.ReadNode("ns=6;s=::AsGlobalPV:Station_2_SO").ToString() == "False")
            {
                //Wait until sensor true
            }

            _Client.WriteNode("ns=6;s=::AsGlobalPV:B_303", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_U", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:Station_2_B", false);

            _Client.WriteNode("ns=6;s=::AsGlobalPV:TS_303_F", false);

        }
    }
}

