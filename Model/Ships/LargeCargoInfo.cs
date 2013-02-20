namespace ScootSim {
    class LargeCargoInfo : UnitInfo {
        const int BaseSpeed = 7500;

        public override UnitType Type {
            get { return UnitType.LargeCargo; }
        }

        public override string Name {
            get { return "Large Cargo"; }
        }

        public override int BaseWeapons {
            get { return 5; }
        }

        public override int BaseShield {
            get { return 25; }
        }

        public override int BaseArmor {
            get { return 12000; }
        }

        public override int Capacity {
            get { return 25000; }
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