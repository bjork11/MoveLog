using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    class Menu
    {
        public enum enumMainMenuChoice { Registertraining = 1, Goals, Completedworkouts, quit }
        public enum sportChoice { Running = 1, Biking, Walking }
        public enum completedworkoutsMenu { }
        public enum TempGoalMenu { Setgoal = 1, seeAllGoals, removeGoal }
        public enum quitMenu { tacohej }

        public enumMainMenuChoice GetUserInputForSwitch()
        {
            Console.WriteLine("Main menu\n");
            Console.WriteLine("1 | Register Training" );
            Console.WriteLine("2 | goals");
            Console.WriteLine("3 | Completed workouts");
            Console.WriteLine("4 | quit\n");

            Console.Write("Select a nummber: ");
            int input = Convert.ToInt32(Console.ReadLine());

            enumMainMenuChoice Choice = (enumMainMenuChoice)input;
            return Choice;
        }

        // huvudmenyn 
        public void MainMenu(enumMainMenuChoice Choice)
        {
            //Printclass myPrintclass = new Printclass();
            switch (Choice)
            {
                case enumMainMenuChoice.Registertraining:
                    //kör metoden AddTraining
                    Console.WriteLine("Register Training\n");
                    // tar input från användaren och convertar till enum 
                    Menu.sportChoice Choice1 = GetInputFromUSer();
                    // går till adderatrännings metoden och tar choice1 som input för de valet och lägger.
                    AddTraining(Choice1);
                    break;

                case enumMainMenuChoice.Goals:
                    Console.WriteLine("1 | Set a goal");
                    Console.WriteLine("2 | Remove a goal");
                    Console.WriteLine("3 | See your goals");

                    Console.Write("Select a nummber: ");

                    int hej = Convert.ToInt32(Console.ReadLine());

                    switch (hej)
                    {
                        case (int)TempGoalMenu.Setgoal:
                            break;

                        case (int)TempGoalMenu.removeGoal:
                            break;

                        case (int)TempGoalMenu.seeAllGoals:
                            // skriver ut alla mål
                            Printclass.PrintCompletedGoals();
                            Printclass.PrintGoalsInProgress();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;

                case enumMainMenuChoice.Completedworkouts:
                    Printclass.PrintCompletedWorkouts();

                    //kör metoden completedWorkouts och skriver ut alla färdiga workouits
                    break;

                case enumMainMenuChoice.quit:

                    return;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // enum metod som tar input och convertar till enum för input till våra enum switchcase
        public sportChoice GetInputFromUSer()
        {
            Console.WriteLine("Inne i GetInputsFromUser");
            Console.WriteLine("1 | running ");
            Console.WriteLine("2 | Walking ");
            Console.WriteLine("3 | Biking \n");

            Console.Write("Select a nummber: ");
            int input = Convert.ToInt32(Console.ReadLine());

            sportChoice Choice2 = (sportChoice)input;
            return Choice2;
        }

        public void AddTraining(sportChoice Choice2)
        {
            Console.WriteLine("i addtraining");
            switch (Choice2)
            {
                // under dessa 3 alternativ ska man sedan skriva in distance, time, för den sporten man gjort
                case sportChoice.Running:
                    break;

                case sportChoice.Walking:
                    break;

                case sportChoice.Biking:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void GoalsMenu(TempGoalMenu choice5)
        {
            Console.WriteLine("Goals Menu");
            switch (choice5)
            {
                case TempGoalMenu.Setgoal:
                    Console.WriteLine("goalsmenu 1");
                    // Tilllallar setgoals metoden för att sätta mål
                    Menu.sportChoice Choice1 = GetInputFromUSer();
                    SetSportForGoal(Choice1);
                    break;

                case TempGoalMenu.removeGoal:
                    Console.WriteLine("goalsmenu 2");
                    // ska ta bort 1 mål
                    break;

                case TempGoalMenu.seeAllGoals:
                    Console.WriteLine("goalsmenu 3");
                    // visar alla mål
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        // När man ska välja mål måste man välja sport först.
        public void SetSportForGoal(sportChoice choice6)
        {
            Console.WriteLine("i sportchoice");
            switch (choice6)
            {
                case sportChoice.Biking:
                    Console.WriteLine("i sportchoice 1");
                    break;

                case sportChoice.Running:
                    Console.WriteLine("i sportchoice 2");
                    break;

                case sportChoice.Walking:
                    Console.WriteLine("i sportchoice 3");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void CompletedWorkoutMenu(completedworkoutsMenu Choice)
        {
            // foraech för att skriva ut alla träningpass i completed workouts listan

            //foreach ()
        }

        public completedworkoutsMenu GettingUserInputworkouts()
        {
            Console.WriteLine("Select a nummber");
            int input = Convert.ToInt32(Console.ReadLine());

            completedworkoutsMenu Choice3 = (completedworkoutsMenu)input;
            return Choice3;
        }

        public void ShowGoals()
        {
            // kommer att skriva ut alla mål som finns



        }


        public void ConsoleReadlineTryCatch()
        {
            try
            {

                int userInpu = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Only Numbbers");
            }

        }
    }
}




// try catch metod för console.readline