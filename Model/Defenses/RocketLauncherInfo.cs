namespace ScootSim {
    class RocketLauncherInfo : DefenseUnitInfo {
        public override UnitType Type {
            get { return UnitType.RocketLauncher; }
        }

        public override int WeaponPower {
            get { return 80; }
        }

        public override int ShieldPower {
            get { return 20; }
        }

        public override int StructuralIntegrity {
            get { return 2000; }
        }

        public override Res Cost {
            get { return new Res( 2000, 0, 0 ); }
        }
    }
}