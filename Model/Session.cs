using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScootSim {
    class Session {
        public Coord PlanetCoord;
        public string PlanetName;
        public Res Resources;

        public Res Plunder {
            get {
                return Resources.GetMultiple( Universe.Plunder );
            }
        }
    }
}
