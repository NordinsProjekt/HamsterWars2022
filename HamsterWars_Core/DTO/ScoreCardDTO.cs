﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record ScoreCardDTO(int ChallengerWins, int DefenderWins, HamsterDTO Challenger, HamsterDTO Defender);
}
