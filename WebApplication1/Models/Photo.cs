using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Photo
    {
        private string titre;
        private int cle;
        private string url;
        private int vues;
        public Photo()
        {
            titre = url = String.Empty;
            vues = 0;

        }
        public Photo(int cle, string titre, string url)
        {
            this.cle = cle;
            this.titre = titre;
            this.url = url;
            this.vues = 0;
        }
        public void AugmenterLesVues()
        {
            vues++;
        }
        public string GetTitre2() => titre;
        public int Cle => cle;
        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Titre trop court");
                }
                titre = value;
            }
        }
        public int Vues => vues;
        public string UrlHttps
        {
            get
            {
                return $"https://{url}";
            }
        }
    }
}