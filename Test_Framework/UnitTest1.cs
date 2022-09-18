using System;
using System.Collections.Generic;
using System.IO;
using Xunit;


namespace Test_Framework
{
    public class UnitTest1
    {
        Tuple<List<string>, List<string>, List<string>> Battaery_Parameters_Retrived = new Tuple<List<string>, List<string>, List<string>>(null, null, null);



       [Fact]
        public void Test_Method_Excell_Data_Retriver()
        {
            Battery_Parameters_Sender Instance_1_Battery_Parameters_Sender = new Battery_Parameters_Sender();
            List<string> Sl_No_Data_Actual = new List<string>();
            List<string> Battery_Temperature_Data_Actual = new List<string>();
            List<string> Battery_SOC_Data_Actual = new List<string>();
            Battaery_Parameters_Retrived = Instance_1_Battery_Parameters_Sender.Excell_Data_Retriver(@"Battery_Data_Samples_CSV.csv");
            Instance_1_Battery_Parameters_Sender.Print_On_Console(Battaery_Parameters_Retrived);
            Sl_No_Data_Actual = Battaery_Parameters_Retrived.Item1;
            Battery_Temperature_Data_Actual = Battaery_Parameters_Retrived.Item2;
            Battery_SOC_Data_Actual = Battaery_Parameters_Retrived.Item3;

            Utillities Instance_Utillities = new Utillities();

            Assert.Equal(Sl_No_Data_Actual, Instance_Utillities.Sl_No_Data_Expected);
            Assert.Equal(Battery_Temperature_Data_Actual, Instance_Utillities.Battery_Temperature_Data_Expected);
            Assert.Equal(Battery_SOC_Data_Actual, Instance_Utillities.Battery_SOC_Data_Expected);
        }
    }
}
