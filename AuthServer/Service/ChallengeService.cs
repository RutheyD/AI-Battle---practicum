using Core.IRepositories;
using Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ChallengeService:IChallengeService
    {
        private readonly IChallengeRepository _challengeRepository;
        public ChallengeService(IChallengeRepository challengeRepository)
        {
            _challengeRepository = challengeRepository;     
        }
    }
}
