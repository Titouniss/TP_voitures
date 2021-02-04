namespace TP_01_BLOC2
{
    internal class Voiture
    {
        private string marque;
        private string couleur;
        private string matricule;
        private int chevaux;
        private int numero;
        private static int autoincrementation = 0;

        public Voiture()
        {
            autoincrementation++;
            this.numero = autoincrementation;
        }

        public Voiture(string marq, string coul, string mat, int chev)
        {
            this.marque = marq;
            this.couleur = coul;
            this.matricule = mat;
            this.chevaux = chev;
            autoincrementation++;
            this.numero = autoincrementation;
        }

        public Voiture(string mat)
        {
            this.matricule = mat;
        }

        public string GetMarque()
        {
            return this.marque;
        }

        public string GetCouleur()
        {
            return this.couleur;
        }

        public string GetMatricule()
        {
            return this.matricule;
        }

        public int GetChevaux()
        {
            return this.chevaux;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetMarque(string marque)
        {
            this.marque = marque;
        }

        public void SetCouleur(string couleur)
        {
            this.couleur = couleur;
        }

        public void SetMatricule(string matricule)
        {
            this.matricule = matricule;
        }

        public void SetChevaux(int chevaux)
        {
            this.chevaux = chevaux;
        }

        public string presentation()
        {
            string resultat = "la voiture est de la marque " + this.marque;
            resultat += "  sa couleur est " + this.couleur;
            resultat += "  son matricule est le :" + this.matricule;
            resultat += "  elle possède " + this.chevaux + " chevaux "; 
            return resultat;
        }
    }
}