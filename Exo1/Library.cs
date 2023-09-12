using System.Collections.Generic;

namespace Exo1
{
    public class Library
    {
        public List <Media> medias = new List<Media>();
        public List <Emprunt> emprunts = new List<Emprunt>();
        
        public Media this[int numeroReference]
        {
            get
            {
                foreach (Media media in medias)
                {
                    if (media.numero_reference == numeroReference)
                    {
                        return media;
                    }
                }
                return null;
            }
        }
        
        public void AjoutMedia(Media media)
        {
            medias.Add(media);
        }
        
        public void RetirerMedia(Media media)
        {
            medias.Remove(media);
        }
        
        public void EmpreinterMedia(Media media)
        {
            if (media.nombre_exemplaires > 0)
            {
                media.nombre_exemplaires--;
                emprunts.Add(new Emprunt(media, "Doe", "John"));
            }
        }

        public void RetournerMedia(Emprunt emprunt)
        {
            if (!emprunt.rendu)
            {
                emprunt.Rendre();
                emprunt.media.nombre_exemplaires++;
            }
        }

    }
}