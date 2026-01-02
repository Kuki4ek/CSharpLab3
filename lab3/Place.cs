using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Place
    {
        public double width {  get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public Place(double length, double width, double height)
        {
            if ((length * width) < 1)
            {
                throw new ArgumentException("Площадь помещения не может быть меньше 1 квадратного метра");
            }
            if (height < 2)
            {
                throw new ArgumentException("Высота помещения не может быть меньше 2 метров");
            }
            this.length = length;       
            this.width = width;
            this.height = height;
        }
        public virtual double GetArea()
        {
            return length * width;
        }
        public virtual double GetLiveArea()
        {
            return length * width;
        }
        public virtual double GetVolume()
        {
            return length * width * height;
        }
    }
}
