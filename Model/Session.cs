using System.Collections.Generic;

namespace ScootSim {
    class Session {
        public readonly Universe Universe = new Universe();
        public Coord PlanetCoord;
        public string PlanetName = "";
        public Res Resources;

        public readonly List<Player> Attackers = new List<Player>();
        public readonly List<Player> Defenders = new List<Player>();
    }
}