namespace ScootSim {
    class LargeCargoFactory : UnitFactory {
        public override UnitType Type {
            get { return UnitType.LargeCargo; }
        }

        public override string Name {
            get { return "Large Cargo"; }
        }

        public override int BaseWeapons {
            get { return 5; }
        }

        public override int BaseShield {
            get { return 25; }
        }

        public override int BaseArmor {
            get { return 12000; }
        }

        public override int Capacity {
            get { return 25000; }
        }

        public override int Value {
            get { return 12; }
        }


        public override int GetRapidFire( UnitType target ) {
            switch( target ) {
                case UnitType.EspProbe:
                case UnitType.SolarSat:
                    return 5;
                default:
                    return 1;
            }
        }


        public override int GetBaseSpeed( Player player ) {
            return 7500;
        }


        public override int GetActualSpeed( Player player ) {
            return (int)(7500*(1 + player.CombustTech*.1m));
        }


        public override int GetFuelConsumption( Player player ) {
            return 50;
        }
    }
}