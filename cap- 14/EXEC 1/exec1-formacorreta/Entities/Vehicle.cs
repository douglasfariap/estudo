using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec1_formacorreta.Entities {
    class Vehicle {
        public string model { get; private set; }

        public Vehicle(string model)
        {
            this.model = model;
        }
    }
}
