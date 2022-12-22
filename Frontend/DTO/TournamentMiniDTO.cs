namespace Frontend.DTO
{
    public sealed record TournamentMiniDTO(int Id, string Title, DateTime StartDate, DateTime EndDate, bool IsCompleted, int NumberOfConsestants);
}
