/* using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Menu
    {
        public enum enumMenuChoice { Registertraining = 1, Goals, Completedworkouts, quit }
        public enum sportChoice { Running = 1, Biking, Walking }
        public enum completedworkoutsMenu { }
        public enum TempGoalMenu { Setgoal = 1, seeAllGoals, removeGoal }

        public enum quitMenu { tacohej }
        public enumMenuChoice GetUserInputForSwitch()
        {
            Console.WriteLine("Main menu\n");
            Console.WriteLine("1 | Register training");
            Console.WriteLine("2 | goals");
            Console.WriteLine("3 | Completed workouts");
            Console.WriteLine("4 | quit\n");

            Console.Write("Select a nummber: ");
            int input = Convert.ToInt32(Console.ReadLine());

            enumMenuChoice Choice = (enumMenuChoice)input;
            return Choice;
        }

        // byt namn till SportChoice
        public sportChoice GetInputFromUSer()
        {
            Console.WriteLine("Inne i GetInputsFromUser");
            Console.WriteLine("1 | running ");
            Console.WriteLine("2 | Biking ");
            Console.WriteLine("3 | Walking \n");

            Console.Write("Select a nummber: ");
            int input = Convert.ToInt32(Console.ReadLine());

            sportChoice Choice2 = (sportChoice)input;
            return Choice2;
        }

        public void AddTraining(sportChoice Choice22)
        {
            Console.WriteLine("i addtraining");
            switch (Choice22)
            {
                // under dessa 3 alternativ ska man sedan skriva in distance, time, för den sporten
                case sportChoice.Running:
                Console.WriteLine("1");

                    break;

                case sportChoice.Walking:
                Console.WriteLine("2");
                    break;

                case sportChoice.Biking:
                Console.WriteLine("3");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // 
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
                Console.WriteLine("Bara 1-3 sportChoicessss");
                break;
            }
        }
        public void MainMenu(enumMenuChoice Choice)
        {

            switch (Choice)
            {
                case enumMenuChoice.Registertraining:
                    //kör metoden AddTraining
                    Console.WriteLine("Register Training\n");
                    Menu.sportChoice Choice1 = GetInputFromUSer();
                    AddTraining(Choice1);
                    break;

                case enumMenuChoice.Goals:
                Console.WriteLine("main 2");
                    //går in i menyn goals
                    // här ska enum switchen in
                    Menu.enumMenuChoice choice5 = GetUserInputForSwitch();
                    GoalsMenu(choice5);
                    // enum meny för att se de olika alternativen setgoals, removegoals, 
                    break;

                case enumMenuChoice.Completedworkouts:
                    Console.WriteLine("main 3");
                    //kör metoden completedWorkouts
                    break;

                case enumMenuChoice.quit:
                    return;

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
    }
} */