using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IMutantDataAccess
    {
        public bool InsertMutantDna(DnaModel dna);
        public List<DnaModel> GetDnaByDnaPatter(string dna);
        public StatsModel GetStatsModel();
    }
}
