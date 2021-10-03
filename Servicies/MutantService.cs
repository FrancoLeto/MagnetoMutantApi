using Servicies.Validators;
using System;
using System.Linq;

namespace Servicies
{
    public class MutantService : DnaValidator
    {
        public bool IsMutant(string[] dna)
        {
            if(!ValidateDna(dna)) return false;

            if (CheckHorizontalPattern(dna)) return true;
            if (CheckVerticalPattern(dna)) return true;
            if (CheckDiagonalPattern(dna)) return true;

            return false;
        }

        private bool CheckHorizontalPattern(string[] dna)
        {
            foreach (var dnaString in dna)
            {
                var dnaStringArray = dnaString.ToCharArray();
                for (int x = 0; x < dnaStringArray.Length; x++)
                {
                    if (x + 3 > dnaStringArray.Length) break;

                    if (dnaStringArray[x] == dnaStringArray[x + 1]
                       && dnaStringArray[x + 1] == dnaStringArray[x + 2]
                       && dnaStringArray[x + 2] == dnaStringArray[x + 3])
                        return true;
                }

            }
            return false;
        }

        private bool CheckVerticalPattern(string[] dna)
        {
            var dnaSplited = dna.ToList().Select(x => x.ToCharArray()).ToArray();
            for (int x = 0; x < dna.Length; x++)
            {
                for (int y = 0; y < dnaSplited.Length; y++)
                {
                    //TODO: Check validation below
                    if (x + 3 > dna.Length) break;
                    if (dnaSplited[x][y] == dnaSplited[x + 1][y]
                       && dnaSplited[x + 1][y] == dnaSplited[x + 2][y]
                       && dnaSplited[x + 2][y] == dnaSplited[x + 3][y])
                        return true;
                }
            }

            return false;
        }

        private bool CheckDiagonalPattern(string[] dna)
        {
            var dnaSplited = dna.ToList().Select(x => x.ToCharArray()).ToArray();
            for (int x = 0; x < dna.Length; x++)
            {
                for (int y = 0; y < dnaSplited.Length; y++)
                {
                    //TODO: Check validation below, add validation for Y

                    if (x + 3 > dna.Length) break;

                    if (dnaSplited[x][y] == dnaSplited[x + 1][y + 1]
                       && dnaSplited[x + 1][y + 1] == dnaSplited[x + 2][y + 2]
                       && dnaSplited[x + 2][y + 2] == dnaSplited[x + 3][y + 3])
                        return true;
                }
            }
            return false;
        }
    }
}
