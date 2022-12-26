namespace Frontend.DTO
{
    public sealed record MatchDTO(int Id, List<HamsterDTO> Contestants , MatchResultDTO Result);
}
