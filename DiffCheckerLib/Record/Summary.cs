﻿using STBDiffChecker.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace STBDiffChecker
{
    public class Summary
    {
        public DateTime dateTime;

        public readonly static string DataGridName = "DataGridSummary";
        public readonly static string HeaderName = "概要";

        internal readonly static List<string> HeaderText = new List<string>
            {
            "項目",
            "要素数(ファイルA)",
            "要素数(ファイルB)",
            Consistency.Consistent.ToJapanese(),
            Consistency.AlmostMatch.ToJapanese(),
            Consistency.Inconsistent.ToJapanese(),
            Consistency.Incomparable.ToJapanese(),
            Consistency.ElementIncomparable.ToJapanese()
            };

        internal List<List<string>> Rows = new List<List<string>>();

        internal List<string> CollectResult(string headear, int countA, int countB, List<Record> records)
        {
            return new List<string> { 
                headear,
                countA.ToString(),
                countB.ToString(),
                records.Count(n => n.Consistency == Consistency.Consistent).ToString(),
                records.Count(n => n.Consistency == Consistency.AlmostMatch).ToString(),
                records.Count(n => n.Consistency == Consistency.Inconsistent).ToString(),
                records.Count(n => n.Consistency == Consistency.Incomparable).ToString(), 
                records.Count(n => n.Consistency == Consistency.ElementIncomparable).ToString()
            };
        }
    }
}
