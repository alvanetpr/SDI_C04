using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseAlvaradoDiaz_CE04
{
    public class Car
    {


        public string make, model, color;
        public float milage;
        public int year;

        public string _make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string _model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string _color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public float _milage
        {
            get
            {
                return milage;
            }
            set
            {
                milage = value;
            }
        }
        public int _year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }


        }
    }
}
           

        
