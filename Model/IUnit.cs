using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScootSim {
    interface IUnit {
        int Shield { get; set; }
        int Armor { get; set; }
        int Weapons { get; set; }
    }
}
