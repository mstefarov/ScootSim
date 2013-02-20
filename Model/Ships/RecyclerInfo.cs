﻿namespace ScootSim {
    class RecyclerInfo : UnitInfo {
        const int BaseSpeed = 7500;

        public override UnitType Type {
            get { return UnitType.Recycler; }
        }

        public override string Name {
            get { return "Recycler"; }
        }

        public override int BaseWeapons {
            get { return 1; }
        }

        public override int BaseShield {
            get { return 10; }
        }

        public override int BaseArmor {
            get { return 16000; }
        }

        public override int Capacity {
            get { return 20000; }
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