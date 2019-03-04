using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions.Entities
{
    /// <summary>
    /// Language Class
    /// </summary>
    public class Language
    {

        public static string
            UNION = "UNION",
            INTERSECTION = "INTERSECTION",
            CONCATENATION = "CONCATENATION",
            DIFFERENCE = "DIFFERENCE",
            SYM_DIFFERENCE = "SYMETRIC_DIFFERENCE",
            COMPLEMENT = "COMPLEMENT",
            POWER = "POWER",
            KLEENE_CLOSURE = "KLEENE_CLOSURE",
            POSITIVE_CLOSURE = "POSITIVE_CLOSURE";

        // Since I can't use the word String cuz it's reservated
        // I'll be reffering to them as charsets, or charset

        //public Alphabet Alphabet { get; set; }

        public List<String> Charsets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Language()
        {
            Charsets = new List<String>();
        }

        public Language(String[] charsets)
        {
            Charsets = new List<String>();
            Charsets.AddRange(charsets);
            Console.WriteLine(ToString()); 
        }

        //Insert String
        public void InsertCharset(String charset)
        {
            //if (this.ExistsOnList(charset) != -1)
            //{
                Charsets.Add(charset);
            //}
        }

        //Delete String
        public void DeleteCharset(String charset)
        {
            Charsets.Remove(charset);
        }

        //Get position of String
        public int ExistsOnList(String charset)
        {
            for (int i = 0; i < Charsets.Count; i++)
            {
                if (Charsets[i].Equals(charset))
                {
                    return i;
                }
            }

            return -1;
        }

        public string GetCharsets()
        {
            return this.ToString();
        }

        // Copy method

        /// <summary>
        /// The <c>Copy()</c> method will create a copy of the original
        /// </summary>
        /// <returns></returns>

        public Language Copy()
        {
            
            var copy = new Language();

            for (int i = 0; i < this.Charsets.Count; i++)
            {
                copy.Charsets.Add(this.Charsets[i]);
            }
            
            return copy;
        }

        //
        // OPERATIONS
        //

        //
        // Potencia
        //
        public static Language Power(Language A, int n)
        {
            var result = new Language();

            var copy = A.Copy();

            for (int i = 0; i < n; i++)
            {
                result = Concatenation(copy, A);
                copy = Concatenation(copy, A);
            }

            return result;
        }

        //
        // Symetric Difference
        //
        public static Language SymetricDifference(Language A, Language B)
        {
            var result = new Language();

            result = Difference(A, B) + Difference(B, A);

            return result;
        }

        //
        // Complement
        //
        public static Language Complement(Language A, Language universe)
        {
            var result = new Language();

            Console.WriteLine("A: " + A.GetCharsets());
            Console.WriteLine("Universe: " + universe.GetCharsets());

            for (int i = 0; i < universe.Charsets.Count; i++)
            {
                if (A.ExistsOnList(universe.Charsets[i]) != -1)
                {
                    continue;
                }
                else
                {
                    result.InsertCharset(universe.Charsets[i]);
                    Console.WriteLine("I: " + i + ", result: " + result.GetCharsets());
                }
            }

            return result;
        }

        public static Language Universe(List<Language> languages, int listSize)
        {
            var result = new Language();

            foreach (Language language in languages)
            {
                result = result + language;
            }

            return result;
        }

        //
        // Difference
        //
        public static Language Difference(Language A, Language B)
        {
            var result = new Language();

            for (int i = 0; i < A.Charsets.Count; i++)
            {
                if (B.ExistsOnList(A.Charsets[i]) == -1)
                {
                    result.InsertCharset(A.Charsets[i]);
                }
            }

            return result;
        }


        //
        // Intersection
        //
        public static Language Intersection(Language languageA, Language languageB)
        {
            var result = new Language();

            String ACharset = "";

            for (int i = 0; i < languageA.Charsets.Count; i++)
            {

                ACharset = languageA.Charsets[i];

                if (languageB.ExistsOnList(ACharset) != -1)
                {
                    result.InsertCharset(ACharset);
                }
            }

            return result;
        }

        //
        // Concatenation/Product
        //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Language Concatenation(Language A, Language B)
        {
            var result = new Language();

            String ACharset = "", BCharset = "";

            for (int i = 0; i < A.Charsets.Count; i++)
            {
                ACharset = A.Charsets[i];
                for (int j = 0; j < B.Charsets.Count; j++)
                {
                    BCharset = B.Charsets[j];
                    result.InsertCharset( ( ACharset + BCharset ) );
                }
            }

            return result;
        }


        //Lately it will have to convert to Positive Kleene Closure
        // Operator Overloading, Union
        public static Language operator+ (Language A, Language B)
        {

            var result = A.Copy();
            //result.Charsets = A.Charsets;
            
            String charset;

            //Then looking for all charsets of B to see
            //if they are or not in A.
            for (int i = 0; i < B.Charsets.Count; i++)
            {

                charset = B.Charsets[i];
                
                //Since language == A, doesn't matter if I use A or language
                if (result.ExistsOnList(charset) == -1)
                {
                    result.InsertCharset(charset);
                }

            }

            return result;
        }

        //
        // Kleene Closure
        //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Language KleeneClosure(Language A, int n)
        {
            // n represents the number of times the concatenation will happen

            var language = A.Copy();

            for (int i = 0; i < n; i++)
            {
                language = language + Concatenation(A, language);
            }


            language.Charsets.Add("... INFINITE");

            // Since it's normal Closure, EMPTY should be first
            language.Charsets.Insert(0, "EMPTY");

            return language;
        }

        //
        // Positive Kleen Closure
        //
        public static Language PositiveKleeneClosure(Language A, int n)
        {
            var language = new Language();

            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    language = language + Concatenation(A, language);
                    continue;
                }
                language = language + Concatenation(A, A);
            }

            // Adding last elements
            language.Charsets.Add("... INFINITE");

            return language;
        }

        //Overriding ToString Method
        public override string ToString()
        {

            String returnString = "{ ";

            for (int i = 0; i < Charsets.Count; i++)
            {
                returnString += Charsets[i] + " ";
            }

            returnString += "}";

            return returnString;
        }

    }
}
