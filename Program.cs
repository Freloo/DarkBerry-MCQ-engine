using System;

namespace Darkberry_beta
{
    class Program
    {

        // initialization screen function. 
        // la fonction de l'intro au démarage de l'appli. J'en ai fait une fonction pour alleger le main
        static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Beep(300, 1000);


            Console.WriteLine("MMM              MMM                 CCCCCCC            QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MMMM            MMMM               CCCCCCCCC            QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MM MM          MM MM             CCC                    QQ            QQ");
            Console.WriteLine("MM  MM        MM  MM           CCC                      QQ            QQ");
            Console.WriteLine("MM  MM       MM   MM         CCC                        QQ    QQ      QQ");
            Console.WriteLine("MM   MM     MM    MM       CCC                          QQ     QQ     QQ");
            Console.WriteLine("MM    MM   MM     MM         CCC                        QQ      QQ    QQ");
            Console.WriteLine("MM     MM MM      MM           CCC                      QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MM      MMM       MM             CCC                    QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MM       M        MM               CCCCCCCC                         QQ");
            Console.WriteLine("MM                MM                 CCCCCCC                         QQ\n");

            Console.WriteLine("MMM              MMM                 CCCCCCC            QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MMMM            MMMM               CCCCCCCCC            QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MM MM          MM MM             CCC                    QQ            QQ");
            Console.WriteLine("MM  MM        MM  MM           CCC                      QQ            QQ");
            Console.WriteLine("MM  MM       MM   MM         CCC                        QQ    QQ      QQ");
            Console.WriteLine("MM   MM     MM    MM       CCC                          QQ     QQ     QQ");
            Console.WriteLine("MM    MM   MM     MM         CCC                        QQ      QQ    QQ");
            Console.WriteLine("MM     MM MM      MM           CCC                      QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MM      MMM       MM             CCC                    QQQQQQQQQQQQQQQQ");
            Console.WriteLine("MM       M        MM               CCCCCCCC                         QQ");
            Console.WriteLine("MM                MM                 CCCCCCC                         QQ");
            Console.Beep(300, 200);
            Console.WriteLine("Darkberry beta");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
        // la fonction pour choisir l'activitée ( pas encore finie, j'ajouterais des fonctionalitées, et je crois avoir fai une erreur avec les variales mais je suis pas sur, je rearderais plus tard

        // la fonction pour jouer a un qcm. J'aurais pu ajouter une fonction poour autmatiser le bloc répéter 4 fois en bas mais je le ferais plus tard
        static void Play(string[,,] MCQ, ref int pointsInternes, string[] MCQname)
        {
            bool exit = false;

            static void question(string question, string a, string b, string c, string d, string goodAnswer, ref int pointInterne)
            {
                Console.WriteLine(question);
                Console.WriteLine("A-" + a);
                Console.WriteLine("B-" + b);
                Console.WriteLine("C-" + c);
                Console.WriteLine("D-" + d);
                Console.WriteLine("Enter the letter of the answer (Without caps).");
                string answer = Console.ReadLine();

                if (answer == goodAnswer)
                {
                    Console.WriteLine("This is the good answer!!");
                    pointInterne++;
                    Console.Beep(1000, 100);
                }
                else
                {
                    Console.WriteLine("No, the good answer was the " + goodAnswer);
                    pointInterne--;
                    Console.Beep(250, 1500);
                };

            }





            while (!exit)

            { bool McqIsChose = false;
                while (!McqIsChose)
                {
                    int QCMNumber = -1;
                    Console.WriteLine("Please chose your MCQ. (enter the letter without caps)");
                    Console.WriteLine("a-" + MCQname[0] + "\nb-" + MCQname[1] + " \n c-" + MCQname[2] + "\nd-" + MCQname[3] + "\ne-" + MCQname[4] + "\nf- Menu");
                    string MCQChoice = Console.ReadLine();
                    Console.Clear ();
                    

                   
                    
                        if (MCQChoice == "a")
                        {
                        Console.WriteLine(MCQname[0] + "\n");
                        McqIsChose = true;
                            QCMNumber = 0;
                            question(MCQ[0, QCMNumber, 0], MCQ[1, QCMNumber, 0], MCQ[2, QCMNumber, 0], MCQ[3, QCMNumber, 0], MCQ[4, QCMNumber, 0], MCQ[5, QCMNumber, 0], ref pointsInternes);
                            question(MCQ[0, QCMNumber, 1], MCQ[1, QCMNumber, 1], MCQ[2, QCMNumber, 1], MCQ[3, QCMNumber, 1], MCQ[4, QCMNumber, 1], MCQ[5, QCMNumber, 1], ref pointsInternes);
                            question(MCQ[0, QCMNumber, 2], MCQ[1, QCMNumber, 2], MCQ[2, QCMNumber, 2], MCQ[3, QCMNumber, 2], MCQ[4, QCMNumber, 2], MCQ[5, QCMNumber, 2], ref pointsInternes);
                            question(MCQ[0, QCMNumber, 3], MCQ[1, QCMNumber, 3], MCQ[2, QCMNumber, 3], MCQ[3, QCMNumber, 3], MCQ[4, QCMNumber, 3], MCQ[5, QCMNumber, 3], ref pointsInternes);
                            question(MCQ[0, QCMNumber, 4], MCQ[1, QCMNumber, 4], MCQ[2, QCMNumber, 4], MCQ[3, QCMNumber, 4], MCQ[4, QCMNumber, 4], MCQ[5, QCMNumber, 4], ref pointsInternes);
                        };
                    if (MCQChoice == "b")

                    {
                        Console.WriteLine(MCQname[1] + "\n");
                        McqIsChose = true;
                        QCMNumber = 1;
                        question(MCQ[0, QCMNumber, 0], MCQ[1, QCMNumber, 0], MCQ[2, QCMNumber, 0], MCQ[3, QCMNumber, 0], MCQ[4, QCMNumber, 0], MCQ[5, QCMNumber, 0], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 1], MCQ[1, QCMNumber, 1], MCQ[2, QCMNumber, 1], MCQ[3, QCMNumber, 1], MCQ[4, QCMNumber, 1], MCQ[5, QCMNumber, 1], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 2], MCQ[1, QCMNumber, 2], MCQ[2, QCMNumber, 2], MCQ[3, QCMNumber, 2], MCQ[4, QCMNumber, 2], MCQ[5, QCMNumber, 2], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 3], MCQ[1, QCMNumber, 3], MCQ[2, QCMNumber, 3], MCQ[3, QCMNumber, 3], MCQ[4, QCMNumber, 3], MCQ[5, QCMNumber, 3], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 4], MCQ[1, QCMNumber, 4], MCQ[2, QCMNumber, 4], MCQ[3, QCMNumber, 4], MCQ[4, QCMNumber, 4], MCQ[5, QCMNumber, 4], ref pointsInternes);
                    };
                    if (MCQChoice == "c")
                    {
                        Console.WriteLine(MCQname[2] + "\n");
                        McqIsChose = true;
                        QCMNumber = 2;
                        question(MCQ[0, QCMNumber, 0], MCQ[1, QCMNumber, 0], MCQ[2, QCMNumber, 0], MCQ[3, QCMNumber, 0], MCQ[4, QCMNumber, 0], MCQ[5, QCMNumber, 0], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 1], MCQ[1, QCMNumber, 1], MCQ[2, QCMNumber, 1], MCQ[3, QCMNumber, 1], MCQ[4, QCMNumber, 1], MCQ[5, QCMNumber, 1], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 2], MCQ[1, QCMNumber, 2], MCQ[2, QCMNumber, 2], MCQ[3, QCMNumber, 2], MCQ[4, QCMNumber, 2], MCQ[5, QCMNumber, 2], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 3], MCQ[1, QCMNumber, 3], MCQ[2, QCMNumber, 3], MCQ[3, QCMNumber, 3], MCQ[4, QCMNumber, 3], MCQ[5, QCMNumber, 3], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 4], MCQ[1, QCMNumber, 4], MCQ[2, QCMNumber, 4], MCQ[3, QCMNumber, 4], MCQ[4, QCMNumber, 4], MCQ[5, QCMNumber, 4], ref pointsInternes);
                    };
                    if (MCQChoice == "d")
                    {
                        Console.WriteLine(MCQname[3] + "\n");
                        McqIsChose = true;
                        QCMNumber = 3;
                        question(MCQ[0, QCMNumber, 0], MCQ[1, QCMNumber, 0], MCQ[2, QCMNumber, 0], MCQ[3, QCMNumber, 0], MCQ[4, QCMNumber, 0], MCQ[5, QCMNumber, 0], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 1], MCQ[1, QCMNumber, 1], MCQ[2, QCMNumber, 1], MCQ[3, QCMNumber, 1], MCQ[4, QCMNumber, 1], MCQ[5, QCMNumber, 1], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 2], MCQ[1, QCMNumber, 2], MCQ[2, QCMNumber, 2], MCQ[3, QCMNumber, 2], MCQ[4, QCMNumber, 2], MCQ[5, QCMNumber, 2], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 3], MCQ[1, QCMNumber, 3], MCQ[2, QCMNumber, 3], MCQ[3, QCMNumber, 3], MCQ[4, QCMNumber, 3], MCQ[5, QCMNumber, 3], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 4], MCQ[1, QCMNumber, 4], MCQ[2, QCMNumber, 4], MCQ[3, QCMNumber, 4], MCQ[4, QCMNumber, 4], MCQ[5, QCMNumber, 4], ref pointsInternes);
                    };
                    if (MCQChoice == "e")
                    {
                        Console.WriteLine(MCQname[4] + "\n");
                        QCMNumber = 4;
                        question(MCQ[0, QCMNumber, 0], MCQ[1, QCMNumber, 0], MCQ[2, QCMNumber, 0], MCQ[3, QCMNumber, 0], MCQ[4, QCMNumber, 0], MCQ[5, QCMNumber, 0], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 1], MCQ[1, QCMNumber, 1], MCQ[2, QCMNumber, 1], MCQ[3, QCMNumber, 1], MCQ[4, QCMNumber, 1], MCQ[5, QCMNumber, 1], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 2], MCQ[1, QCMNumber, 2], MCQ[2, QCMNumber, 2], MCQ[3, QCMNumber, 2], MCQ[4, QCMNumber, 2], MCQ[5, QCMNumber, 2], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 3], MCQ[1, QCMNumber, 3], MCQ[2, QCMNumber, 3], MCQ[3, QCMNumber, 3], MCQ[4, QCMNumber, 3], MCQ[5, QCMNumber, 3], ref pointsInternes);
                        question(MCQ[0, QCMNumber, 4], MCQ[1, QCMNumber, 4], MCQ[2, QCMNumber, 4], MCQ[3, QCMNumber, 4], MCQ[4, QCMNumber, 4], MCQ[5, QCMNumber, 4], ref pointsInternes);
                    };
                    if (MCQChoice == "f")
                    { McqIsChose = true; 
                        exit = true; };
                    Console.Clear();
                }


            }

            Console.Clear();

        }

        // la fonction pour creer (ou plutot remplir) un QCM
        static void Create(ref string[,,] MCQ, ref int numberMCQActive, ref string[] McqName)
        {
            int questionNumber = 0;
            
            {
                Console.WriteLine("Enter the title of your MCQ");
                McqName[numberMCQActive] = Console.ReadLine();

                while (questionNumber <5)

                {
                    Console.WriteLine("Enter the Question");
                    MCQ[0, numberMCQActive, questionNumber] = Console.ReadLine();
                    Console.WriteLine("Enter the first possible answer (a) ");
                    MCQ[1, numberMCQActive, questionNumber] = Console.ReadLine();
                    Console.WriteLine("Enter the second possible answer (b)");
                    MCQ[2, numberMCQActive, questionNumber] = Console.ReadLine();
                    Console.WriteLine("Enter the third possible answer (c)");
                    MCQ[3, numberMCQActive, questionNumber] = Console.ReadLine();
                    Console.WriteLine("Enter the fourht possible answer (d)");
                    MCQ[4, numberMCQActive, questionNumber] = Console.ReadLine();
                    Console.WriteLine("Enter the letter of the good answer (a/b/c/d) (without caps)");
                    MCQ[5, numberMCQActive, questionNumber] = Console.ReadLine();
                    Console.Clear();
                    questionNumber++;
                }
            }numberMCQActive++;
            

        } 

            
            static void Main(string[] args)
            { 

            // le tableau qui regrouppe toutes les infos de chaques questions de chaques QCM
            string[,,] MCQTable = new string[6, 5, 5] { { { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" } }, { { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" } }, { { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" } }, { { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" } }, { { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" } }, { { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" }, { "a", "b", "c", "d", "e" } } };
            // le tableau des nom des QCM
            string[] MCQName = new string[5] { "a", "a", "a", "a", "a" };
            // début du code 

            Start();
            bool ever = false;
            int numberMcq = 0;
            while (!ever)
            {
                bool activityChoice = false;
                
                while (!activityChoice)
                {
                    Console.WriteLine("If you want to create a MCQ, enter create, and if you want to play to an MCQ, enter play. You can enter exit too (to exit).");
                    string activity = Console.ReadLine();
                    Console.Clear();
                    if (activity == "create")
                    {
                        activityChoice = true;
                        Create(ref MCQTable, ref numberMcq, ref MCQName);
                    };
                    if (activity == "play")
                    {
                        activityChoice = true;
                        int point = 0;
                        Play(MCQTable, ref point, MCQName);
                    };
                    if (activity == "exit")
                    { activityChoice = true;
                        ever = true;

                    };
                }
            }



            }

     }
}

    

