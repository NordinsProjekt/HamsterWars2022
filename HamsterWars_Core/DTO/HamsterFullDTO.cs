using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record HamsterFullDTO(int Id, string Name, int Age, string FavFood, string Loves, string ImgName, int Wins, int Losses, int Games, List<MatchDTO> Matches);
}