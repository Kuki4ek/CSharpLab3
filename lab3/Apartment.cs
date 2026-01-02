using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Apartment : Place
    {
        public double toilet_area, bathroom_area, kithen_area, hallway_area;
        public Apartment(double length, double width, double height, double toilet_area, double bathroom_area, double kithen_area, double hallway_area) : base(length, width, height)
        {
            if(toilet_area < 1)
            {
                throw new ArgumentException("Площадь санузла не может быть меньше 1 квадратного метра");
            }
            if (bathroom_area < 1)
            {
                throw new ArgumentException("Площадь ванной комнаты не может быть меньше 1 квадратного метра");
            }
            if (kithen_area < 1)
            {
                throw new ArgumentException("Площадь кухни не может быть меньше 1 квадратного метра");
            }
            if (hallway_area < 1)
            {
                throw new ArgumentException("Площадь прихожей не может быть меньше 1 квадратного метра");
            }
            this.toilet_area = toilet_area;
            this.bathroom_area = bathroom_area;
            this.kithen_area = kithen_area;
            this.hallway_area = hallway_area;
        }
        public override double GetArea()
        {
            return base.GetArea() + this.toilet_area + this.bathroom_area + this.kithen_area + this.hallway_area;
        }
        public override double GetLiveArea()
        {
            return base.GetArea();
        }
    }
}
