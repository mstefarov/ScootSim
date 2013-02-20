namespace ScootSim {
    class BattlecruiserInfo : UnitInfo {
        const int BaseSpeed = 10000;

        public override UnitType Type {
            get { return UnitType.Battlecruiser; }
        }

        public override string Name {
            get { return "Battlecruiser"; }
        }

        public override int WeaponPower {
            get { return 700; }
        }

        public override int ShieldPower {
            get { return 400; }
        }

        public override int StructuralIntegrity {
            get { return 70000; }
        }

        public override int Capacity {
            get { return 750; }
        }

        public override Res Cost {
            get { return new Res( 30000, 40000, 15000 ); }
        }

        public override int Value {
            get { return 85; }
        }


        public override int GetRapidFire( UnitType target ) {
            switch( target ) {
                case UnitType.EspProbe:
                case UnitType.SolarSat:
                    return 5;
                case UnitType.SmallCargo:
                case UnitType.LargeCargo:
                    return 3;
                case UnitType.HeavyFighter:
                case UnitType.Cruiser:
                    return 4;
                case UnitType.Battleship:
                    return 7;
                default:
                    return 1;
            }
        }


        public override int GetBaseSpeed( Player player ) {
            return BaseSpeed;
        }


        public override int GetActualSpeed( Player player ) {
            return (int)(BaseSpeed*(1 + player.HyperTech*.3m));
        }


        public override int GetFuelConsumption( Player player ) {
            return 250;
        }
    }
}