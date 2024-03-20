using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLuanVan
{
    public class GlobalVariables
    {
        private static GlobalVariables instance;
        public string globalVariablesMSSV;

        private GlobalVariables() { }

        public static GlobalVariables Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalVariables();
                }
                return instance;
            }
        }

        public string MSSV
        {
            get { return globalVariablesMSSV; }
            set { globalVariablesMSSV = value; }
        }
    }
}
