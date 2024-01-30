using System;

namespace Anderture_Game_2
{
    class RandomMobMaker
    {
        public string randomNumberMob { get; set; }
        public string randomWeapon { get; set; }
        public string[,] WeaponsShield_array { get; set; }
        public string Amountmobs { get; set; }
        public string[,] Monster_array { get; set; }
        public string Monster { get; set; }
        public string[,] WeaponsShieldCreate()
        {
            string[,] WeaponsShields_array =
            {
                {"Stick", "2"},
                {"Sword", "4"},
                {"Mace","3"},
                {"Spear","5"},
                {"Bow","3"},
                {"Shield", "-1"},
                {"Hand", "0"},
            };
            WeaponsShield_array = WeaponsShields_array;
            return WeaponsShield_array;
        }
        public string randomAmount()
        {
            Random rnd = new Random();
            var holder = rnd.Next(0, 3);
            Amountmobs = holder.ToString();

            return Amountmobs;
        }
        public string randomMob()
        {
            Random rnd = new Random();
            var holder = rnd.Next(0, 2);
            randomNumberMob = holder.ToString();
            return randomNumberMob;
        }
        public string randomWeapons()
        {
            Random rnd = new Random();
            var holder = rnd.Next(0, 6);
            randomWeapon = holder.ToString();
            return randomWeapon;
        }
        public string[,] MonsterCreation()
        {
            string[,] Monster_arrays = {

                {"Skeleton", "10"},
                {"Ghoul", "20"},
                {"Skeleton Knight", "30"},
            };
            Monster_array = Monster_arrays;
            return Monster_array;
        }
        public string Monster_Lab()
        {
            Random rnd = new Random();
            randomWeapons();
            randomAmount();
            randomMob();
            WeaponsShieldCreate();
            MonsterCreation();
            int intholdert = int.Parse(randomNumberMob);
            int intholderw = int.Parse(randomWeapon);
            var intholderT = 0;
            var intholderW = 0;


            string Enemy = Monster_array[intholdert, intholderT] + ' ' + Monster_array[intholdert, 1] + ' ' + WeaponsShield_array[intholderw, intholderW] + ' ' + WeaponsShield_array[intholderw, 1];

            Monster = Enemy;



            return Monster;
        }
    }
}
