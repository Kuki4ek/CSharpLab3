using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Office : Place
    {
        public double toilet_area {  get; set; }
        public Office(double length, double width, double height, double toilet_area) : base(length, width, height)
        {
            if (toilet_area < 1)
            {
                throw new ArgumentException($"Площадь санузла не может быть меньше 1 квадратного метра{toilet_area}");
            }
            this.toilet_area = toilet_area;
        }
        public override double GetArea()
        {
            return base.GetArea() + this.toilet_area;
        }
    }
}
