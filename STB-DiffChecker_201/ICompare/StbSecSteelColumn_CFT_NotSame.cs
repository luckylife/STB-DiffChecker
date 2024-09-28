﻿using DiffCheckerLib;
using DiffCheckerLib.Enum;
using DiffCheckerLib.Interface;
using System.Reflection;

namespace ST_BRIDGE201
{
    public partial class StbSecSteelColumn_CFT_NotSame : ICompare, IProperty
    {
        public bool CompareTo(object obj, IST_BRIDGE istbA, IST_BRIDGE istbB)
        {
            return obj is StbSecSteelColumn_CFT_NotSame other && pos == other.pos;
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

        public static void CompareSteelShape(string elementKey, PropertyInfo info, object objA, IST_BRIDGE istbA, object objB, IST_BRIDGE istbB, List<string> key, List<DiffCheckerLib.Record> records, Dictionary<string, Importance> importanceDict, IToleranceSetting toleranceSetting)
        {
            ST_BRIDGE? stbA = istbA as ST_BRIDGE;
            ST_BRIDGE? stbB = istbB as ST_BRIDGE;

            StbSecRollH? rollHA = null;
            foreach (StbSecRollH sec in stbA.StbModel.StbSections.StbSecSteel.StbSecRollH)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    rollHA = sec;
                    break;
                }
            }
            StbSecRollH? rollHB = null;
            foreach (StbSecRollH sec in stbB.StbModel.StbSections.StbSecSteel.StbSecRollH)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    rollHB = sec;
                    break;
                }
            }
            if (rollHA != null || rollHB != null)
            {
                ObjectComparer.CompareProperties(rollHA, stbA, rollHB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecBuildH? buildHA = null;
            foreach (StbSecBuildH sec in stbA.StbModel.StbSections.StbSecSteel.StbSecBuildH)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    buildHA = sec;
                    break;
                }
            }
            StbSecBuildH? buildHB = null;
            foreach (StbSecBuildH sec in stbB.StbModel.StbSections.StbSecSteel.StbSecBuildH)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    buildHB = sec;
                    break;
                }
            }
            if (buildHA != null || buildHB != null)
            {
                ObjectComparer.CompareProperties(buildHA, stbA, buildHB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecRollBOX? rollBoxA = null;
            foreach (StbSecRollBOX sec in stbA.StbModel.StbSections.StbSecSteel.StbSecRollBOX)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    rollBoxA = sec;
                    break;
                }
            }
            StbSecRollBOX? rollBoxB = null;
            foreach (StbSecRollBOX sec in stbB.StbModel.StbSections.StbSecSteel.StbSecRollBOX)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    rollBoxB = sec;
                    break;
                }
            }
            if (rollBoxA != null || rollBoxB != null)
            {
                ObjectComparer.CompareProperties(rollBoxA, stbA, rollBoxB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecBuildBOX? buildBoxA = null;
            foreach (StbSecBuildBOX sec in stbA.StbModel.StbSections.StbSecSteel.StbSecBuildBOX)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    buildBoxA = sec;
                    break;
                }
            }
            StbSecBuildBOX? buildBoxB = null;
            foreach (StbSecBuildBOX sec in stbB.StbModel.StbSections.StbSecSteel.StbSecBuildBOX)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    buildBoxB = sec;
                    break;
                }
            }
            if (buildBoxA != null || buildBoxB != null)
            {
                ObjectComparer.CompareProperties(buildBoxA, stbA, buildBoxB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecPipe? pipeA = null;
            foreach (StbSecPipe sec in stbA.StbModel.StbSections.StbSecSteel.StbSecPipe)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    pipeA = sec;
                    break;
                }
            }
            StbSecPipe? pipeB = null;
            foreach (StbSecPipe sec in stbB.StbModel.StbSections.StbSecSteel.StbSecPipe)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    pipeB = sec;
                    break;
                }
            }
            if (pipeA != null || pipeB != null)
            {
                ObjectComparer.CompareProperties(pipeA, stbA, pipeB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecRollT? rollTA = null;
            foreach (StbSecRollT sec in stbA.StbModel.StbSections.StbSecSteel.StbSecRollT)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    rollTA = sec;
                    break;
                }
            }
            StbSecRollT? rollTB = null;
            foreach (StbSecRollT sec in stbB.StbModel.StbSections.StbSecSteel.StbSecRollT)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    rollTB = sec;
                    break;
                }
            }
            if (rollTA != null || rollTB != null)
            {
                ObjectComparer.CompareProperties(rollTA, stbA, rollTB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecRollC? rollCA = null;
            foreach (StbSecRollC sec in stbA.StbModel.StbSections.StbSecSteel.StbSecRollC)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    rollCA = sec;
                    break;
                }
            }
            StbSecRollC? rollCB = null;
            foreach (StbSecRollC sec in stbB.StbModel.StbSections.StbSecSteel.StbSecRollC)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    rollCB = sec;
                    break;
                }
            }
            if (rollCA != null || rollCB != null)
            {
                ObjectComparer.CompareProperties(rollCA, stbA, rollCB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecRollL? rollLA = null;
            foreach (StbSecRollL sec in stbA.StbModel.StbSections.StbSecSteel.StbSecRollL)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    rollLA = sec;
                    break;
                }
            }
            StbSecRollL? rollLB = null;
            foreach (StbSecRollL sec in stbB.StbModel.StbSections.StbSecSteel.StbSecRollL)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    rollLB = sec;
                    break;
                }
            }
            if (rollLA != null || rollLB != null)
            {
                ObjectComparer.CompareProperties(rollLA, stbA, rollLB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecLipC? lipCA = null;
            foreach (StbSecLipC sec in stbA.StbModel.StbSections.StbSecSteel.StbSecLipC)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    lipCA = sec;
                    break;
                }
            }
            StbSecLipC? lipCB = null;
            foreach (StbSecLipC sec in stbB.StbModel.StbSections.StbSecSteel.StbSecLipC)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    lipCB = sec;
                    break;
                }
            }
            if (lipCA != null || lipCB != null)
            {
                ObjectComparer.CompareProperties(lipCA, stbA, lipCB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecFlatBar? flatBarA = null;
            foreach (StbSecFlatBar sec in stbA.StbModel.StbSections.StbSecSteel.StbSecFlatBar)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    flatBarA = sec;
                    break;
                }
            }
            StbSecFlatBar? flatBarB = null;
            foreach (StbSecFlatBar sec in stbB.StbModel.StbSections.StbSecSteel.StbSecFlatBar)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    flatBarB = sec;
                    break;
                }
            }
            if (flatBarA != null || flatBarB != null)
            {
                ObjectComparer.CompareProperties(flatBarA, stbA, flatBarB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

            StbSecRoundBar? roundBarA = null;
            foreach (StbSecRoundBar sec in stbA.StbModel.StbSections.StbSecSteel.StbSecRoundBar)
            {
                if (sec.name == info.GetValue(objA).ToString())
                {
                    roundBarA = sec;
                    break;
                }
            }
            StbSecRoundBar? roundBarB = null;
            foreach (StbSecRoundBar sec in stbB.StbModel.StbSections.StbSecSteel.StbSecRoundBar)
            {
                if (sec.name == info.GetValue(objB).ToString())
                {
                    roundBarB = sec;
                    break;
                }
            }
            if (roundBarA != null || roundBarB != null)
            {
                ObjectComparer.CompareProperties(roundBarA, stbA, roundBarB, stbB, elementKey, key, records, importanceDict, toleranceSetting);
                return;
            }

        }
    }
}