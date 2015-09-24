using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeraBot
{
    class offsets
    {
        public static int[] CurrentHP = new int[] { 0x14, 0x40, 0x10, 0x48 };
        public static int[] FullHP = new int[] { 0x14, 0x40, 0x10, 0x58 };
        public static int[] CurrentMP = new int[] { 0x14, 0x40, 0x10, 0x78 };
        public static int[] FullMP = new int[] { 0x14, 0x40, 0x10, 0x88 };

        public static int[] PosX = new int[] { 0x14, 0x40, 0x10, 0xC };
        public static int[] PosY = new int[] { 0x14, 0x40, 0x10, 0x10 };
        public static int[] PosZ = new int[] { 0x14, 0x40, 0x10, 0x14 };

        public static int[] Range = new int[] { 0x14, 0x418, 0x2d0, 0x28 };
    } 
}
