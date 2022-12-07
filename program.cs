using System;
using System.Collections.Generic;
using System.Linq;

namespace Pendu
{
    class Program
    {
        static void AfficherLettres(List<char> lettres)
        {
            Console.WriteLine("Lettres choisies :");
            foreach (char lettre in lettres)
            {
                Console.Write(lettre + " ");
            }
            Console.WriteLine();
        }

        static void AfficherMotMasque(string mot, List<char> lettres)
        {
            Console.WriteLine("Mot à deviner :");
            foreach (char c in mot)
            {
                if (lettres.Contains(c))
                {
                    Console.Write(c + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        static void main(string[] args)
        {
            // Définir le mot à deviner et le nombre de tentatives
            string mot = "pendu";
            int nbTentatives = 7;
        }

        // Initialiser la liste des lettres choisies
        List<char> lettres = new List<char>();

        // Démarrer le jeu
        Console.WriteLine("Bienvenue au jeu du pendu !\n");
        Console.WriteLine("Vous avez " + nbTentatives + " tentatives pour deviner le mot suivant :");
        AfficherMotMasque(mot, lettres);

        while (true)
        {
            // Demander à l'utilisateur de choisir une lettre
            Console.Write("Choisissez une lettre : ");

            ConsoleKeyInfo key = Console.ReadKey();
        char lettre = key.KeyChar;
        Console.WriteLine();

            lettre = char.ToLower(lettre);

        lettres.Add(lettre);

            if (lettres.Contains(lettre))
            {
                Console.WriteLine();
                continue;
            }

        AfficherLettres(lettres);

        AfficherMotMasque(mot, lettres);

            // Vérifier si le mot a été deviné
            if (!mot.Any(c => !lettres.Contains(c)))
            {
                Console.WriteLine("Félicitations, vous avez deviné le mot !");
                break;
            }

// Vérifier si le nombre de tentatives est épuisé
if (lettres.Count >= nbTentatives)
{
    Console.WriteLine("Vous avez épuisé toutes vos tentatives. Le mot était : " + mot);
    break;
}
        }
    }
}
}

