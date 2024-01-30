using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anderture_Game_2
{
    class GameLogic
    {
        public string PlayerDecision { get; set; }
        public string QuestDialog { get; set; }
        public int Room { get; set; }
        public int Positon { get; set; }
        public string RoomHolder { get; set; }
        public string item { get; set; }

        public (string, int) PlayerLogic(string PlayerDecisionecision)
        {
            DataBaseHolder dataBaseHolder = new DataBaseHolder();
            ActionLogic actionDescribeLogic = new ActionLogic();
            TakeCommand takeandPlayerItems = new TakeCommand();
            EnterCommand enterCommand = new EnterCommand();
            LeaveCommand leaveCommand = new LeaveCommand();
            LookCommand LookCommand = new LookCommand();
            TakeCommand takeCommand = new TakeCommand();
            dataBaseHolder.phaseExtraction();
            var HolderInput = dataBaseHolder.UserInputHolder;

            PlayerDecisionecision = PlayerDecision.ToLower();
            if (Room == 0)
            {
                Room = 9;
            };
            //Text document might be need to save position

            if (PlayerDecisionecision != null)
            {
                foreach (KeyValuePair<string, string> entry in HolderInput)
                {
                    var checker = PlayerDecision.Split();
                    for (int i = 0; i < checker.Length; i++)
                    {
                        if (checker[i] == entry.Key)
                        {
                            int entryvalueholder = int.Parse(entry.Value);
                            if (entry.Key == "enter" || entry.Key == "move" || entry.Key == "walk into" || entry.Key == "get in")
                            {
                                enterCommand.Enter(PlayerDecision);
                                QuestDialog = enterCommand.QuestDialog;
                                Positon = enterCommand.Positon;

                            }
                            if (entry.Key == "out" || entry.Key == "leave" || entry.Key == "depart" || entry.Key == "retreat")
                            {
                                leaveCommand.Leave(PlayerDecision);
                                QuestDialog = leaveCommand.QuestDialog;
                                Positon = leaveCommand.Positon;
                            }

                            if (entry.Key == "look" || entry.Key == "look around again" || entry.Key == "Look about" || entry.Key == "inspect")
                            {
                                LookCommand.Look(PlayerDecision);
                                QuestDialog = LookCommand.QuestDialog;
                                dataBaseHolder.QuestlogExtractionwriter(QuestDialog, Positon);
                                Positon = LookCommand.Positon;
                            }
                            if (entry.Key == "take" || entry.Key == "grab" || entry.Key == "retrieve" || entry.Key == "gather")
                            {
                                //need fix it


                                takeCommand.Take(PlayerDecision);
                                QuestDialog = $"You Grab the {takeCommand.Takenitem}";
                                item = takeCommand.Takenitem;
                                dataBaseHolder.PlayeritemExtractionwriter(item);
                                Console.Write(takeCommand.Takenitem);

                            }
                        }
                    }
                }



            }
            return (QuestDialog, Positon);
        }
    }
}
