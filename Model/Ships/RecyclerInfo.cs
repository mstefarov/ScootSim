namespace ScootSim {
    class RecyclerInfo : UnitInfo {
        const int BaseSpeed = 7500;

        public override UnitType Type {
            get { return UnitType.Recycler; }
        }

        public override string Name {
            get { return "Recycler"; }
        }

        public override int WeaponPower {
            get { return 1; }
        }

        public override int ShieldPower {
            get { return 10; }
        }

        public override int StructuralIntegrity {
            get { return 16000; }
        }

        public override int Capacity {
            get { return 20000; }
        }

        public override Res Cost {
            get { return new Res( 10000, 6000, 2000 ); }
        }

        public override int Value {
            get { return 4; } // (6+6) * 25%
        }


        public override int GetBaseSpeed( Player player ) {
            return BaseSpeed;
        }


        public override int GetActualSpeed( Player player ) {
            return (int)(BaseSpeed*(1 + player.CombustTech*.1m));
        }


        public override int GetFuelConsumption( Player player ) {
            return 50;
        }
    }
}