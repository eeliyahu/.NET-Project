using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        void addFlower(Flower flower);
        bool removeFlower(Flower flower);
        Flower findFlower(string name);
        string printTest();
           
        
    }
}
