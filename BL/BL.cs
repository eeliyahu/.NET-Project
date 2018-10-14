using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL
    {
        private DAL.IDAL dal = DAL.FactoryDAL.getDAL();

        public string BL_PrintTest()
        {
            return dal.printTest();
        }
    }
}
