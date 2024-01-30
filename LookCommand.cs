using System.Collections.Generic;

namespace Anderture_Game_2 { 
    class LookCommand
    {
        public string PlayerD { get; set; }
        public string QuestDialog { get; set; }
        public int Room { get; set; }

        public bool inorout = false;
        public int Positon { get; set; }
        public int Positons { get; set; }
        public string RoomHolder { get; set; }
        public string item { get; set; }
        public string PlayerDesions { get; set; }


        public (string, int) Look(string PlayerDesions)
        {

            DataBaseHolder dataBaseHolder = new DataBaseHolder();
            TakeCommand takeCommand = new TakeCommand();
            ActionLogic actionLogic = new ActionLogic();
            dataBaseHolder.phaseExtraction();
            var HolderInput = dataBaseHolder.UserInputHolder;
            if (Room == 0)
            {
                Room = 9;
            };
            //Text document might be need to save position

            if (PlayerDesions != null)
            {
                foreach (KeyValuePair<string, string> entry in HolderInput)
                {
                    var checker = PlayerDesions.Split();
                    for (int i = 0; i < checker.Length; i++)
                    {
                        if (checker[i] == entry.Key)
                        {
                            int entryvalueholder = int.Parse(entry.Value);
                            if (entry.Key == "look" || entry.Key == "look around again" || entry.Key == "Look about" || entry.Key == "inspect")
                            {
                                Positon = Room;
                                actionLogic.InterAction();

                                switch (Room)
                                {
                                    case 9:

                                        string LastestQuestDialog0 = actionLogic.EventAction;
                                        QuestDialog = LastestQuestDialog0;

                                        break;

                                    case 10:

                                        string LastestQuestDialog1 = actionLogic.EventAction;
                                        QuestDialog = LastestQuestDialog1;

                                        break;

                                    case 11:

                                        string LastestQuestDialog2 = actionLogic.EventAction;
                                        QuestDialog = LastestQuestDialog2;

                                        break;


                                    case 12:

                                        string LastestQuestDialog3 = actionLogic.EventAction;
                                        QuestDialog = LastestQuestDialog3;




                                        break;

                                    case 13:

                                        string LastestQuestDialog4 = actionLogic.EventAction;
                                        QuestDialog = LastestQuestDialog4;




                                        break;

                                    case 14:

                                        string LastestQuestDialog5 = actionLogic.EventAction;
                                        QuestDialog = LastestQuestDialog5;



                                        break;

                                    case 15:

                                        string LastestQuestDialog6 = actionLogic.EventAction;
                                        QuestDialog = LastestQuestDialog6;


                                        break;
                                }
                            }

                        }
                    }
                }
            }
            return (QuestDialog, Positon);
        }

    }
}
