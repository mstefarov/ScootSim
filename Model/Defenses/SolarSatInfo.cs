namespace ScootSim {
    class SolarSatInfo : UnitInfo {
        public override UnitType Type {
            get { return UnitType.SolarSat; }
        }

        public override string Name {
            get { return "Solar Satellite"; }
        }

        public override int WeaponPower {
            get { return 1; }
        }

        public override int ShieldPower {
            get { return 1; }
        }

        public override int StructuralIntegrity {
            get { return 2000; }
        }

        public override int Capacity {
            get { return 0; }
        }

        public override Res Cost {
            get { return new Res( 2000, 2000, 0 ); }
        }

        public override int Value {
            get { return 0; }
        }


        public override int GetRapidFire( UnitType target ) {
            return 1;
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