using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    class Menu
    {
        // enums för alla menyer
        public enum enumMainMenu { Registertraining = 1, Goals, Completedworkouts, quit }
        public enum enumSportMenu { Running = 1, Walking, Biking }
        public enum enumGoalMenu { Setgoal = 1, removeGoal, seeAllGoals, goBackToMainMenu }
        public enum enumChooseTypeOfGoalMenu { setDistanceGoal = 1, setTimeGoal }

        // enum metod som skriver ut huvudmenyn och kollar felhantering
        // Convertar choice som blir inputen till en enum switch casen i MainMenu metoden
        // retunerar choice till Main och skickar in de som användaren skrev in.
        public enumMainMenu GetUserInputMainMenuSwitch()
        {
            do
            {
                Console.WriteLine("Main menu\n");
                Console.WriteLine("1 | Register Training");
                Console.WriteLine("2 | Goals");
                Console.WriteLine("3 | Completed Workouts");
                Console.WriteLine("4 | Quit\n");

                Console.Write("Select a number");
                try
                {
                    Console.Write(": ");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput > 4 || userInput < 1)
                    {
                        Console.Clear();
                        throw new Exception();
                    }

                    enumMainMenu choice = (enumMainMenu)userInput;
                    return choice;
                }
                catch
                {
                    Console.WriteLine("Only numbers between 1-4!");
                }

            } while (true);
        }

        // Här skickas choice in från enummetoden GetUserInputMainMenuSwitch och valet görs beroende på vad användaren skrev in i inputen i den föregående motoden.
        public void MainMenu(enumMainMenu Choice)
        {
            switch (Choice)
            {
                case enumMainMenu.Registertraining:
                    Console.Clear();
                    Console.WriteLine("Register Training\n");
                    // tar input från användaren och convertar till enum 
                    Menu.enumSportMenu Choice1 = enumTryCatchForSportMenu();
                    //går till chooseTypOfTraining metoden och använder sedan choice1 från GetInputFromUser Metoden och skickar in valet i chooseTypOfTraining metoden och gör de valet som användaren skrivit
                    chooseTypOfTraining(Choice1);
                    break;

                case enumMainMenu.Goals:
                    bool doWhileLoop = true;
                    // enum switch i en enum switch för goals menyn
                    do
                    {
                        Console.WriteLine("1 | Set a goal");
                        Console.WriteLine("2 | Remove a goal");
                        Console.WriteLine("3 | See your goals");
                        Console.WriteLine("4 | Go back to main menu");

                        Console.Write("Select a number");

                        int inputForGoal = IntUserInputTryCatch();
                        Console.Clear();
                        switch (inputForGoal)
                        {
                            case (int)enumGoalMenu.Setgoal:
                                ChooseTypeOfGoal();
                                break;

                            case (int)enumGoalMenu.removeGoal:
                                Printclass.PrintGoalsInProgress();
                                Console.Write("Select the number of the goal you want to remove");

                                do
                                {
                                    if (Goals.goalsInProgress.Count == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You dont have any goals at the moment, please set one first");
                                        return;
                                    }

                                    int removeGoalChoice = IntUserInputTryCatch();

                                    if (removeGoalChoice > Goals.goalsInProgress.Count)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have a goal matching that index");
                                        return;
                                    }

                                    else
                                    {
                                        Goals.RemoveGoal(removeGoalChoice - 1);
                                        return;

                                    }
                                } while (true);

                            case (int)enumGoalMenu.seeAllGoals:
                                Printclass.PrintCompletedGoals();
                                Printclass.PrintGoalsInProgress();
                                break;

                            case (int)enumGoalMenu.goBackToMainMenu:
                                return;

                            default:
                                doWhileLoop = true;
                                Console.WriteLine("1-4 only");
                                Console.ReadLine();
                                break;
                        }

                    } while (doWhileLoop == true);
                    break;

                case enumMainMenu.Completedworkouts:
                    Printclass.PrintCompletedWorkouts();
                    break;

                case enumMainMenu.quit:
                    return;
            }
        }

        // tar input från användaren och kollar så den stämmer med de alternativ som finns
        public enumChooseTypeOfGoalMenu ChooseTypeOfGoal()
        {
            enumChooseTypeOfGoalMenu choice = enumChooseTypeOfGoalMenuTryCatch();

            switch (choice)
            {
                case enumChooseTypeOfGoalMenu.setDistanceGoal:
                    Menu.enumSportMenu choice1 = enumTryCatchForSportMenu();
                    ChooseSportForDistanceGoal(choice1);
                    return choice;

                case enumChooseTypeOfGoalMenu.setTimeGoal:
                    Menu.enumSportMenu choice2 = enumTryCatchForSportMenu();
                    ChooseSportForTimeGoal(choice2);
                    return choice; 

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        //används för att välja sport när du ska registrera ett mål med distans.
        public void ChooseSportForDistanceGoal(enumSportMenu choice1)
        {
            Console.WriteLine("Enter how many meters your goal should be");
            int inputMeter = IntUserInputTryCatch();

            switch (choice1)
            {
                case enumSportMenu.Running:
                    ClassLibrary.DistanceGoal.AddDistanceGoal(inputMeter, "Running");
                    break;

                case enumSportMenu.Walking:
                    ClassLibrary.DistanceGoal.AddDistanceGoal(inputMeter, "Walking");
                    break;

                case enumSportMenu.Biking:
                    ClassLibrary.DistanceGoal.AddDistanceGoal(inputMeter, "Biking");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        //används för att välja sport när du ska registrera ett mål med tid.
        public void ChooseSportForTimeGoal(enumSportMenu choice2)
        {
            Console.WriteLine("Enter how many seconds your goal should be");
            int inputSecond = IntUserInputTryCatch();

            switch (choice2)
            {
                case enumSportMenu.Running:
                    ClassLibrary.TimeGoal.AddTimeGoal(inputSecond, "Running");
                    break;

                case enumSportMenu.Walking:
                    ClassLibrary.TimeGoal.AddTimeGoal(inputSecond, "Walking");
                    break;

                case enumSportMenu.Biking:
                    ClassLibrary.TimeGoal.AddTimeGoal(inputSecond, "Biking");
                    break;

                default:
                    throw new ArgumentOutOfRangeException("");
            }
        }

        // skickar in inputen för typen av sport
        // båda int variablerna går igenom en try catch för att kolla så de är int
        //en instansiering av klassen görs sen skickar vi in Seconds och Meters till addWorkout för att lägga till en färdig träning
        public void chooseTypOfTraining(enumSportMenu Choice2)
        {
            int inputMeters = GetWorkoutDistance();
            int inputSeconds = GetWorkoutTime();

            switch (Choice2)
            {
                case enumSportMenu.Running:
                    ClassLibrary.Running runningWorkout = new Running();
                    runningWorkout.AddWorkout(inputMeters, inputSeconds);
                    break;

                case enumSportMenu.Walking:
                    ClassLibrary.Walking walkingWorkout = new Walking();
                    walkingWorkout.AddWorkout(inputMeters, inputSeconds);
                    break;

                case enumSportMenu.Biking:
                    ClassLibrary.Biking bikingWorkout = new Biking();
                    bikingWorkout.AddWorkout(inputMeters, inputSeconds);
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Only 1-3");
                    
            }
            Console.ReadLine();
        }

        // skickas in i IntUserInputTryCatch som är en tryCatch för int,retunerar sedan värdet
        public int GetWorkoutDistance()
        {
            Console.Write("Enter distance in meters");
            int inputMeters = IntUserInputTryCatch();
            return inputMeters;
        }

        // skickas in i IntUserInputTryCatch som är en tryCatch för int,retunerar sedan värdet
        public int GetWorkoutTime()
        {
            Console.Write("Enter time in seconds");
            int inputSeconds = IntUserInputTryCatch();

            return inputSeconds;
        }
        // Try catch metod för alla int inputs som görs i programmet 
        public int IntUserInputTryCatch()
        {
            do
            {
                Console.Write(": ");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    return userInput;
                }
                catch
                {
                    Console.WriteLine("Only numbers!");
                    Console.ReadLine();
                }

            } while (true);
        }

        // enum metod som kollar om användarens input stämmer med alternativen som finns
        // om inputen stämmer convertas den till enum choice och retuneras till ChooseTypOFGoal(Valet av sport)
        public enumSportMenu enumTryCatchForSportMenu()
        {
            do
            {
                Console.WriteLine("1 | Running");
                Console.WriteLine("2 | Walking");
                Console.WriteLine("3 | Biking");
                Console.Write("What sport");

                try
                {
                    Console.Write(": ");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput > 3 || userInput < 1)
                    {
                        Console.Clear();
                        throw new Exception();
                    }

                    enumSportMenu choice = (enumSportMenu)userInput;
                    return choice;
                }
                catch
                {
                    Console.WriteLine("Only numbers between 1-3");
                }

            } while (true);
        }

        // enum metod som kollar om användarens input stämmer med alternativen som finns
        // om inputen stämmer convertas den och skickas vidare 
        public enumChooseTypeOfGoalMenu enumChooseTypeOfGoalMenuTryCatch()
        {
            do
            {
                try
                {
                    Console.WriteLine("1 | Set Distance Goal");
                    Console.WriteLine("2 | Set Time Goal");
                    Console.Write("Choice: ");

                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput > 2 || userInput < 1)
                    {
                        Console.Clear();
                        throw new Exception();
                    }
                    enumChooseTypeOfGoalMenu choice = (enumChooseTypeOfGoalMenu)userInput;
                    return choice;
                }
                catch
                {
                    Console.WriteLine("1-2 only");
                    Console.ReadLine();
                }

            } while (true);
        }
    }
}