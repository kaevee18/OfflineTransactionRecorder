using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class TransactionMain
    {
        NotifyModelClass modelClass = new NotifyModelClass();
        private static string path;

        public TransactionMain()
        {
            path = @"..\..\Data\Data.json";
        }
        public void ParseAndAddTransaction(string str)
        {
            Regex accNoReg = new Regex("Account(.*)");

            if(accNoReg.IsMatch(str))
                modelClass.AccNo = accNoReg.Match(str).Value.Split()[1];
            else
            {
                accNoReg = new Regex("A/c(.*)");
                modelClass.AccNo = accNoReg.Match(str).Value.Split()[1];
            }

            if (str.Contains("credited"))
                modelClass.CreditDebitStatus = "Credited";
            else
                modelClass.CreditDebitStatus = "Debited";

            Regex amountReg = new Regex("Rs.(.*)");
            if (amountReg.IsMatch(str))
                modelClass.Amount = amountReg.Match(str).Value.Split()[1];
            else
            {
                amountReg = new Regex("INR(.*)");
                modelClass.Amount = amountReg.Match(str).Value.Split()[1];
            }

            Regex dateReg = new Regex("on(.*)");
            modelClass.Date = dateReg.Match(str).Value.Split()[1];

            Regex infoReg = new Regex("Info:(.*)");
            modelClass.Info = infoReg.Match(str).Value.Split()[1];

            Regex avlBalReg = new Regex(@"(Rs. )(?!.*\1)/g");

            int lastIndex = str.LastIndexOf("Rs. ");

            if(lastIndex < 0)
                lastIndex = str.LastIndexOf("INR ");

            modelClass.AvlBal = str.Substring(lastIndex + 1, str.Length - lastIndex - 1).Split()[1];

            WriteToDocument();
        }

        public void DeleteTransactionHistory()
        {
            File.Delete(path);
        }

        public DataGridView ShowTransaction(DataGridView grid)
        {
            if (File.Exists(path))
            {
                var readData = File.ReadAllText(path);
                string[] splits = Regex.Split(readData, "[\r\n]+");
                List<NotifyModelClass> readObject = new List<NotifyModelClass>();
                foreach (string split in splits)
                {
                    if (!string.IsNullOrEmpty(split))
                        readObject.Add(JsonConvert.DeserializeObject<NotifyModelClass>(split));
                }
                grid.DataSource = readObject;
                grid.Visible = true;
            }
            return grid;
        }

        private void WriteToDocument()
        {
            string jsonValue = JsonConvert.SerializeObject(modelClass);
            using (var temp = new StreamWriter(path, true))
            {
                temp.WriteLine(jsonValue.ToString());
                temp.Close();
            }
        }
    }
}
