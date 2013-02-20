using System.Collections.Generic;

namespace ScootSim {
    abstract class UnitFactory {
        public abstract UnitType Type { get; }
        public abstract string Name { get; }
        public abstract int BaseWeapons { get; }
        public abstract int BaseShield { get; }
        public abstract int BaseArmor { get; }
        public abstract int Capacity { get; }
        public abstract int Value { get; }
        public abstract int GetRapidFire( UnitType target );
        public abstract int GetBaseSpeed( Player player );
        public abstract int GetActualSpeed( Player player );
        public abstract int GetFuelConsumption( Player player );


        public Unit[] MakeUnits( Player player, int count ) {
            int actualArmor = GetActualStrength( BaseArmor, player.ArmorTech );
            int actualShield = GetActualStrength( BaseShield, player.ShieldTech );
            Unit[] units = new Unit[count];
            for( int i = 0; i < count; i++ ) {
                units[i].Armor = actualArmor;
                units[i].Shield = actualShield;
            }
            return units;
        }


        static readonly Dictionary<UnitType, UnitFactory> Factories = new Dictionary<UnitType, UnitFactory>();

        static UnitFactory() {
            RegisterFactory( new SmallCargoFactory() );
        }


        static void RegisterFactory( UnitFactory factory ) {
            Factories.Add( factory.Type, factory );
        }


        public static UnitFactory GetFactory( UnitType type ) {
            return Factories[type];
        }


        static int GetActualStrength( int baseValue, int techLevel ) {
            return (int)((baseValue)*(1 + techLevel*.1m));
        }
    }
}
