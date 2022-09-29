using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseMyLibraryWPF
{
   
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }
        public string Fname { get; set; }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
