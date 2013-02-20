namespace ScootSim {
    class DestroyerInfo : UnitInfo {
        const int BaseSpeed = 5000;

        public override UnitType Type {
            get { return UnitType.Destroyer; }
        }

        public override string Name {
            get { return "Destroyer"; }
        }

        public override int WeaponPower {
            get { return 2000; }
        }

        public override int ShieldPower {
            get { return 500; }
        }

        public override int StructuralIntegrity {
            get { return 110000; }
        }

        public override int Capacity {
            get { return 2000; }
        }

        public override Res Cost {
            get { return new Res( 60000, 50000, 15000 ); }
        }

        public override int Value {
            get { return 125; }
        }


        public override int GetRapidFire( UnitType target ) {
            switch( target ) {
                case UnitType.EspProbe:
                case UnitType.SolarSat:
                    return 5;
                case UnitType.LightLaser:
                    return 10;
                case UnitType.Battlecruiser:
                    return 2;
                default:
                    return 1;
            }
        }


        public override int GetBaseSpeed( Player player ) {
            return BaseSpeed;
        }


        public override int GetActualSpeed( Player player ) {
            return (int)(BaseSpeed*(1 + player.HyperTech*.3m));
        }


        public override int GetFuelConsumption( Player player ) {
            return 1000;
        }
    }
}