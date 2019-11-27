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
            int input = Convert.ToInt32(Console.ReadLine());

            enumMainMenu Choice = (enumMainMenu)input;
            return Choice;
        }

        // huvudmenyn 
        public void MainMenu(enumMainMenu Choice)
        {
            switch (Choice)
            {
                case enumMainMenu.Registertraining:
                    Console.Clear();
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

                    Console.Write("Select a number: ");

                    int inputForGoal = Convert.ToInt32(Console.ReadLine());

                    switch (inputForGoal)
                    {
                        case (int)enumGoalMenu.Setgoal:
                            ChooseTypeOfGoal();
                            break;

                        case (int)enumGoalMenu.removeGoal:
                            Printclass.PrintGoalsInProgress();
                            Console.WriteLine("Select the number of the goal you want to remove: ");
                            int removeGoalChoice = Convert.ToInt32(Console.ReadLine());
                            Goals.RemoveGoal(removeGoalChoice - 1);
                            break;

                        case (int)enumGoalMenu.seeAllGoals:
                            Printclass.PrintCompletedGoals();
                            Printclass.PrintGoalsInProgress();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;

                case enumMainMenu.Completedworkouts:
                    Printclass.PrintCompletedWorkouts();
                    break;

                case enumMainMenu.quit:
                    return;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void ChooseTypeOfGoal()
        {
            Console.WriteLine("1 | Set Distance Goal");
            Console.WriteLine("2 | Set Time Goal");
            Console.Write(": ");
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
            Console.WriteLine("1 | Running ");
            Console.WriteLine("2 | Walking ");
            Console.WriteLine("3 | Biking \n");

            Console.Write("Choose Sport: ");
            int input = Convert.ToInt32(Console.ReadLine());

            enumSportMenu Choice2 = (enumSportMenu)input;
            return Choice2;
        }
        public int GetWorkoutDistance()
        {
            Console.Write("Enter distance in meters: ");
            int inputMeters = Convert.ToInt32(Console.ReadLine());
            return inputMeters;
        }
        public int GetWorkoutTime()
        {
            Console.Write("Enter time in seconds: ");
            int inputSeconds = Convert.ToInt32(Console.ReadLine());
            return inputSeconds;
        }

        public void AddTraining(enumSportMenu Choice2)
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
                    throw new ArgumentOutOfRangeException();
            }
        }
        public enumCompletedWorkoutsMenu GettingUserInputworkouts()
        {
            Console.WriteLine("Select a number");
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
                Console.WriteLine("Only Numbers");
            }

        }
    }
}




// try catch metod för console.readline