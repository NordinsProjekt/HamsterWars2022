using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record MatchResultDTO(int MatchId, HamsterDTO Winner, int WinnerScore, HamsterDTO Looser, int LooserScore);
}
