using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3.Vehicles
{
    internal class Bus:Transport
    {
        public override string move()
        {
            return $"The bus moves with the speed: {speed}";
        }
        public Bus(double speed, string name, int id, double power, int places)
        {
            this.speed = speed;
            this.name = name;
            this.id = id;
            this.power = power;
            this.places = places;
        }
    }
}
