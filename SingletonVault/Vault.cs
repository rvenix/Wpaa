using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonVault
{
    public sealed class Vault
    {
        private static Vault AccessKey;
        private static object syncRoot = new object();
        private static string key;

        private Vault() 
        {
            Random rnd = new Random();
            key = rnd.Next(0, 100).ToString() + rnd.Next(0, 1000);
        }

        public static Vault Instance
        {
            get
            {
                lock (syncRoot)
                { 
                    if(AccessKey == null)
                    {
                        AccessKey = new Vault();
                    }
                }

                return AccessKey;
            }
        }

        public string GetAccessKey()
        {
            return key;
        }
    }
}
