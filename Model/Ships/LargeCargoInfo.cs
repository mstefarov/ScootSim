namespace ScootSim {
    class LargeCargoInfo : ShipUnitInfo {
        const int BaseSpeed = 7500;

        public override UnitType Type {
            get { return UnitType.LargeCargo; }
        }

        public override int WeaponPower {
            get { return 5; }
        }

        public override int ShieldPower {
            get { return 25; }
        }

        public override int StructuralIntegrity {
            get { return 12000; }
        }

        public override int Capacity {
            get { return 25000; }
        }

        public override Res Cost {
            get { return new Res( 6000, 6000, 0 ); }
        }

        public override int Value {
            get { return 3; } // (6+6) * 25%
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