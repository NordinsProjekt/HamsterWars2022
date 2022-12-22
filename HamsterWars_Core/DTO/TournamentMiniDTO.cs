﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record TournamentMiniDTO(int Id, string Title, DateTime StartDate, DateTime EndDate, bool IsCompleted, int NumberOfConsestants);
}
