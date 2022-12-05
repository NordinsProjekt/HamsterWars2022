using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record HamsterCreateDTO(string Name, int Age, string FavFood, string Loves, string ImgName, int Wins, int Losses, int Games);
}
