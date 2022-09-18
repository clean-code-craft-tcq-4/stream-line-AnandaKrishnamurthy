using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Framework
{
    internal class Console_Output
    {
        static void Print_Sender_Data()
        {

            Battery_Parameters_Sender Instance_Battery_Parameters_Sender = new Battery_Parameters_Sender();
            Instance_Battery_Parameters_Sender.Print_On_Console(Instance_Battery_Parameters_Sender.Excell_Data_Retriver(@"Battery_Data_Samples_CSV.csv"));

        }
    }
    }
