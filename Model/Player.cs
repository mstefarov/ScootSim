using System.Collections.Generic;

namespace ScootSim {
    class Player {
        public Coord Coordinate;
        public string Name;
        public int WeaponTech, ShieldTech, ArmorTech;
        public int CombustTech, ImpulseTech, HyperTech;
        public int FleetSpeed; // 1-10
        public Dictionary<UnitType, int> UnitTypes;
    }
}