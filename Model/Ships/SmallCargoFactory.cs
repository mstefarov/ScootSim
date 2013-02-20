namespace ScootSim {
    class SmallCargoFactory : UnitFactory {
        public override UnitType Type {
            get { return UnitType.SmallCargo; }
        }

        public override string Name {
            get { return "Small Cargo"; }
        }

        public override int BaseWeapons {
            get { return 5; }
        }

        public override int BaseShield {
            get { return 10; }
        }

        public override int BaseArmor {
            get { return 4000; }
        }

        public override int Capacity {
            get { return 5000; }
        }

        public override int Value {
            get { return 4; }
        }


        public override int GetRapidFire( UnitType target ) {
            switch( target ) {
                case UnitType.EspProbe:
                case UnitType.SolarSat:
                    return 5;
                default:
                    return 1;
            }
        }


        public override int GetBaseSpeed( Player player ) {
            if( player.ImpulseTech >= 5 ) {
                return 10000;
            } else {
                return 5000;
            }
        }


        public override int GetActualSpeed( Player player ) {
            if( player.ImpulseTech >= 5 ) {
                return (int)(10000*(1 + player.ImpulseTech*.2m));
            } else {
                return (int)(5000*(1 + player.CombustTech*.1m));
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