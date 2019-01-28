using System;

namespace TPFermierDu22eSiecle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t╔═══════════════════════════════════════╗\n" +
                          "\t║                                       ║\n" +
                          "\t║                                       ║\n" +
                          "\t║         Welcome in Futur Farm         ║\n" +
                          "\t║                                       ║\n" +
                          "\t║                                       ║\n" +
                          "\t╚═══════════════════════════════════════╝\n");

            Console.WriteLine("Nous sommes en 2110, et vous allez devoir vous occuper d'une ferme ..\n" + "Avant de commencer nous allons personnaliser votre expérience: \n");

            
            Console.Write("Quel est le prénom de votre héros ? ");
            Humain Homme = new Humain(Console.ReadLine());

            Console.Write("Quel est le nom de sa femme? ");
            Humain Femme = new Humain(Console.ReadLine());

                
            Console.Write("\nVous possédez un chien, comment s'appelle-t-il ? ");
            Animal Chien  = new Animal(Console.ReadLine(), "Chien");

            Androide Pepper = new Androide("Pepper");

            Console.WriteLine("\n\tVotre androïde s'appelle " + Pepper.Nom + "\n" + "\tIl effectuera les tâches les plus ingrates pour vous, c'est un alliés précieux.");
            Console.WriteLine("\tAttention, il se décharge tous les jours, pensez à le mettre en charge sinon il ne pourra rien faire!");
            Console.Write("\n\n\n");
            System.Threading.Thread.Sleep(1000);


            Astre Soleil = new Astre("Soleil");
            Astre Lune = new Astre("Lune");

            Plante Cerisier = new Plante("Cerisier");
            Plante Choux = new Plante("Choux");
            Plante Abricotier = new Plante("Abricotier");
            Plante Mais = new Plante("Mais");

            Animal Dindon = new Animal ("Glouglou", "Dindon");
            Animal Chevre = new Animal("Beeee", "Chevre");

            Objet Table = new Objet("Table");
            Objet Couteau = new Objet("Couteau");
            Objet seau = new Objet("seau");


            #region     Histoire

            while (Matin.nbJours < 7)
            {
                switch (Matin.nbJours)
                {
                    case 0:
                        Soleil.SeLever();
                        Lune.SeCoucher();

                        Matin.InfosDuMatin();

                        Cerisier.Pousser();
                        Choux.Pousser();
                        Dindon.Manger();

                        Homme.Dormir();
                        Chien.Dormir();
                        Soleil.SeCoucher();
                        Lune.SeLever();

                        Console.Write("****************************************************************************************");
                        Console.Write("\n\n\n");
                        break;

                    case 1:
                        Soleil.SeLever();
                        Lune.SeCoucher();

                        Matin.InfosDuMatin();

                        Homme.PrendreObjet(Couteau);
                        Dindon.Mourir();

                        Chien.Manger();

                        Mais.Pousser();
                        Abricotier.Pousser();

                        Cerisier.Fleurir();
                        Choux.Fleurir();

                        Chevre.Manger();

                        Homme.Dormir();
                        Chien.Dormir();
                        Soleil.SeCoucher();
                        Lune.SeLever();
                        Console.Write("****************************************************************************************");
                        Console.Write("\n\n\n");
                        break;

                    case 2:
                        Soleil.SeLever();
                        Lune.SeCoucher();

                        Matin.InfosDuMatin();

                        Cerisier.Produire();
                        Mais.Produire();
                        Choux.Produire();

                        Homme.Recolter();

                        Pepper.PrendreObjet(seau);
                        Pepper.Recolter();

                        Femme.Manger();

                        Chevre.Mourir();
                        Console.WriteLine("Etrange, la chèvre etait en pleine forme hier");

                        Homme.Dormir();
                        Chien.Dormir();
                        Soleil.SeCoucher();
                        Lune.SeLever();
                        Console.Write("****************************************************************************************");
                        Console.Write("\n\n\n");
                        break;

                    case 3:
                        Soleil.SeLever();
                        Lune.SeCoucher();

                        Matin.InfosDuMatin();

                        Abricotier.Fleurir();

                        Pepper.Recolter();

                        Chien.Mourir();
                        Console.WriteLine("Les analyse sont formelles, un virus inconnu est arrivé!");

                        Cerisier.Fleurir();

                        Pepper.Charger();

                        Homme.Manger();
                        Homme.Dormir();
                        Femme.Dormir();
                        Soleil.SeCoucher();
                        Lune.SeLever();
                        Console.Write("****************************************************************************************");
                        Console.Write("\n\n\n");
                        break;

                    case 4:
                        Soleil.SeLever();
                        Lune.SeCoucher();

                        Matin.InfosDuMatin();

                        Choux.Mourir();
                        Cerisier.Mourir();

                        Abricotier.Produire();

                        Pepper.Recolter();

                        Homme.Dormir();
                        
                        Soleil.SeCoucher();
                        Lune.SeLever();
                        Console.Write("****************************************************************************************");
                        Console.Write("\n\n\n");
                        break;

                    case 5:
                        Soleil.SeLever();
                        Lune.SeCoucher();

                        Matin.InfosDuMatin();

                        Abricotier.Mourir();
                        Femme.Mourir();

                        Homme.Dormir();

                        Pepper.Charger();

                        Soleil.SeCoucher();
                        Lune.SeLever();
                        Console.Write("****************************************************************************************");
                        Console.Write("\n\n\n");
                        break;

                    case 6:
                        Soleil.SeLever();
                        Lune.SeCoucher();

                        Matin.InfosDuMatin();

                        Console.WriteLine("Pepper, il n'y plus rien à récolter...");

                        Homme.Mourir();
                        
                        Soleil.SeCoucher();
                        Lune.SeLever();
                        Console.Write("****************************************************************************************");
                        Console.Write("\n\n\n");
                        break;

                        
                }
            }

            Console.WriteLine("\tIl n'y a plus d'humains en vie... La ferme est abandonée et Pepper ne sait plus quoi faire!! C'est la catastrophe!\n");

            #endregion

        }
    }
}
