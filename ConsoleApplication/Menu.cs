using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    class Menu
    {
        public enum enumMainMenu { Registertraining = 1, Goals, Completedworkouts, quit }
        public enum enumSportMenu { Running = 1, Walking, Biking }
        public enum enumCompletedWorkoutsMenu { }
        public enum enumGoalMenu { Setgoal = 1, removeGoal, seeAllGoals }
        public enum enumQuitMenu { tacohej }

        public enumMainMenu GetUserInputForSwitch()
        {
            Console.WriteLine("Main menu\n");
            Console.WriteLine("1 | Register Training");
            Console.WriteLine("2 | Goals");
            Console.WriteLine("3 | Completed Workouts");
            Console.WriteLine("4 | Quit\n");

            Console.Write("Select a number: ");
            
            int input = IntUserInputTryCatch();
            enumMainMenu Choice = (enumMainMenu)input;

            return Choice;
        }

        // huvudmenyn 
        public void MainMenu(enumMainMenu Choice)
        {
           // bool doWhileLoop = true;

            do
            {
            
                switch (Choice)
                {
                    case enumMainMenu.Registertraining:
                        Console.Clear();
                        Console.WriteLine("Register Training\n");
                        // tar input från användaren och convertar till enum 
                        Menu.enumSportMenu Choice1 = GetInputFromUser();
                        //går till addtraining metoden och tar sedan input från GetInputFromUser Metoden över för de valet och l
                        AddTraining(Choice1);
                        break;

                    case enumMainMenu.Goals:
                        // do while loop sedan.
                        bool doWhileLoop = true;

                        do {

                        Console.WriteLine("1 | Set a goal");
                        Console.WriteLine("2 | Remove a goal");
                        Console.WriteLine("3 | See your goals");

                        Console.Write("Select a number: ");
                        // try catch metod som tar int user input för switch val
                        int inputForGoal = IntUserInputTryCatch();

                        switch (inputForGoal)
                        {
                            case (int)enumGoalMenu.Setgoal:
                                ChooseTypeOfGoal();
                                break;

                            case (int)enumGoalMenu.removeGoal:
                                Printclass.PrintGoalsInProgress();
                                Console.WriteLine("Select the number of the goal you want to remove: ");
                                int removeGoalChoice = IntUserInputTryCatch();
                                Goals.RemoveGoal(removeGoalChoice - 1);

                                break;

                            case (int)enumGoalMenu.seeAllGoals:
                                Printclass.PrintCompletedGoals();
                                Printclass.PrintGoalsInProgress();
                                break;

                            default:
                                doWhileLoop = false;
                                Console.WriteLine("1-3 only");
                                break;
                        }

                        } while (doWhileLoop == true); 
                        break;

                    case enumMainMenu.Completedworkouts:
                        Printclass.PrintCompletedWorkouts();
                        break;

                    case enumMainMenu.quit:
                        return;

                    default:
                        throw new ArgumentOutOfRangeException("1-4 only");

                }

             } while (Choice >= Menu.enumMainMenu.quit);

             //Choice != Menu.enumMainMenu.Registertraining || Choice != Menu.enumMainMenu.Goals || Choice != Menu.enumMainMenu.quit);
    
                    
                
        }
        public void ChooseTypeOfGoal()
        {
            Console.WriteLine("1 | Set Distance Goal");
            Console.WriteLine("2 | Set Time Goal");
            Console.Write(": ");
            int input = IntUserInputTryCatch();

            switch (input)
            {
                case 1:
                    Menu.enumSportMenu choice1 = GetInputFromUser();
                    ChooseSportForDistanceGoal(choice1);
                    break;

                case 2:
                    Menu.enumSportMenu choice2 = GetInputFromUser();
                    ChooseSportForTimeGoal(choice2);
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Only 1-2");
            }
        }
        public void ChooseSportForDistanceGoal(enumSportMenu choice1)
        {
            //Console.WriteLine("What sport would you like to add a goal to?")
            // try catch metdo för input
            Console.WriteLine("Enter how many meters your goal should be: ");
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
                    throw new ArgumentOutOfRangeException("Only 1-3");
            }
        }
        public void ChooseSportForTimeGoal(enumSportMenu choice2)
        {
            //try catch metod för input
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
                    throw new ArgumentOutOfRangeException("Only 1-3");
            }
        }


        // enum metod som tar input och convertar till enum för input till våra enum switchcase
        public enumSportMenu GetInputFromUser()
        {
            Console.WriteLine("1 | Running ");
            Console.WriteLine("2 | Walking ");
            Console.WriteLine("3 | Biking \n");

            // try catch för input
            Console.WriteLine("What sport? ");
            int input = IntUserInputTryCatch();

            enumSportMenu Choice2 = (enumSportMenu)input;
            return Choice2;
        }
        public int GetWorkoutDistance()
        {
            Console.Write("Enter distance in meters: ");
            int inputMeters = IntUserInputTryCatch();
            return inputMeters;
        }
        public int GetWorkoutTime()
        {
            Console.Write("Enter time in seconds: ");
            int inputSeconds = IntUserInputTryCatch();
            return inputSeconds;
        }

        public void AddTraining(enumSportMenu Choice2)
        {
            // try catch för input
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
        }
        public int IntUserInputTryCatch()
        {
            bool doWhileLoop = true;
            int userInput = 0;

            do
            {
                Console.Write("Choice : ");

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    doWhileLoop = false;

                }

                catch
                {
                    Console.WriteLine("Only Numbers");
                }

            } while (doWhileLoop);

            return userInput;
        }
    }
}




// try catch metod för console.readline
// fixa user input och converta efter