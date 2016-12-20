using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCode
{
    public class CommonCode
    {
        public object GetMatchedObject(string MatchedString, Dictionary<object, string[]> d2dMatchables)
        {
            foreach (KeyValuePair<object, string[]> vPair in d2dMatchables)
            {
                foreach (string sString in vPair.Value)
                {
                    if (sString == MatchedString)
                    {
                        return vPair.Key;
                    }
                }
            }
            return null;
        }
        public string GetPatternFromMatchables(Dictionary<object, string[]> d2dMatchables)
        {
            bool bDoOnce = false;
            string sPattern;
            foreach (KeyValuePair<object, string[]> vPair in d2dMatchables)
            {
                foreach (string sString in vPair.Value)
                {
                    if (!bDoOnce)
                    {
                        bDoOnce = true;
                        sPattern += "|";
                    }
                    sPattern += sString;
                }
            }
            return "\b("+sPattern+")\b";
        }
    }
}
