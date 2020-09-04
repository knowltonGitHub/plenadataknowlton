using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlenaDataTest
{
    public class StringManip
    {
        public StringManip(string tempstring)
        {
            OrigString = tempstring;
            _charinstdata = new List<CharacterInstanceData>() { };
        }

        private string _tempOrigString;
        private List<CharacterInstanceData> _charinstdata;
        private string _rewrittenString;

        public string OrigString
        {
            get { return _tempOrigString; }
            set { _tempOrigString = value; }
        }

        public string RewrittenString
        {
            get { return _rewrittenString; }
            set { _rewrittenString = value; }
        }

        public List<CharacterInstanceData> CharInstanceData
        {
            get { return _charinstdata; }
            set { _charinstdata = value; }
        }

        public char GetFirstNonRepeatingChar()
        {
            char origchar = '\0';

            foreach (CharacterInstanceData tempCID in CharInstanceData)
            {
                if(tempCID.Occurrences == 1)
                {
                    origchar = tempCID.Character;
                    break;
                }
            }

            return origchar;
        }

        public void AnalyzeLetterRepetition()
        {
            int posInString = 0;

            foreach(char c in OrigString)
            {
                CharInstanceData.Add(new CharacterInstanceData(c, 0, posInString));
                posInString++;
            }

            for (int i = 0; i < CharInstanceData.Count; i++)
            {
                CharInstanceData[i].Occurrences = GetOccurrencesCount(CharInstanceData[i].Character);
            }
        }

        private string AddChar(int occurrences)
        {
            string useString = "";

            for (int i = 0; i < CharInstanceData.Count; i++)
            {
                if (CharInstanceData[i].Occurrences == occurrences)
                {
                    useString += CharInstanceData[i].Character.ToString();
                }
            }

            return useString;
        }
        public string RewriteTheString()
        {
            RewrittenString = "";


            for (int i = 0; i < CharInstanceData.Count; i++)
            {
                RewrittenString += AddChar(i);
            }

            return RewrittenString;

        }

        private int GetOccurrencesCount(char c)
        {
            int occurrenceCount = 0;
            char currentCharToUpper = '\0';

            char tempcharToUpper = c.ToString().ToUpper().ToCharArray()[0];

            foreach (CharacterInstanceData tempcid in CharInstanceData)
            {
                currentCharToUpper = tempcid.Character.ToString().ToUpper().ToCharArray()[0];

                if(currentCharToUpper == tempcharToUpper)
                {
                    occurrenceCount++;
                }
            }

            return occurrenceCount;
        }
    }

    public class CharacterInstanceData
    {
        public CharacterInstanceData(char tempOriginalChar, int tempOccurrences, int tempPosition) 
        {
            _originalchar = tempOriginalChar;
            _occurrences = tempOccurrences;
            _position = tempPosition;
        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public int Occurrences
        {
            get { return _occurrences; }
            set { _occurrences = value; }
        }

        public char Character
        {
            get { return _originalchar; }
            set { _originalchar = value; }
        }

        public void IncrementOccurrenceCount()
        {
            _occurrences++;
        }

        private char _originalchar;
        private int _occurrences;
        private int _position;
    }
}
