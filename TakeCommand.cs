using System.Collections.Generic;

namespace Anderture_Game_2
{
    class TakeCommand
    {
        public string PlayerD { get; set; }
        public string Pitems { get; set; }
        public string Takenitem { get; set; }
        //public string QuestDialog { get; set; }

        public string PlayerItems()
        {
            DataBaseHolder dataBaseHolder = new DataBaseHolder();
            dataBaseHolder.playerItemExtraction();
            foreach (KeyValuePair<string, string> entry in dataBaseHolder.PlayerItemHolder)
            {
                Pitems = entry.Key;
            }
            return Pitems;
        }
        public string Take(string PlayerD)
        {
            //Clean up later 
            GameLogic gameDescribeLogic = new GameLogic();
            DataBaseHolder dataBaseHolder = new DataBaseHolder();
            ActionLogic actionDescribeLogic = new ActionLogic();
            LookCommand lookCommand = new LookCommand();
            dataBaseHolder.phaseExtraction();
            dataBaseHolder.itemExtraction();
            dataBaseHolder.QuestlogExtraction();
            PlayerD = PlayerD.ToLower();
            var QuestDialog = dataBaseHolder.LookQuestlogRoom;
            var HolderInput = dataBaseHolder.UserInputHolder;
            var Holderitems = dataBaseHolder.ItemDatabaseHolder;
            if (PlayerD != null)
            {
                foreach (KeyValuePair<string, string> entry in HolderInput)
                {
                    var checker = PlayerD.Split();
                    for (int i = 0; i < checker.Length; i++)
                    {
                        if (checker[i] == entry.Key)
                        {
                            if (entry.Key == "take" || entry.Key == "grab" || entry.Key == "retrieve" || entry.Key == "gather")
                            {
                                foreach (KeyValuePair<string, string> entryq in QuestDialog)
                                {
                                    var Qhecker = entryq.Key.Split();
                                    for (int y = 0; y < Qhecker.Length; y++)
                                    {
                                        var LQhecker = Qhecker[y].ToLower();
                                        //actionDescribeLogic.InterAction();
                                        if (LQhecker == "stick" || LQhecker == "sword" || LQhecker == "mace" || LQhecker == "spear" || LQhecker == "bow" || LQhecker == "shield")
                                        {

                                            foreach (KeyValuePair<string, string> entryi in Holderitems)
                                            {
                                                string itemlist = entryi.Key.ToLower();

                                                if (LQhecker == itemlist)
                                                {

                                                    Takenitem = $"{entryi.Key},{entryi.Value}";
                                                    break;



                                                }

                                                else
                                                {
                                                    Takenitem = "There nothing to take";


                                                }
                                            }
                                        }


                                    }
                                }
                            }
                        }
                    }
                }

            }
            return Takenitem;
        }
    }
}