namespace Frontend.DTO
{
    public sealed record MatchCreateDTO(int Hamster1Id, int Hamster2Id,
            DateTime StartDate, DateTime? EndDate);
}
