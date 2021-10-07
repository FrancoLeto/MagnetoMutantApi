using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MutantDataAccess : IMutantDataAccess
    {
        private readonly MutantDbContext _dbContext;

        public MutantDataAccess(MutantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool InsertMutantDna(DnaModel dna)
        {
            try
            {
                _dbContext.Dnas.Add(dna);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<DnaModel> GetDnaByDnaPatter(string dna)
        {
            return _dbContext.Dnas.Where(x => x.dna.Contains(dna)).ToList();
        }

        public StatsModel GetStatsModel()
        {
            StatsModel statsModel = new StatsModel();
            statsModel.CountHumanDna = _dbContext.Dnas.Where(dna => !dna.isMutant).Count();
            statsModel.CountMutantDna = _dbContext.Dnas.Where(dna => dna.isMutant).Count();
            statsModel.ration = statsModel.CountMutantDna / (statsModel.CountHumanDna + statsModel.CountMutantDna);
            return statsModel;
        }

    }
}
