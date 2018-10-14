using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   
    public class Flower
    {
        public enum FlowerColor { RED, BLUE, GREEN, VIOLET, YELLOW, WHITE }
        private string _name;
        private FlowerColor _color;
        private float _price;

        public Flower(string _name, FlowerColor _color, float _price)
        {
            this._name = _name;
            this._color = _color;
            this._price = _price;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public FlowerColor Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        
    }
}
