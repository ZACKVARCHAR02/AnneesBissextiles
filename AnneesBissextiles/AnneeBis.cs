namespace AnneesBissextiles
{
    public class AnneeBis
    {
        public static Predicate<int> EstBissextile => annee =>
        {
            if (annee == 0) throw new ArgumentOutOfRangeException(nameof(annee), "L'année doit etre strictement positive.");

            return (annee % 400 == 0) || (annee % 4 == 0 && annee % 100 != 0);
        };


        public static void Main(string[] args)
        {
            Console.WriteLine("Année Bissextile");
        }
    }
}
