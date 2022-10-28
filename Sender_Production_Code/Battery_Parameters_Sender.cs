using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sender_Production_Code
{
    internal class Battery_Parameters_Sender
    {
        public Tuple<List<string>, List<string>, List<string>> Excell_Data_Retriver(string Path)
        {
            string line;
            string[] columns = null;
            List<string> Sl_No = new List<string>();
            List<string> Battery_Temperature = new List<string>();
            List<string> Battery_SOC = new List<string>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    columns = line.Split(',');
                    Sl_No.Add(columns[0]);
                    Battery_Temperature.Add(columns[1]); //and so on..                   
                    Battery_SOC.Add(columns[2]);

                }
            }
            return Tuple.Create(Sl_No.ToList(), Battery_Temperature.ToList(), Battery_SOC.ToList());
        }


        public void Print_On_Console(Tuple<List<string>, List<string>, List<string>> Excell_Data_Retriver)
        {

            for (int i = 0; i <= Excell_Data_Retriver.Item1.Count() - 1; i++)
            {

                Console.WriteLine(Excell_Data_Retriver.Item1[i] + " " + Excell_Data_Retriver.Item2[i] + " " + Excell_Data_Retriver.Item3[i]);

            }

        }
    }
}
