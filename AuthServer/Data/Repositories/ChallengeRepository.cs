using Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ChallengeRepository: IChallengeRepository
    {
        private readonly DataContext _context;
        public ChallengeRepository(DataContext context)
        {
            _context = context;

        }
    }
}
