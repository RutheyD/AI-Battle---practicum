using Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class VoteRepository: IVoteRepository
    {
        private readonly DataContext _context;
        public VoteRepository(DataContext context)
        {
            _context = context;

        }
    }
}
