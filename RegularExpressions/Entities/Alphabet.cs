using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions.Entities
{
    class Alphabet
    {

        public List<String> Symbols { get; set; }

        public Alphabet()
        {
            Symbols = new List<String>();
        }

        public Alphabet(String[] symbols)
        {
            Symbols = new List<String>();
            Symbols.AddRange(symbols);
        }

        // Insert Symbol
        public void InsertSymbol(String symbol)
        {
            Symbols.Add(symbol);
        }
        
        // Delete symbol
        public bool DeleteSymbol(String symbol)
        {
            return Symbols.Remove(symbol);
        }
        
        // Get symbol position
        public int ExistsOnList(String symbol)
        {

            for (int i = 0; i < Symbols.Count; i++)
            {
                if (Symbols[i].Equals(symbol))
                {
                    return i;
                }
            }

            return -1;
        }

        //Overriding ToString Method
        public override string ToString()
        {

            String returnString = "{ ";

            for (int i = 0; i < Symbols.Count; i++)
            {
                returnString += Symbols[i] + " ";
            }

            returnString += " }";

            return returnString;
        }
    }
}
