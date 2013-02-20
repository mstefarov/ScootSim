namespace ScootSim {
    class LightFighterInfo : ShipUnitInfo {
        const int BaseSpeed = 12500;

        public override UnitType Type {
            get { return UnitType.LightFighter; }
        }

        public override int WeaponPower {
            get { return 50; }
        }

        public override int ShieldPower {
            get { return 10; }
        }

        public override int StructuralIntegrity {
            get { return 4000; }
        }

        public override int Capacity {
            get { return 50; }
        }

        public override Res Cost {
            get { return new Res( 3000, 1000, 0 ); }
        }

        public override int Value {
            get { return 4; }
        }


        public override int GetBaseSpeed( Player player ) {
            return BaseSpeed;
        }


        public override int GetActualSpeed( Player player ) {
            return (int)(BaseSpeed*(1 + player.CombustTech*.1m));
        }


        public override int GetFuelConsumption( Player player ) {
            return 20;
        }
    }
}