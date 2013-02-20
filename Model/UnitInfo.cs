using System.Collections.Generic;

namespace ScootSim {
    abstract class UnitInfo {
        public abstract UnitType Type { get; }
        public abstract int WeaponPower { get; }
        public abstract int ShieldPower { get; }
        public abstract int StructuralIntegrity { get; }
        public abstract int Capacity { get; }
        public abstract Res Cost { get; }
        public abstract int Value { get; }


        public abstract int GetRapidFire( UnitType target );
        public abstract int GetBaseSpeed( Player player );
        public abstract int GetActualSpeed( Player player );
        public abstract int GetFuelConsumption( Player player );


        public Unit[] MakeUnits( Player player, int count ) {
            int actualArmor = GetHull( player.ArmorTech );
            int actualShield = GetShield( player.ShieldTech );
            Unit[] units = new Unit[count];
            for( int i = 0; i < count; i++ ) {
                units[i].Armor = actualArmor;
                units[i].Shield = actualShield;
            }
            return units;
        }


        public int GetHull( int armorTech ) {
            return (int)((StructuralIntegrity / 10m) * (1 + armorTech * .1m));
        }


        public int GetWeapons( int weaponTech ) {
            return (int)(WeaponPower * (1 + weaponTech * .1m));
        }


        public int GetShield( int shieldTech ) {
            return (int)(ShieldPower * (1 + shieldTech * .1m));
        }


        static readonly Dictionary<UnitType, UnitInfo> Factories = new Dictionary<UnitType, UnitInfo>();

        static UnitInfo() {
            RegisterType( new LightFighterInfo() );
            RegisterType( new HeavyFighterInfo() );
            RegisterType( new CruiserInfo() );
            RegisterType( new BattleshipInfo() );
            RegisterType( new BattlecruiserInfo() );
            RegisterType( new BomberInfo() );
            RegisterType( new DestroyerInfo() );
            RegisterType( new DeathstarInfo() );

            RegisterType( new SmallCargoInfo() );
            RegisterType( new LargeCargoInfo() );
            RegisterType( new ColonyShipInfo() );
            RegisterType( new RecyclerInfo() );
            RegisterType( new EspProbeInfo() );

            RegisterType( new RocketLauncherInfo() );
            RegisterType( new LightLaserInfo() );
            RegisterType( new HeavyLaserInfo() );
            RegisterType( new GaussCannonInfo() );
            RegisterType( new IonCannonInfo() );
            RegisterType( new PlasmaTurretInfo() );
            RegisterType( new SmallShieldDomeInfo() );
            RegisterType( new LargeShieldDomeInfo() );

            RegisterType( new SolarSatInfo() );
        }


        static void RegisterType( UnitInfo info ) {
            Factories.Add( info.Type, info );
        }


        public static UnitInfo GetInfo( UnitType type ) {
            return Factories[type];
        }
    }
}