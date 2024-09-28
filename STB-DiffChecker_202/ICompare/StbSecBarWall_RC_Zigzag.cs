﻿using DiffCheckerLib;
using DiffCheckerLib.Interface;
using DiffCheckerLib.Setting;
using System.Collections.Generic;

namespace ST_BRIDGE202
{
    public partial class StbSecBarWall_RC_Zigzag : ICompare
    {
        public bool CompareTo(object obj, IST_BRIDGE istbA, IST_BRIDGE istbB)
        {
            return obj is StbSecBarWall_RC_Zigzag other && pos == other.pos;
        }

        public IEnumerable<string> GetKey(IST_BRIDGE istb)
        {
            return new List<string> { $"pos={pos}" };
        }
    }
}