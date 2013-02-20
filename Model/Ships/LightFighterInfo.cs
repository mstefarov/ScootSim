namespace ScootSim {
    class LightFighterInfo : UnitInfo {
        const int BaseSpeed = 12500;

        public override UnitType Type {
            get { return UnitType.LightFighter; }
        }

        public override string Name {
            get { return "Light Fighter"; }
        }

        public override int BaseWeapons {
            get { return 50; }
        }

        public override int BaseShield {
            get { return 10; }
        }

        public override int BaseArmor {
            get { return 4000; }
        }

        public override int Capacity {
            get { return 50; }
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