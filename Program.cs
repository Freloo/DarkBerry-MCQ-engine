using System;

namespace DarkBerry_alpha
{
class Program
    {
       
        


 
        


static void Main(string[] args)



        {
           
            static void question(string question, string a, string b, string c, string goodAnswer, string goodAnswerCaps, ref int pointInterne)
            {
                Console.WriteLine(question);
                Console.WriteLine("A-" + a);
                Console.WriteLine("B-" + b);
                Console.WriteLine("C-" + c);
                Console.WriteLine("Enter the letter of the answer.");
                string answer = Console.ReadLine();

                if (answer == goodAnswer || answer == goodAnswerCaps)
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
            int point = 0;
            string n1 = "Famous poeple";
            string n2 = "MCQ2";
            string n3 = "MCQ3";
            string n4 = "MCQ4";
            string n5 = "MCQ5";


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
            Console.WriteLine("Darkberry alpha v1.0");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();
            Console.Beep(300, 200);
            Console.WriteLine("Welcome in DarkBerry, an MCQ engine");
            Console.WriteLine("press any key to continue\n");
            Console.ReadKey();
            Console.Beep(300, 200);
           
           
            Console.Beep(300, 200);
            
            
            Console.Beep(300, 200);
            int exit = 0;
                while (exit==0) 
            {
                Console.WriteLine("Please chose an Mcq :\n");
                string McqNumber = "a";
                Console.WriteLine("a-" + n1);
                Console.WriteLine("b-" + n2);
                Console.WriteLine("c-" + n3);
                Console.WriteLine("d-" + n4);
                Console.WriteLine("e-" + n5);
                Console.WriteLine("f-exit");

                McqNumber = Console.ReadLine();
                Console.Clear();
                if (McqNumber == "f" || McqNumber == "F")
                {
                    exit = 1;

                };
                if (McqNumber == "a" || McqNumber == "A")
                { // to add question in the quizz, procedate same the example, the question, the 3 possibilities, the good answer without caps, the good answer with caps and ref point
                    Console.WriteLine(n1 + "\n");
                    question("How the French king Louis 9 was dead :", "of The plague", "in a horse accident", "in the crusade", "a", "A",ref point);
                    Console.WriteLine("You have" + point);
                    question("Wich Pope was canonized at the same time as St Jean Paul II", "St Pie X", "St Eusébe", "St Jean XXIII", "c", "C", ref point);
                    Console.WriteLine("You have " + point);
                    question("How Freddie Mercury was dead :", "Of the AIDS", "Of a pneumonia", "Of a car accident", "b", "B", ref point);
                    Console.WriteLine("You have " + point);
                    question("Who is the singer of Pink Floyd : ", "Nicola Sirkis", "David Gilmour", "James Douglas Morrisson", "b", "B", ref point);
                    Console.WriteLine("You have " + point);
                    question("In wich year Jules Cesar is birth : ", "-100", "33", "-44", "a", "A", ref point);


                }
                Console.Clear();
                if (McqNumber == "b" || McqNumber == "B")
                {
                    Console.WriteLine(n2 + "\n");
                    question("Question", "Choice1", "Choice2", "Choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);


                }
                if (McqNumber == "c" || McqNumber == "C")
                {
                    Console.WriteLine(n3 + "\n");
                    question("", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);

                }
                if (McqNumber == "d" || McqNumber == "D")
                {
                    Console.WriteLine(n4 + "\n");
                    question("", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                }
                if (McqNumber == "e" || McqNumber == "E")
                {
                    Console.WriteLine(n5 + "\n");
                    question("", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                    question("question", "choice1", "choice2", "choice3", "a", "A", ref point);
                    Console.WriteLine("You have " + point);
                };
            
            }
        }
    }
}