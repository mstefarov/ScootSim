namespace ScootSim {
    class ColonyShipInfo : UnitInfo {
        const int BaseSpeed = 2500;

        public override UnitType Type {
            get { return UnitType.ColonyShip; }
        }

        public override string Name {
            get { return "Colony Ship"; }
        }

        public override int BaseWeapons {
            get { return 50; }
        }

        public override int BaseShield {
            get { return 100; }
        }

        public override int BaseArmor {
            get { return 30000; }
        }

        public override int Capacity {
            get { return 7500; }
        }

        public override int Value {
            get { return 10; } // (10+20+10) * 25%
        }


        public override int GetBaseSpeed( Player player ) {
            return BaseSpeed;
        }


        public override int GetActualSpeed( Player player ) {
            return (int)(BaseSpeed*(1 + player.ImpulseTech*.2m));
        }


        public override int GetFuelConsumption( Player player ) {
            return 1000;
        }
    }
}