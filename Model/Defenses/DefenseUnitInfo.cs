using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScootSim {
    abstract class DefenseUnitInfo : UnitInfo {
        public override int GetRapidFire( UnitType target ) {
            return 1;
        }

        public override int Capacity {
            get { return 0; }
        }

        public override int Value {
            get { return 0; }
        }

        public override int GetBaseSpeed( Player player ) {
            return 0;
        }

        public override int GetActualSpeed( Player player ) {
            return 0;
        }

        public override int GetFuelConsumption( Player player ) {
            return 0;
        }
    }
}
