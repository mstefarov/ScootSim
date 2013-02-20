namespace ScootSim {
    class PlasmaTurretInfo : DefenseUnitInfo {
        public override UnitType Type {
            get { return UnitType.PlasmaTurret; }
        }

        public override int WeaponPower {
            get { return 3000; }
        }

        public override int ShieldPower {
            get { return 300; }
        }

        public override int StructuralIntegrity {
            get { return 100000; }
        }

        public override Res Cost {
            get { return new Res( 50000, 50000, 30000 ); }
        }
    }
}