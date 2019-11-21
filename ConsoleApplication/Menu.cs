using System;
using System.Collections.Generic;

namespace ConsoleApplication
{

    class Menu
    {

        public enum mainMenu { Registertraining = 1, Goals, Completedworkouts, quit }

        public enum goalsMenu { Running = 1, biking, Walking }
        public enum completedworkoutsMenu { getResults = 1, setResults, removeResults }

        public enum quitMenu { }

        static public List<string> Menylista = new List<string> { "Register training", "Goals", "Results", "Quit" };

        public void Menumenu(List<string> menuChoices)
        {

            for (int i = 0; i < menuChoices.Count; i++)
            {

                Console.WriteLine($"[{i}] {menuChoices[i]}");
            }
        }

        int hej = Convert.ToInt32(Console.ReadLine());
        public void asdasd(goalsMenu addTrainingMenuCHoice)
        {
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