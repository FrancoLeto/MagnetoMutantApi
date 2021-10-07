using DataAccess;

namespace Servicies
{
    public class StatsService : IStatsService
    {
        private readonly IMutantDataAccess _mutantDataAccess;
        public StatsService(IMutantDataAccess mutantDataAccess)
        {
            _mutantDataAccess = mutantDataAccess;
        }

        public StatsModel GetStats()
        {
            return _mutantDataAccess.GetStatsModel();
        }
    }
}
