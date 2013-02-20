namespace ScootSim {
    class IonCannonInfo : DefenseUnitInfo {
        public override UnitType Type {
            get { return UnitType.IonCannon; }
        }

        public override int WeaponPower {
            get { return 150; }
        }

        public override int ShieldPower {
            get { return 500; }
        }

        public override int StructuralIntegrity {
            get { return 8000; }
        }

        public override Res Cost {
            get { return new Res( 2000, 6000, 0 ); }
        }
    }
}