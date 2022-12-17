namespace Frontend.DTO
{
    public sealed record MatchResultDTO(int MatchId, HamsterDTO Winner, int WinnerScore, HamsterDTO Looser, int LooserScore);
}
