namespace ScootSim {
    class LargeShieldDomeInfo : DefenseUnitInfo {
        public override UnitType Type {
            get { return UnitType.LargeShieldDome; }
        }

        public override int WeaponPower {
            get { return 1; }
        }

        public override int ShieldPower {
            get { return 10000; }
        }

        public override int StructuralIntegrity {
            get { return 100000; }
        }

        public override Res Cost {
            get { return new Res( 50000, 50000, 0 ); }
        }
    }
}