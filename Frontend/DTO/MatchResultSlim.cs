namespace Frontend.DTO
{
    public sealed record MatchResultSlimDTO(int MatchId, HamsterMiniDTO Winner, int WinnerScore, HamsterMiniDTO Looser, int LooserScore);
}
