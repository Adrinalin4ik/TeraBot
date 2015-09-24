using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeraBot
{
    class Hero
    {
        public static int CurrentHp;
        public static int CurrentMp;
        public static int FullHp;
        public static int FullMp;
        public static int PosX, PosY, PosZ;
         
        //enemy
        public static int Range;
        public static bool target = false;
        public static int mobCount=0;
        public static int attackRange;
    }
}
