namespace ScootSim {
    class HeavyLaserInfo : DefenseUnitInfo {
        public override UnitType Type {
            get { return UnitType.HeavyLaser; }
        }

        public override int WeaponPower {
            get { return 250; }
        }

        public override int ShieldPower {
            get { return 100; }
        }

        public override int StructuralIntegrity {
            get { return 8000; }
        }

        public override Res Cost {
            get { return new Res( 6000,2000, 0 ); }
        }
    }
}