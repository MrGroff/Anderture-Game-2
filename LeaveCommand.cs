using System.Collections.Generic;

namespace Anderture_Game_2
{
    class LeaveCommand
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

        public (string, int) Leave(string PlayerDesions)
        {
            DataBaseHolder dataBaseHolder = new DataBaseHolder();
            ActionLogic actionDescribeLogic = new ActionLogic();
            TakeCommand takeandPlayerItems = new TakeCommand();
            EnterCommand enterCommand = new EnterCommand();
            dataBaseHolder.phaseExtraction();
            var HolderInput = dataBaseHolder.UserInputHolder;

            PlayerD = PlayerDesions.ToLower();
            if (Room == 0)
            {
                Room = 9;
            };
            //Text document might be need to save position

            if (PlayerD != null)
            {
                foreach (KeyValuePair<string, string> entry in HolderInput)
                {
                    var checker = PlayerDesions.Split();
                    for (int i = 0; i < checker.Length; i++)
                    {
                        if (checker[i] == entry.Key)
                        {
                            int entryvalueholder = int.Parse(entry.Value);
                            if (entry.Key == "out" || entry.Key == "leave" || entry.Key == "depart" || entry.Key == "retreat")
                            {
                                if (Room >= 9 || Room <= 15)
                                {
                                    Room -= entryvalueholder;
                                    Positon = Room;
                                    dataBaseHolder.Positon = Positon;
                                    dataBaseHolder.roomExtractionwriter();

                                }
                                if (Room < 9)
                                {
                                    Room = 9;
                                    QuestDialog = "There nothing around you go back in you wierdo";
                                }
                                else
                                {
                                    Room = 15;
                                    QuestDialog = "There no where else to you can go just leave";
                                }
                                switch (Room)
                                {
                                    case 9:
                                        QuestDialog = "You walk up the stair enterance the Davos Family Crypt at Hall of the Dead";
                                        break;

                                    case 10:
                                        QuestDialog = "You walk into room the walls of this room contain various\r\nplaques and coffins bearing the names of\r\ndeceased relatives and hall way leading to Western Crypt";
                                        break;

                                    case 11:
                                        QuestDialog = "You walk into room there two large coffins rest embedded in the\r\nnorthern and southern walls of this chamber.";
                                        break;

                                    case 12:
                                        QuestDialog = "You walk into room the doors can be seen in all cardinal directions.\r\nOtherwise, this room is empty.";
                                        break;

                                    case 13:
                                        QuestDialog = "You walk into room the like the first two chambers, this one contains\r\nvarious coffins and plaques along the walls.";
                                        break;

                                    case 14:
                                        QuestDialog = "You walk into room the like the first two chambers, this one contains\r\nvarious coffins and plaques along the walls.";
                                        break;

                                    case 15:
                                        QuestDialog = "You walk into room a small dais rises up against the western wall.\r\nOn it rests an ornate coffin, the lid of which\r\nhas been smashed. In the corner, a creature\r\nlies hunched over a fresh corpse.";
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

