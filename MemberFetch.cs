using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialProcessing
{
    public class MemberFetch
    {
        public void ShowAllMembers(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string membersFile = File.ReadAllText(filepath);
                    List<MemberShares> membersList = JsonConvert.DeserializeObject<List<MemberShares>>(membersFile);
                    Console.WriteLine("Name  \tSymbol \tShares\tAmount \tDate&Time");
                    foreach (MemberShares members in membersList)
                    {
                        Console.WriteLine(members.Name + "\t" + members.Symbol + "\t" + members.NumberOfShares + "\t" + members.Amount + "\t" + members.DateTime);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
