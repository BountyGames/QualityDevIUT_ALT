namespace Exo1.Properties
{
    public class CD : Media
    {
        string artiste;
        int nombre_pistes;

        public CD(string titre, int numeroReference, int nombreExemplaires, string artiste, int nombrePistes) : base(titre, numeroReference, nombreExemplaires)
        {
            this.artiste = artiste;
            nombre_pistes = nombrePistes;
        }

        public void AfficherInfos()
        {
            base.AfficherInfos();
            System.Console.WriteLine($"Artiste : {artiste}");
            System.Console.WriteLine($"Nombre de pistes : {nombre_pistes}");
        }
    }
}