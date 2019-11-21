using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Menu
    {
        public enum mainMenu { Registertraining = 1, Goals, Completedworkouts, quit }

        public enum goalsMenu { Running = 1, biking, Walking }
        public enum completedworkoutsMenu { getResults = 1, setResults, removeResults }

        public enum quitMenu {tacohej}

        private void GetUserInputForSwitch()
        {
            int hej = Convert.ToInt32(Console.ReadLine());
        }

         private void WritesTrainingAlternetives()
        {
            Console.WriteLine(" 1 | running");
            Console.WriteLine(" 2 | Biking");
            Console.WriteLine(" 3 | Walking");
        }

        public void AddTraining(goalsMenu addTrainingMenuCHoice)
        {
            WritesTrainingAlternetives();

            switch (addTrainingMenuCHoice)
            {
                case goalsMenu.Running:
                    break;

                case goalsMenu.Walking:
                    break;

                case goalsMenu.biking:
                    break;
            }
        }

        public void MainMenu(mainMenu mainMenuChoice)
        {
            Console.WriteLine("1 | Register training");
            Console.WriteLine("2 | See your goals");
            Console.WriteLine("3 | Completed workouts");
            Console.WriteLine("4 | ");

            switch (mainMenuChoice)
            {
                case mainMenu.Registertraining:

                    break;

                case mainMenu.Goals:

                    break;

                case mainMenu.Completedworkouts:
                    break;

                case mainMenu.quit:
                    return;
            }
        }
        public void CompletedWorkoutMenu(completedworkoutsMenu CompletedworkoutsMenuchoice)
        {
            Console.WriteLine("1 | see your results");
            Console.WriteLine("2 | set rersult");
            Console.WriteLine("3 | Remove results");

            switch (CompletedworkoutsMenuchoice)
            {

                case completedworkoutsMenu.getResults:
                    break;

                case completedworkoutsMenu.setResults:
                    break;

                case completedworkoutsMenu.removeResults:
                    break;
            }
        }

        public void GoalsMenu(goalsMenu goalsMenuchoice)
        {
            WritesTrainingAlternetives();

            switch (goalsMenuchoice)
            {
                case goalsMenu.Running:
                    break;

                case goalsMenu.biking:
                    break;

                case goalsMenu.Walking:
                    break;

                default:
                    break;

            }
        }

    }

}