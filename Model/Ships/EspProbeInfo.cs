namespace ScootSim {
    class EspProbeInfo : UnitInfo {
        const int BaseSpeed = 100000000;

        public override UnitType Type {
            get { return UnitType.EspProbe; }
        }

        public override string Name {
            get { return "Esp Probe"; }
        }

        public override int BaseWeapons {
            get { return 0; }
        }

        public override int BaseShield {
            get { return 0; }
        }

        public override int BaseArmor {
            get { return 1000; }
        }

        public override int Capacity {
            get { return 0; }
        }

        public override int Value {
            get { return 1; }
        }


        public override int GetBaseSpeed( Player player ) {
            return BaseSpeed;
        }


        public override int GetActualSpeed( Player player ) {
            return (int)(BaseSpeed*(1 + player.CombustTech*.1m));
        }


        public override int GetFuelConsumption( Player player ) {
            return 1;
        }
    }
}