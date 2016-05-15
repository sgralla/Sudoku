using System.IO;
using System.Text;

namespace Sudoku
{
    class InpOut
    {
     
        internal static bool writeGameFieldToCSV(int[,] GameField)
        {
            bool sucessfull = false;

            //string filePath = @"C:\test.csv";
            ////string filePath = "C:\test.csv";
            //string delimiter = ",";
           
            //string[][] output = new string[][]
            //{
            //    new string[]{"Col 1 Row 1", "Col 2 Row 1", "Col 3 Row 1"},
            //    new string[]{"Col1 Row 2", "Col2 Row 2", "Col3 Row 2"}
            //};
            //int length = output.GetLength(0);
            //StringBuilder sb = new StringBuilder();
            //for (int index = 0; index < length; index++)
            //    sb.AppendLine(string.Join(delimiter, output[index]));

            //File.WriteAllText(filePath, sb.ToString());

            TextWriter sw = new StreamWriter("C:\\temp\\Data.csv");
            string strData = "Zaara";
            //double doubleData = 324.563;
            //doubleData.ToString("D2");
            sw.WriteLine("{0},{1}", strData, strData);

            return sucessfull;
        }

    }
}
