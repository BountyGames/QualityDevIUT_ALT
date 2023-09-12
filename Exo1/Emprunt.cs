using System;

namespace Exo1
{
    public class Emprunt
    {
        public Media media {get; set;}
        private string nom;
        private string prenom;
        private DateTime dateEmprunt;
        private DateTime dateRetour;
        public bool rendu { get; set;}
        
        public Emprunt(Media media, string nom, string prenom)
        {
            this.media = media;
            this.nom = nom;
            this.prenom = prenom;
            dateEmprunt = DateTime.Now;
            dateRetour = dateEmprunt.AddDays(15);
            rendu = false;
        }
        
        public void Rendre()
        {
            if (!rendu)
            {
                rendu = true;
            }
        }
        
        public void toString()
        {
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"Prenom : {prenom}");
            Console.WriteLine($"Date d'emprunt : {dateEmprunt}");
            Console.WriteLine($"Date de retour : {dateRetour}");
            media.AfficherInfos();
        }
    }
}