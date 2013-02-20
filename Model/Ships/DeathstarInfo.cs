namespace ScootSim {
    class DeathstarInfo : UnitInfo {
        const int BaseSpeed = 100;

        public override UnitType Type {
            get { return UnitType.Deathstar; }
        }

        public override int WeaponPower {
            get { return 200000; }
        }

        public override int ShieldPower {
            get { return 50000; }
        }

        public override int StructuralIntegrity {
            get { return 9000000; }
        }

        public override int Capacity {
            get { return 1000000; }
        }

        public override Res Cost {
            get { return new Res( 5000000, 4000000, 1000000 ); }
        }

        public override int Value {
            get { return 10000; }
        }


        public override int GetRapidFire( UnitType target ) {
            switch( target ) {
                case UnitType.EspProbe:
                case UnitType.SolarSat:
                    return 1250;
                case UnitType.SmallCargo:
                case UnitType.LargeCargo:
                case UnitType.ColonyShip:
                case UnitType.Recycler:
                    return 250;
                case UnitType.LightFighter:
                case UnitType.RocketLauncher:
                case UnitType.LightLaser:
                    return 200;
                case UnitType.HeavyFighter:
                case UnitType.HeavyLaser:
                case UnitType.IonCannon:
                    return 100;
                case UnitType.GaussCannon:
                    return 50;
                case UnitType.Cruiser:
                    return 33;
                case UnitType.Battleship:
                    return 30;
                case UnitType.Bomber:
                    return 25;
                case UnitType.Battlecruiser:
                    return 15;
                case UnitType.Destroyer:
                    return 5;
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
            return 1;
        }
    }
}