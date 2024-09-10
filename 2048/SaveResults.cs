using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    internal static class SaveResults
    {
        internal static int GetRecord(string pathOfRecord)
        {
            if (File.Exists(pathOfRecord))
            {
                string record = File.ReadAllText(pathOfRecord);
                return int.Parse(record);
            }
            else
            {
                File.WriteAllText(pathOfRecord, "0");
                return 0;
            }
        }
        internal static void ReWriteRecord(int record, string pathOfRecord)
        {
            File.WriteAllText(pathOfRecord, record.ToString());
        }
        internal static void RecordReSet(string pathOfRecord)
        {
            if (!File.Exists(pathOfRecord))
            {
                MessageBox.Show("Файла с рекордом не существует");
            }
            else
            {
            File.WriteAllText(pathOfRecord, "0");
            }
        }
    }
}
