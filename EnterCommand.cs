using System.Collections.Generic;

namespace Anderture_Game_2
{
    class EnterCommand
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

        public (string, int) Enter(string PlayerDesions)
        {
            DataBaseHolder dataBaseHolder = new DataBaseHolder();
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
                            if (entry.Key == "enter" || entry.Key == "move" || entry.Key == "walk into" || entry.Key == "get in")
                            {
                                if (checker[i] == "Southern")
                                {
                                    Room = 13;
                                }
                                if (checker[i] == "Northern")
                                {
                                    Room = 14;
                                }

                                if (Room >= 9 || Room <= 15)
                                {
                                    //Positon = Room;
                                    dataBaseHolder.roomExtractionreader();

                                    var rholder = dataBaseHolder.RoomHolder;
                                    Positon = rholder;
                                    Positon += entryvalueholder;

                                    Room = Positon;
                                    dataBaseHolder.Positon = Positon;
                                    dataBaseHolder.roomExtractionwriter();
                                }
                                else
                                {
                                    Room = 15;
                                    QuestDialog = "There no where else to you can go just leave";
                                }

                                switch (Room)
                                {
                                    case 9:
                                        QuestDialog = "Your stand Enterance the Davos Family Crypt at Hall of the Dead";

                                        break;

                                    case 10:
                                        QuestDialog = "You walk down stair into room the walls of this room contain various\r\nplaques and coffins bearing the names of\r\ndeceased relatives and hall way leading to Western Crypt";

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
                                        QuestDialog = "A small dais rises up against the western wall.\r\nOn it rests an ornate coffin, the lid of which\r\nhas been smashed. In the corner, a creature\r\nlies hunched over a fresh corpse.";

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