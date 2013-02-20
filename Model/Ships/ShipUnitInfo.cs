using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScootSim {
    abstract class ShipUnitInfo : UnitInfo {
        public override int GetRapidFire( UnitType target ) {
            switch( target ) {
                case UnitType.EspProbe:
                case UnitType.SolarSat:
                    return 5;
                default:
                    return 1;
            }
        }
    }
}
