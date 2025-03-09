using Core.IRepositories;
using Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VoteService: IVoteService
    {
        private readonly IVoteRepository _voteRepository;
        public VoteService(IVoteRepository voteRepository)
        {
            _voteRepository = voteRepository;  
        }
    }
}
