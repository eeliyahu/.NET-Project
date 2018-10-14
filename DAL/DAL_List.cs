using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BE;

namespace DAL
{
    public class DAL_List : IDAL
    {
        private static DAL_List instance;
        private List<Flower> flowers;
        private DAL_List() {
            flowers = new List<Flower>();
        }
        public static DAL_List getInstance()
        {
            if(instance == null)
            {
                instance = new DAL_List();
            }
            return instance;
        }

        public void addFlower(Flower newFlower)
        {
            Flower flower = findFlower(newFlower.Name);
            if(flower != null)
            {
                throw new Exception("Flower already exists");
            }
            flowers.Add(newFlower);
        }

        public Flower findFlower(string name)
        {
            return flowers.Where(flower => flower.Name == name).First();
        }

        public bool removeFlower(Flower flower)
        {
            throw new NotImplementedException();
        }

        public string printTest()
        {
            return "All is working";
        }
    }
}
