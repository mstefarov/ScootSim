namespace ScootSim {
    struct Res {
        public long Metal, Crystal, Deut;

        public Res( long metal, long crystal, long deut ) {
            Metal = metal;
            Crystal = crystal;
            Deut = deut;
        }

        public Res GetMultiple( long multiplier ) {
            return new Res( Metal*multiplier/100, Crystal*multiplier/100, Deut*multiplier/100 );
        }
    }
}