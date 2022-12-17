using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record MatchFullDTO(int Id,bool IsCompleted, List<HamsterDTO> Contestants, DateTime StartDate, DateTime? EndDate, int? TId, MatchResultDTO Result);
}
