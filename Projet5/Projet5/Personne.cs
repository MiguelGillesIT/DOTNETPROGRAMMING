using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet5
{
    class Personne
    {
        private string cin; 
        private string nom; 
        private string prenom; 
        private string ville; 
        private string tel; 
        private int age;
        public string CIN
        {
            get { return cin; }
            set { cin = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
