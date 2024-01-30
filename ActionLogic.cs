using Anderture_Game_2;
using System;
using System.Collections.Generic;

namespace Anderture_Game_2
{
    class ActionLogic
    {
        public int ActionPostion { get; set; }
        public string EventAction { get; set; }
        public int Roll { get; set; }
        public string Attackinfo { get; set; }

        public List<string> Weapong_list { get; set; }

        public List<object> Mobs { get; set; }
        public (string, int) InterAction()
        {
            Random rnd = new Random();
            GameLogic gameDescribeLogic = new GameLogic();
            RandomMobMaker mobMaker = new RandomMobMaker();

            ActionPostion = gameDescribeLogic.Positon;

            Roll = rnd.Next(1, 21);
            if (ActionPostion > -1 || ActionPostion < 7)
            {
                switch (Roll)
                {
                    case 1:
                        EventAction = "Look Around and to dark to see";
                        break;

                    case 2:
                        EventAction = "Look Around no treasure or monsters";
                        break;

                    case 3:


                        EventAction = $"Look Around there {mobMaker.Monster} in this room";
                        break;

                    case 4:


                        EventAction = "Look Around there one skeletons in this room";
                        break;

                    case 5:
                        EventAction = "Look Around you can hear something from next room";
                        break;

                    case 6:

                        mobMaker.Monster_Lab();
                        EventAction = $"Look Around the {mobMaker.Monster} in this room pop out and start attack";
                        break;

                    case 7:
                        EventAction = "Look Around find a small chest";
                        break;

                    case 8:

                        mobMaker.Monster_Lab();
                        EventAction = $"Look Around see a {mobMaker.Monster} sitting on ground";
                        break;

                    case 9:
                        mobMaker.Monster_Lab();
                        EventAction = $"Look Around see a {mobMaker.Monster} grab you from behind";
                        break;

                    case 10:
                        EventAction = "Look Around see a dead ghoul slice in peice with a sword in it back";
                        break;

                    case 11:
                        EventAction = "Look Around see sword slight glowing";
                        break;

                    case 12:
                        EventAction = "Look Around see a box";
                        break;

                    case 13:
                        EventAction = "You look around think about Josh and Red having ***";
                        break;

                    case 14:
                        EventAction = "Look Around images on wall about cultist's name is Gorgus";
                        break;

                    case 15:
                        EventAction = "Look Around see paper on ground saying something about Gorgus being a member of the Cult of Durgon";
                        break;

                    case 16:
                        EventAction = "Look Around find a Journal about how Gorgus and Cult of Durgon try bring back there dead master and something about a cleric Davos skull";
                        break;

                    case 17:
                        EventAction = "Look Around find cleric Davos Skull";
                        break;

                    case 18:
                        EventAction = "Look to right. Wow you looked";
                        break;

                    case 19:
                        EventAction = "Look Around Skeleton knight on right wall with old chains on it";
                        break;

                    case 20:
                        EventAction = "Look Around see only walls and doors";
                        break;
                }
            }
            return (EventAction, Roll);
        }
    }
}