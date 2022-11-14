namespace JeuduPendule
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //variables importantes
            char lettre = 'n';
            bool partieactive = true; 
            bool jeuxcontinu = true;
            Random aleatoire = new Random();
            char lettre1 = '*';
            char lettre2 = '*';
            char lettre3 = '*';
            char lettre4 = '*';
            char lettre5 = '*';
            char lettre6 = '*';


            //string
            string messagehistorique = "Vous avez essayer les lettres suivantes = ";
            string messagelettre = "Veuillez écrire une lettre";
            string depart = "Bonjour bienvenue au jeux du pendu, devine un mots aleatoire de 6 lettres avant que le pendu soit complet";
            string espace = "---------------------------------------------------------------------------------------------------------";
            string historiquelettre = "";


            //Vies du joueurs
            int compteurdecoups = 0;
            string pendue1 = "Raté! \n (";
            string pendue2 = "Raté! \n (^";
            string pendue3 = "Raté! \n (^O";
            string pendue4 = "Raté! \n (^O^";
            string pendue5 = "Raté! \n (^O^) \n Tu as perdu";

            //Le Programme demarre
            Console.WriteLine(depart);
            Console.WriteLine(espace);

            //Liste de mots disponibles + choix du mot
            int randomnumber = 0;
            string[] tableaumots =
                {"melons","lemons","citron","orange","grapes"};

            randomnumber = aleatoire.Next(0, tableaumots.Length);
            string motsadeviner = tableaumots[randomnumber];




            while (partieactive)
            {
                for (int j = 0; j < motsadeviner.Length; j++)
                {
                    Console.Write("* ");
                }

                int i = 0;

                while (jeuxcontinu)
                {
                    Console.WriteLine("\n" + messagelettre);
                    

                    

                    if (historiquelettre == "")
                    {
                       
                    }
                    else
                    {
                        Console.WriteLine(messagehistorique + historiquelettre);
                    }
                    lettre = Console.ReadLine()[0];

                    historiquelettre = historiquelettre + "" + lettre + " ";

                    if (motsadeviner.Contains(lettre))
                    {

                        if (lettre1 == '*')
                        {
                            if (motsadeviner[0] == lettre)
                            {
                                lettre1 = lettre;
                                Console.Write(lettre1);
                            }
                            else
                            {
                                 
                                Console.Write("*" + "");
                            }

                        }
                        else
                        {
                            
                            Console.Write(lettre1);
                        }

                        if (lettre2 == '*')
                        {
                            if (motsadeviner[1] == lettre)
                            {
                                lettre2 = lettre;
                                Console.Write(lettre2);
                            }
                            else
                            {

                                Console.Write("*"+"");
                            }
                        }
                        else
                        {
                            Console.Write(lettre2);
                        }
                        if (lettre3 == '*')
                        {
                            if (motsadeviner[2] == lettre)
                            {
                                lettre3 = lettre;
                                Console.Write(lettre3);
                            }
                            else
                            {

                                Console.Write("*" + "" );
                            }
                        }
                        else
                        {
                            Console.Write(lettre3);
                        }
                        if (lettre4 == '*')
                        {
                            if (motsadeviner[3] == lettre)
                            {
                                lettre4 = lettre;
                                Console.Write(lettre4);
                            }
                            else
                            {

                                Console.Write("*" + "");
                            }
                        }
                        else
                        {
                            Console.Write(lettre4);
                        }
                        if (lettre5 == '*')
                        {
                            if (motsadeviner[4] == lettre)
                            {
                                lettre5 = lettre;
                                Console.Write(lettre5);
                            }
                            else
                            {

                                Console.Write("*" + "");
                            }
                        }
                        else
                        {
                            Console.Write(lettre5);
                        }
                        if (lettre6 == '*')
                        {
                            if (motsadeviner[5] == lettre)
                            {
                                lettre6 = lettre;
                                Console.Write(lettre6);
                            }
                            else
                            {

                                Console.Write("*" + "");
                            }
                        }
                        else
                        {
                            Console.Write(lettre6);
                        }

                        if (lettre1 != '*' && lettre2 != '*' && lettre3 != '*' && lettre4 != '*' && lettre5 != '*' && lettre6 != '*')
                        {
                            jeuxcontinu=false;
                        }


                    }
                    else
                    {
                        compteurdecoups++;
                        i = i + 1;

                        if (compteurdecoups == 1)
                        {
                            Console.WriteLine(pendue1);
                        }
                        else if (compteurdecoups == 2)
                        {
                            Console.WriteLine(pendue2);
                        }
                        else if (compteurdecoups == 3)
                        {
                            Console.WriteLine(pendue3);
                        }
                        else if (compteurdecoups == 4)
                        {
                            Console.WriteLine(pendue4);
                        }
                        else if (compteurdecoups == 5)
                        {
                            Console.WriteLine(pendue5);
                            jeuxcontinu=false;

                        }


                    }




                }

                if (compteurdecoups != 5)
                {
                    Console.WriteLine("\n" + "Vous avez trouvé le mot était bien : " + motsadeviner);
                    partieactive = false;
                }

                else
                {
                    Console.WriteLine("\n"+"Vous avez perdu le mot était : " + motsadeviner);
                    partieactive = false;
                }

            }
        }
    }
}