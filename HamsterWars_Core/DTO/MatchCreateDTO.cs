using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record MatchCreateDTO(int Hamster1Id, int Hamster2Id, 
            DateTime StartDate, DateTime? EndDate);
}
