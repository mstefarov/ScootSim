namespace ScootSim {
    class LightLaserInfo : DefenseUnitInfo {
        public override UnitType Type {
            get { return UnitType.LightLaser; }
        }

        public override int WeaponPower {
            get { return 100; }
        }

        public override int ShieldPower {
            get { return 25; }
        }

        public override int StructuralIntegrity {
            get { return 2000; }
        }

        public override Res Cost {
            get { return new Res( 1500, 500, 0 ); }
        }
    }
}