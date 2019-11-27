using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    class Menu
    {
        public enum enumMainMenu { Registertraining = 1, Goals, Completedworkouts, quit }
        public enum enumSportMenu { Running = 1, Biking, Walking }
        public enum enumCompletedWorkoutsMenu { }
        public enum enumGoalMenu { Setgoal = 1, seeAllGoals, removeGoal }
        public enum enumQuitMenu { tacohej }

        public enumMainMenu GetUserInputForSwitch()
        {
            Console.WriteLine("Main menu\n");
            Console.WriteLine("1 | Register Training" );
            Console.WriteLine("2 | goals");
            Console.WriteLine("3 | Completed workouts");
            Console.WriteLine("4 | quit\n");

            Console.Write("Select a nummber: ");
            int input = Convert.ToInt32(Console.ReadLine());

            enumMainMenu Choice = (enumMainMenu)input;
            return Choice;
        }

        // huvudmenyn 
        public void MainMenu(enumMainMenu Choice)
        {
            //Printclass myPrintclass = new Printclass();
            switch (Choice)
            {
                case enumMainMenu.Registertraining:
                    //kör metoden AddTraining
                    Console.WriteLine("Register Training\n");
                    // tar input från användaren och convertar till enum 
                    Menu.enumSportMenu Choice1 = GetInputFromUSer();
                    // går till adderatrännings metoden och tar choice1 som input för de valet och lägger.
                    AddTraining(Choice1);
                    break;

                case enumMainMenu.Goals:
                    Console.WriteLine("1 | Set a goal");
                    Console.WriteLine("2 | Remove a goal");
                    Console.WriteLine("3 | See your goals");

                    Console.Write("Select a nummber: ");

                    int inputForGoal = Convert.ToInt32(Console.ReadLine());

                    switch (inputForGoal)
                    {
                        case (int)enumGoalMenu.Setgoal:
                            ChooseTypeOfGoal();
                            break;

                        case (int)enumGoalMenu.removeGoal:
                            Printclass.PrintGoalsInProgress();
                            Console.WriteLine("Select number of the goal you want to remove: ");
                            int removeGoalChoice = Convert.ToInt32(Console.ReadLine());
                            Goals.RemoveGoal(removeGoalChoice - 1);
                            break;

                        case (int)enumGoalMenu.seeAllGoals:
                            // skriver ut alla mål
                            Printclass.PrintCompletedGoals();
                            Printclass.PrintGoalsInProgress();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;

                case enumMainMenu.Completedworkouts:
                    Printclass.PrintCompletedWorkouts();

                    //kör metoden completedWorkouts och skriver ut alla färdiga workouits
                    break;

                case enumMainMenu.quit:

                    return;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void ChooseTypeOfGoal()
        {
            Console.WriteLine("Press 1 for distancegoal, press 2 for timegoal");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: 
                Menu.enumSportMenu choice1 = GetInputFromUSer();
                ChooseSportForDistanceGoal(choice1);
                break;

                case 2:
                Menu.enumSportMenu choice2 = GetInputFromUSer();
                ChooseSportForTimeGoal(choice2);
                break;

                default:
                break;
            }
        }
        public void ChooseSportForDistanceGoal(enumSportMenu choice1)
        {
            //Console.WriteLine("What sport would you like to add a goal to?");
            Console.WriteLine("Enter how many meters your goal should be: ");
            int inputMeter = Convert.ToInt32(Console.ReadLine());
            
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
                break;
            }
        }
        public void ChooseSportForTimeGoal(enumSportMenu choice2)
        {
            //Console.WriteLine("What sport would you like to add a goal to?");
            Console.WriteLine("Enter how many seconds your goal should be");
            int inputSecond = Convert.ToInt32(Console.ReadLine());

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
                break;
            }
        }


        // enum metod som tar input och convertar till enum för input till våra enum switchcase
        public enumSportMenu GetInputFromUSer()
        {
            Console.WriteLine("Choose Sport: ");
            Console.WriteLine("1 | Running ");
            Console.WriteLine("2 | Walking ");
            Console.WriteLine("3 | Biking \n");

            Console.Write("Select a nummber: ");
            int input = Convert.ToInt32(Console.ReadLine());

            enumSportMenu Choice2 = (enumSportMenu)input;
            return Choice2;
        }

        public void TestSetGoal()
        {

        }

        public void AddTraining(enumSportMenu Choice2)
        {
            Console.WriteLine("i addtraining");
            switch (Choice2)
            {
                // under dessa 3 alternativ ska man sedan skriva in distance, time, för den sporten man gjort
                case enumSportMenu.Running:
                    ClassLibrary.Running runningWorkout = new Running();
                    break;

                case enumSportMenu.Walking:
                    ClassLibrary.Walking walkingWorkout = new Walking();
                    break;

                case enumSportMenu.Biking:
                    ClassLibrary.Biking bikingWorkout = new Biking();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /*
        public void GoalsMenu(enumGoalMenu choice5)
        {
            Console.WriteLine("Goals Menu");
            switch (choice5)
            {
                case enumGoalMenu.Setgoal:
                    Console.WriteLine("goalsmenu 1");
                    // Tilllallar setgoals metoden för att sätta mål
                    Menu.enumSportMenu Choice1 = GetInputFromUSer();
                    SetSportForGoal(Choice1);
                    break;

                case enumGoalMenu.removeGoal:
                    Console.WriteLine("goalsmenu 2");
                    // ska ta bort 1 mål
                    break;

                case enumGoalMenu.seeAllGoals:
                    Console.WriteLine("goalsmenu 3");
                    // visar alla mål
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        } */
        // När man ska välja mål måste man välja sport först.
        public void SetSportForGoal(enumSportMenu choice6)
        {
            Console.WriteLine("i enumSportMenu");
            switch (choice6)
            {
                case enumSportMenu.Biking:
                    Console.WriteLine("i enumSportMenu 1");
                    break;

                case enumSportMenu.Running:
                    Console.WriteLine("i enumSportMenu 2");
                    break;

                case enumSportMenu.Walking:
                    Console.WriteLine("i enumSportMenu 3");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public enumCompletedWorkoutsMenu GettingUserInputworkouts()
        {
            Console.WriteLine("Select a nummber");
            int input = Convert.ToInt32(Console.ReadLine());

            enumCompletedWorkoutsMenu Choice3 = (enumCompletedWorkoutsMenu)input;
            return Choice3;
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