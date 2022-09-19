using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class SingleTonPattern
    {
        private static SingleTonPattern s1 = null;
        private SingleTonPattern()
        {
        }

        public static SingleTonPattern getInstance()
        {
            if (s1 == null)
            {
                s1 = new SingleTonPattern();
            }
            return s1;
        }

        Dictionary<string, string> d1 = new Dictionary<string, string>();

        public bool AddMembers(string userName, string password)
        {
            if (d1.ContainsKey(userName))
            {
                return false;
            }
            d1.Add(userName, password);
            return true;
        }

        public bool CheckMembers(string userName, string password)
        {
            if(d1.ContainsKey(userName) && d1[userName] == password)
            {
                return true;
            }
            return false;
        }

    }
}
