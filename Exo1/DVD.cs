namespace Exo1
{
    public class DVD : Media
    {
        string realisateur;
        int duree;

        public DVD(string titre, int numeroReference, int nombreExemplaires, string realisateur, int duree) : base(titre, numeroReference, nombreExemplaires)
        {
            this.realisateur = realisateur;
            this.duree = duree;
        }

        public void AfficherInfos()
        {
            base.AfficherInfos();
            System.Console.WriteLine($"Realisateur : {realisateur}");
            System.Console.WriteLine($"Duree : {duree}");
        }
    }
}