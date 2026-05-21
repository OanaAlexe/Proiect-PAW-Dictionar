namespace REST_1049_ALEXE_OANA
{
    public class Cuvant
    {
        public string Termen { get; set; }
        public string Definitie { get; set; }
        public string Traducere { get; set; }
        public string Limba { get; set; }

        public Cuvant()
        {

        }

        public Cuvant(string termen, string definitie, string traducere, string limba)
        {
            Termen = termen;
            Definitie = definitie;
            Traducere = traducere;
            Limba = limba;
        }
        public override string ToString()
        {
            return $"Termen: {Termen}\nDefinitie: {Definitie}\nTraducere: {Traducere}\nLimba: {Limba}";
        }
    }
}
