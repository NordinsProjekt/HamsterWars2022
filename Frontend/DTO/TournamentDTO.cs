namespace Frontend.DTO
{
    public sealed record TournamentDTO(int Id, string Title, List<MatchFullDTO> Matches,
        DateTime StartDate, DateTime EndDate, bool IsCompleted);
}
