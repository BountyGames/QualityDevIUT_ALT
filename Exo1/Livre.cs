using System;

namespace Exo1
{
    public class Livre : Media
    {
        string auteur;
        string editeur;
        int nombre_pages;

        public Livre(string titre, int numeroReference, int nombreExemplaires, string auteur, string editeur, int nombrePages) : base(titre, numeroReference, nombreExemplaires)
        {
            this.auteur = auteur;
            this.editeur = editeur;
            nombre_pages = nombrePages;
        }

        public void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Auteur : {auteur}");
            Console.WriteLine($"Editeur : {editeur}");
            Console.WriteLine($"Nombre de pages : {nombre_pages}");
        }
    }
}