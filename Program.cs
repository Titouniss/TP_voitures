using System;

namespace TP_01_BLOC2
{
    class Program
    {
        static void Main (string[] args)
            
        {
            Voiture R1 = new Voiture();
            R1.SetMarque("");
            R1.SetCouleur("");
            R1.SetMatricule("");
            R1.SetChevaux(0);
            R1.GetNumero();
            Console.WriteLine(R1.presentation());


            Voiture R2 = new Voiture();
            R2.SetMarque("");
            R2.SetCouleur("");
            R2.SetMatricule("");
            R2.SetChevaux(0);
            R2.GetNumero();
            Console.WriteLine(R2.presentation());

        }
    }
}
