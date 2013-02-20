namespace ScootSim {
    class SmallCargoInfo : ShipUnitInfo {
        const int ImpulseSpeed = 10000;
        const int CombustSpeed = 5000;

        public override UnitType Type {
            get { return UnitType.SmallCargo; }
        }

        public override int WeaponPower {
            get { return 5; }
        }

        public override int ShieldPower {
            get { return 10; }
        }

        public override int StructuralIntegrity {
            get { return 4000; }
        }

        public override int Capacity {
            get { return 5000; }
        }

        public override Res Cost {
            get { return new Res( 2000, 2000, 0 ); }
        }

        public override int Value {
            get { return 1; } // (2+2) * 25%
        }


        public override int GetBaseSpeed( Player player ) {
            if( player.ImpulseTech >= 5 ) {
                return ImpulseSpeed;
            } else {
                return CombustSpeed;
            }
        }


        public override int GetActualSpeed( Player player ) {
            if( player.ImpulseTech >= 5 ) {
                return (int)(ImpulseSpeed*(1 + player.ImpulseTech*.2m));
            } else {
                return (int)(CombustSpeed*(1 + player.CombustTech*.1m));
            }
        }


        public override int GetFuelConsumption( Player player ) {
            if( player.ImpulseTech >= 5 ) {
                return 20;
            } else {
                return 10;
            }
        }
    }
}