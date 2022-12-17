namespace Frontend.DTO
{
    public sealed record MatchFullDTO(int Id, bool IsCompleted, List<HamsterDTO> Contestants, DateTime StartDate, DateTime? EndDate, int? TId, MatchResultDTO Result);
}
