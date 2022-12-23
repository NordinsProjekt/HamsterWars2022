using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record MatchResultSlimDTO(int MatchId, HamsterMiniDTO Winner, int WinnerScore, HamsterMiniDTO Looser, int LooserScore);
}
