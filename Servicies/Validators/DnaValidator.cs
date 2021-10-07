using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicies.Validators
{
    public class DnaValidator
    {
        private static List<char> ValidCharacters = new List<char> { 'A', 'T', 'C','G'}; 
        public bool ValidateDna(string[]dna)
        {
            if(!HasInvalidCharacters(dna)) return false ;
            return true;
        }

        private bool HasInvalidCharacters(string[] dna)
        {
          var result =   dna.ToList().Select(x => x.ToCharArray())
                            .Where(_dna => _dna.Except(ValidCharacters).Any());

            return result.Count() > 0 ? false : true;
        }
    }
}
