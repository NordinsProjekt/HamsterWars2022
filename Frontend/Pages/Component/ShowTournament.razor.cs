using Microsoft.AspNetCore.Components;
using Frontend.DTO;

namespace Frontend.Pages.Component
{
    public partial class ShowTournament
    {
        [Parameter]
        public TournamentDTO? tour { get; set; }
        public List<List<MatchFullDTO>> bracket = new();

        public void MakeBrackets() //Måste städa denna
        {
            bracket.Clear();
            int numMatches = tour.Matches.Count;
            int maxBrackets = numMatches / 2;
            int numBrackets = (maxBrackets <= 0) ? 3 : 3 + maxBrackets;

            for (int i = 0; i < numBrackets; i++)
                bracket.Add(new List<MatchFullDTO>());

            int listCount2 = tour.NumberOfConsestants / 4;
            int currentIndex = 0;
            for (int i = 1; i <= bracket.Count; i++)
            {
                if (listCount2 == 0)
                {
                    bracket[i-1] = tour.Matches.OrderBy(x => x.TId).Skip(currentIndex).Take(1).ToList();
                    break;
                }
                bracket[i-1] = tour.Matches.OrderBy(x => x.TId).Skip(currentIndex).Take(listCount2).ToList();
                currentIndex += listCount2;
                bracket[bracket.Count - i] = tour.Matches.OrderBy(x => x.TId).Skip(currentIndex).Take(listCount2).ToList();
                currentIndex += listCount2;
                listCount2 = listCount2 / 2;
            }
        }
    }
}
