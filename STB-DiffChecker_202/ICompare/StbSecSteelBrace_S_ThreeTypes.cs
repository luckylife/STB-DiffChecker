﻿using DiffCheckerLib.Enum;
using DiffCheckerLib.Interface;
using DiffCheckerLib.Setting;
using System.Collections.Generic;
using System.Reflection;

namespace ST_BRIDGE202
{
    public partial class StbSecSteelBrace_S_ThreeTypes : ICompare, IProperty
    {
        public bool CompareTo(object obj, IST_BRIDGE istbA, IST_BRIDGE istbB)
        {
            return obj is StbSecSteelBrace_S_ThreeTypes other && pos == other.pos;
        }

        public IEnumerable<string> GetKey(IST_BRIDGE istb)
        {
            return [$"pos={pos}"];
        }

        public bool IsSpecial(PropertyInfo info)
        {
            return info.Name == "shape";
        }

        public void CompareProperty(PropertyInfo info, IST_BRIDGE istbA, object objB, IST_BRIDGE istbB, string parentElement, List<string> key, List<DiffCheckerLib.Record> records, Dictionary<string, Importance> importanceDict, IToleranceSetting toleranceSetting)
        {
            if (info.Name == "shape")
            {
                // @shape=>/StbSecSteel
                parentElement += "=>/StbSecSteel";
                List<string> newKey = new List<string>(key) { $"shape={shape}" };
                StbSecSteelColumn_S_NotSame.CompareSteelShape(parentElement, info, this, istbA, objB, istbB, newKey, records, importanceDict, toleranceSetting);
            }
        }
    }
}