using System;

namespace ScootSim {
    struct Coord : IEquatable<Coord> {
        public Coord( int galaxy, int system, int planet ) {
            Galaxy = galaxy;
            System = system;
            Planet = planet;
        }

        public int Galaxy;
        public int System;
        public int Planet;


        public int DistanceTo( Coord other ) {
            if( Equals( other ) ) {
                return 5;
            } else if( Galaxy == other.Galaxy && System == other.System ) {
                return 1000 + 5*Math.Abs( Planet - other.Planet );
            } else if( other.Galaxy == Galaxy ) {
                return 2700 + 95*Math.Abs( System - other.System );
            } else {
                return 20000*Math.Abs( Galaxy - other.Galaxy );
            }
        }


        public bool Equals( Coord other ) {
            return Galaxy == other.Galaxy &&
                   System == other.System &&
                   Planet == other.Planet;
        }


        public override bool Equals( object obj ) {
            if( ReferenceEquals( null, obj ) ) {
                return false;
            }
            return obj is Coord && Equals( (Coord)obj );
        }


        public override int GetHashCode() {
            unchecked {
                // ReSharper disable NonReadonlyFieldInGetHashCode
                int hashCode = Galaxy;
                hashCode = (hashCode*397) ^ System;
                hashCode = (hashCode*397) ^ Planet;
                // ReSharper restore NonReadonlyFieldInGetHashCode
                return hashCode;
            }
        }


        public override string ToString() {
            return String.Format( "{0}:{1}:{2}", Galaxy, System, Planet );
        }
    }
}