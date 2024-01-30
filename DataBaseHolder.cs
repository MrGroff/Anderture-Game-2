using Anderture_Game_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Anderture_Game_2
{
    class DataBaseHolder
    {
        public Dictionary<string, string> UserInputHolder { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> PlayerItemHolder { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> ItemDatabaseHolder { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> LookQuestlogRoom { get; set; } = new Dictionary<string, string>();

        public string Takenitem { get; set; }
        public int RoomHolder { get; set; }
        public string[] RoomHolderlist { get; set; }
        public string ActionPostion { get; set; }
        public int Positon { get; set; }
        public string Writen { get; set; }

        public string LookQuestLog { get; set; }


        public void QuestlogExtractionwriter(string Questlog, int Positon)
        {
            GameLogic gameDescribeLogic = new GameLogic();

            Positon = gameDescribeLogic.Positon;
            string LookQuestlog = Questlog + "," + Positon;
            File.WriteAllText(@"./LookQuestlog.txt", LookQuestlog);

            Console.WriteLine(LookQuestlog);
        }
        public Dictionary<string, string> QuestlogExtraction()
        {

            LookQuestlogRoom = File.ReadAllLines(@"./LookQuestlog.txt")
                                       .Select(x => x.Split(','))
                                       .ToDictionary(x => x[0], x => x[1]);
            return LookQuestlogRoom;
        }
        public Dictionary<string, string> phaseExtraction()
        {

            UserInputHolder = File.ReadAllLines(@"./PhaseHolder.txt")
                                       .Select(x => x.Split(','))
                                       .ToDictionary(x => x[0], x => x[1]);
            return UserInputHolder;
        }
        public Dictionary<string, string> playerItemExtraction()
        {
            PlayerItemHolder = File.ReadAllLines(@"./Playeritems.txt")
                                       .Select(x => x.Split(','))
                                       .ToDictionary(x => x[0], x => x[1]);
            return PlayerItemHolder;
        }

        public Dictionary<string, string> itemExtraction()
        {
            ItemDatabaseHolder = File.ReadAllLines(@"./Items.txt")
                .Select(x => x.Split(','))
                .ToDictionary(x => x[0], x => x[1]); ;

            return ItemDatabaseHolder;
        }
        public void PlayeritemExtractionwriter(string item)
        {
            GameLogic gameDescribeLogic = new GameLogic();

            string additem = item;
            File.AppendAllText(@"./Playeritems.txt", additem);

            Console.WriteLine(Takenitem);
        }
        public void roomExtractionwriter()
        {
            GameLogic gameDescribeLogic = new GameLogic();

            ActionPostion = Positon.ToString() + ",";
            File.WriteAllText(@"./RoomHolder.txt", ActionPostion);

            //Console.WriteLine(ActionPostion);
        }
        public int roomExtractionreader()
        {
            GameLogic gameDescribeLogic = new GameLogic();


            RoomHolderlist = File.ReadAllLines(@"./RoomHolder.txt")
                 .Select(x => x.Split(',')).Last();

            RoomHolder = int.Parse(RoomHolderlist[0]);


            return RoomHolder;
        }
        public void Reset()
        {
            string playeritem = "Stick,2";
            string resetholder = "9,";
            File.WriteAllText(@"./RoomHolder.txt", string.Empty);
            File.WriteAllText(@"./RoomHolder.txt", resetholder);
            File.WriteAllText(@"./Playeritems.txt", playeritem);


        }
    }
}
