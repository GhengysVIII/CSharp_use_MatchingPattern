using System;

namespace use_MatchingPattern {
    class Program {

        /*
         * Le pattern Matching permet depuis la version C# 7 
         * de controler le type d'un objet dans une condition
         */

        static void Main(string[] args) {
            Traitement2("En fait.. c'est du texte !"); // texte
            Traitement2("Alors là j'espere que ça fonctionnera !"); // Commence par un A
            Traitement2(3); // < 10
            Traitement2(13); // >= 10 et <= 20
            Traitement2(23); // > 20
            Traitement2(3.1); // nombre 
        }

        static void Traitement2(object x) {
            // avec un switch
            switch (x) {
                case string s when (s[0].ToString().ToLower() == "a"):
                    Console.WriteLine("Texte qui commence par un A !");
                    break;
                case string s:
                    Console.WriteLine("texte !");
                    break;
                case int i when i < 10:
                    Console.WriteLine("nombre < 10 !");
                    break;

                case int i when (i >= 10 && i <= 20):
                    Console.WriteLine("nombre entre 10 et 20 !");
                    break;
                case int i when (i > 20):
                    Console.WriteLine("nombre > 20 !");
                    break;
                default:
                    Console.WriteLine("Alors là.. tu me pose une colle !");
                    break;
            }
            Console.WriteLine(x.GetType());

        }

        static void Traitement1(object x) {
            // Motifs constants
            if (x is 4) Console.WriteLine("x is 4");
            if (x is 6) Console.WriteLine("x is 6");
            // Motifs type
            if (x is string s) Console.WriteLine("x is string s");
            if (x is int i) Console.WriteLine("x is int i");
            // Motif d'assignation
            if (x is var v) Console.WriteLine("x is var v");

        }



    }
}
