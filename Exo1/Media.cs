using System;

namespace Exo1
{
    public class Media
    {
        string titre { get; set; }
        public int numero_reference { get; set; }
        public int nombre_exemplaires  { get; set; }

        public Media(string titre, int numeroReference, int nombreExemplaires)
        {
            this.titre = titre;
            numero_reference = numeroReference;
            nombre_exemplaires = nombreExemplaires;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Titre : {titre}");
            Console.WriteLine($"Numero de reference : {numero_reference}");
            Console.WriteLine($"Nombre d'exemplaires : {nombre_exemplaires}");
        }
        
        
    }
    
}