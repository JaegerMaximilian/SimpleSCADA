using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer.Control_f
{
    public class Transitions
    {
        Paths _Paths;
        CancellationToken _CancellationToken;

        public Transitions()
        {
            _Paths = new Paths();
        }

        public void RouteAsync(int[] sequence, CancellationToken ct)
        {

            if (ct.IsCancellationRequested)
            {
                ct.ThrowIfCancellationRequested();
            }

            //erste Zahl=Von  zweite Zahl=Bis

            string sequenceString = sequence[0].ToString() + sequence[1].ToString();

            switch (sequenceString)
            {

                #region FromStart

                case "01":
                    sequence_0to1();
                    break;

                case "02":
                    sequence_0to2();
                    break;

                case "03":
                    sequence_0to3();
                    break;

                case "04":
                    sequence_0to4();
                    break;

                case "05":
                    sequence_0to5();
                    break;

                case "06":
                    sequence_0to6();
                    break;

                #endregion FromStart


                #region From1

                case "10":
                    sequence_1to0();
                    break;

                case "12":
                    sequence_1to2();
                    break;

                case "13":
                    sequence_1to3();
                    break;

                case "14":
                    sequence_1to4();
                    break;

                case "15":
                    sequence_1to5();
                    break;

                case "16":
                    sequence_1to6();
                    break;

                #endregion From1


                #region From2

                case "20":
                    sequence_2to0();
                    break;

                case "21":
                    sequence_2to1();
                    break;

                case "23":
                    sequence_2to3();
                    break;

                case "24":
                    sequence_2to4();
                    break;

                case "25":
                    sequence_2to5();
                    break;

                case "26":
                    sequence_2to6();
                    break;

                #endregion From2


                #region From3

                case "30":
                    sequence_3to0();
                    break;

                case "31":
                    sequence_3to1();
                    break;

                case "32":
                    sequence_3to2();
                    break;

                case "34":
                    sequence_3to4();
                    break;

                case "35":
                    sequence_3to5();
                    break;

                case "36":
                    sequence_3to6();
                    break;

                #endregion From3

                #region From4

                case "40":
                    sequence_4to0();
                    break;

                case "41":
                    sequence_4to1();
                    break;

                case "42":
                    sequence_4to2();
                    break;

                case "43":
                    sequence_4to3();
                    break;

                case "45":
                    sequence_4to5();
                    break;

                case "46":
                    sequence_4to6();
                    break;

                #endregion From4

                #region From 5

                case "50":
                    sequence_5to0();
                    break;

                case "51":
                    sequence_5to1();
                    break;

                case "52":
                    sequence_5to2();
                    break;

                case "53":
                    sequence_5to3();
                    break;

                case "54":
                    sequence_5to4();
                    break;

                case "56":
                    sequence_5to6();
                    break;

                #endregion From5

                #region From6


                case "60":
                    sequence_6to0();
                    break;

                case "61":
                    sequence_6to1();
                    break;

                case "62":
                    sequence_6to2();
                    break;

                case "63":
                    sequence_6to3();
                    break;

                case "64":
                    sequence_6to4();
                    break;

                case "65":
                    sequence_6to5();
                    break;

                    #endregion From6
            }
        }

        public void Route(int[] sequence)
        {

            //erste Zahl=Von  zweite Zahl=Bis

            string sequenceString = sequence[0].ToString() + sequence[1].ToString();

            switch (sequenceString)
            {

                #region FromStart

                case "01":
                    sequence_0to1();
                    break;

                case "02":
                    sequence_0to2();
                    break;

                case "03":
                    sequence_0to3();
                    break;

                case "04":
                    sequence_0to4();
                    break;

                case "05":
                    sequence_0to5();
                    break;

                case "06":
                    sequence_0to6();
                    break;

                #endregion FromStart


                #region From1

                case "10":
                    sequence_1to0();
                    break;

                case "12":
                    sequence_1to2();
                    break;

                case "13":
                    sequence_1to3();
                    break;

                case "14":
                    sequence_1to4();
                    break;

                case "15":
                    sequence_1to5();
                    break;

                case "16":
                    sequence_1to6();
                    break;

                #endregion From1


                #region From2

                case "20":
                    sequence_2to0();
                    break;

                case "21":
                    sequence_2to1();
                    break;

                case "23":
                    sequence_2to3();
                    break;

                case "24":
                    sequence_2to4();
                    break;

                case "25":
                    sequence_2to5();
                    break;

                case "26":
                    sequence_2to6();
                    break;

                #endregion From2


                #region From3

                case "30":
                    sequence_3to0();
                    break;

                case "31":
                    sequence_3to1();
                    break;

                case "32":
                    sequence_3to2();
                    break;

                case "34":
                    sequence_3to4();
                    break;

                case "35":
                    sequence_3to5();
                    break;

                case "36":
                    sequence_3to6();
                    break;

                #endregion From3

                #region From4

                case "40":
                    sequence_4to0();
                    break;

                case "41":
                    sequence_4to1();
                    break;

                case "42":
                    sequence_4to2();
                    break;

                case "43":
                    sequence_4to3();
                    break;

                case "45":
                    sequence_4to5();
                    break;

                case "46":
                    sequence_4to6();
                    break;

                #endregion From4

                #region From 5

                case "50":
                    sequence_5to0();
                    break;

                case "51":
                    sequence_5to1();
                    break;

                case "52":
                    sequence_5to2();
                    break;

                case "53":
                    sequence_5to3();
                    break;

                case "54":
                    sequence_5to4();
                    break;

                case "56":
                    sequence_5to6();
                    break;

                #endregion From5

                #region From6


                case "60":
                    sequence_6to0();
                    break;

                case "61":
                    sequence_6to1();
                    break;

                case "62":
                    sequence_6to2();
                    break;

                case "63":
                    sequence_6to3();
                    break;

                case "64":
                    sequence_6to4();
                    break;

                case "65":
                    sequence_6to5();
                    break;

                    #endregion From6
            }
        }



        #region FromStart
        private void sequence_0to1()
        {
            _Paths.runPath_x();
            _Paths.runPath_Y();
            _Paths.runPath_N();
        }

        private void sequence_0to2()
        {
            _Paths.runPath_A();
            _Paths.runPath_Z();
            _Paths.runPath_z();
        }

        private void sequence_0to3()
        {
            _Paths.runPath_A();
            _Paths.runPath_y();
            _Paths.runPath_E();
            _Paths.runPath_U();
        }

        private void sequence_0to4()
        {
            _Paths.runPath_A();
            _Paths.runPath_y();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_R();
        }

        private void sequence_0to5()
        {
            _Paths.runPath_A();
            _Paths.runPath_y();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_G();
            _Paths.runPath_a();

        }

        private void sequence_0to6()
        {
            _Paths.runPath_x();
            _Paths.runPath_Y();
            _Paths.runPath_C();

        }

        #endregion FromStart

        #region From1

        private void sequence_1to0()
        {
            _Paths.runPath_M();
            _Paths.runPath_w();
            _Paths.runPath_v();

        }

        private void sequence_1to2()
        {
            _Paths.runPath_M();
            _Paths.runPath_X();
            _Paths.runPath_D();
            _Paths.runPath_W();
        }

        private void sequence_1to3()
        {
            _Paths.runPath_M();
            _Paths.runPath_X();
            _Paths.runPath_D();
            _Paths.runPath_E();
            _Paths.runPath_U();
        }

        private void sequence_1to4()
        {
            _Paths.runPath_M();
            _Paths.runPath_X();
            _Paths.runPath_D();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_R();
        }

        private void sequence_1to5()
        {
            _Paths.runPath_M();
            _Paths.runPath_X();
            _Paths.runPath_D();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_G();
            _Paths.runPath_a();

        }

        private void sequence_1to6()
        {
            _Paths.runPath_M();
            _Paths.runPath_C();
        }

        #endregion From1

        #region From2

        private void sequence_2to0()
        {
            _Paths.runPath_u();
            _Paths.runPath_B();
            _Paths.runPath_v();
        }

        private void sequence_2to1()
        {
            _Paths.runPath_u();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_N();
        }
        private void sequence_2to3()
        {
            _Paths.runPath_V();
            _Paths.runPath_E();
            _Paths.runPath_U();

        }
        private void sequence_2to4()
        {
            _Paths.runPath_V();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_R();
        }
        private void sequence_2to5()
        {
            _Paths.runPath_V();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_G();
            _Paths.runPath_a();

        }
        private void sequence_2to6()
        {
            _Paths.runPath_u();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_C();
        }

        #endregion From2


        #region From3

        private void sequence_3to0()
        {
            _Paths.runPath_t();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_v();
        }

        private void sequence_3to1()
        {
            _Paths.runPath_t();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_N();
        }

        private void sequence_3to2()
        {
            _Paths.runPath_t();
            _Paths.runPath_J();
            _Paths.runPath_z();
        }

        private void sequence_3to4()
        {
            _Paths.runPath_T();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_R();
        }

        private void sequence_3to5()
        {
            _Paths.runPath_T();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_G();
            _Paths.runPath_a();
        }

        private void sequence_3to6()
        {
            _Paths.runPath_t();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_C();
        }

        #endregion From3

        #region From4

        private void sequence_4to0()
        {
            _Paths.runPath_Q();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_v();
        }

        private void sequence_4to1()
        {
            _Paths.runPath_Q();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_N();
        }

        private void sequence_4to2()
        {
            _Paths.runPath_Q();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_z();
        }

        private void sequence_4to3()
        {
            _Paths.runPath_Q();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_s();
        }

        private void sequence_4to5()
        {
            _Paths.runPath_Q();
            _Paths.runPath_G();
            _Paths.runPath_a();
        }

        private void sequence_4to6()
        {
            _Paths.runPath_Q();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_C();
        }

        #endregion From4


        #region From5

        private void sequence_5to0()
        {
            _Paths.runPath_b();
            _Paths.runPath_r();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_v();

        }

        private void sequence_5to1()
        {
            _Paths.runPath_b();
            _Paths.runPath_r();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_N();
        }

        private void sequence_5to2()
        {
            _Paths.runPath_b();
            _Paths.runPath_r();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_z();
        }

        private void sequence_5to3()
        {
            _Paths.runPath_b();
            _Paths.runPath_r();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_s();
        }

        private void sequence_5to4()
        {
            _Paths.runPath_b();
            _Paths.runPath_r();
            _Paths.runPath_R();
        }

        private void sequence_5to6()
        {
            _Paths.runPath_b();
            _Paths.runPath_r();
            _Paths.runPath_P();
            _Paths.runPath_H();
            _Paths.runPath_J();
            _Paths.runPath_B();
            _Paths.runPath_Y();
            _Paths.runPath_C();
        }

        #endregion From5

        #region From6

        private void sequence_6to0()
        {
            _Paths.runPath_L();
            _Paths.runPath_w();
            _Paths.runPath_v();
        }

        private void sequence_6to1()
        {
            _Paths.runPath_L();
            _Paths.runPath_N();
        }

        private void sequence_6to2()
        {
            _Paths.runPath_L();
            _Paths.runPath_X();
            _Paths.runPath_D();
            _Paths.runPath_W();

        }

        private void sequence_6to3()
        {
            _Paths.runPath_L();
            _Paths.runPath_X();
            _Paths.runPath_E();
            _Paths.runPath_U();

        }

        private void sequence_6to4()
        {
            _Paths.runPath_L();
            _Paths.runPath_w();
            _Paths.runPath_D();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_R();

        }

        private void sequence_6to5()
        {
            _Paths.runPath_L();
            _Paths.runPath_w();
            _Paths.runPath_D();
            _Paths.runPath_E();
            _Paths.runPath_F();
            _Paths.runPath_S();
            _Paths.runPath_G();
            _Paths.runPath_a();
        }

        #endregion From6
    }
}
