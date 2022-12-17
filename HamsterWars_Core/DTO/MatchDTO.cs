using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record MatchDTO(int Id, List<HamsterDTO> Contestants,MatchResultDTO Result);   
}
