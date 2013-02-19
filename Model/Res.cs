namespace ScootSim {
    struct Res {
        public int Metal, Crystal, Deut;

        public Res( int metal, int crystal, int deut ) {
            Metal = metal;
            Crystal = crystal;
            Deut = deut;
        }

        public Res GetMultiple( int multiplier ) {
            return new Res( Metal*multiplier/100, Crystal*multiplier/100, Deut*multiplier/100 );
        }
    }
}