using Microsoft.JSInterop;
using Frontend.DTO;

namespace Frontend.Pages
{
    public partial class Galleri
    {
        public List<HamsterDTO> galleryList;
        public HamsterDTO infoHamster;
        public List<HamsterDTO> hamsterKilled = new List<HamsterDTO>();
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            galleryList = await JS.InvokeAsync<List<HamsterDTO>>("getAPI", "https://localhost:7232/hamsters");
            StateHasChanged();
        }

        public async void ShowMore(int id)
        {
            infoHamster = galleryList.Where(x => x.Id == id).FirstOrDefault();
            var result = await JS.InvokeAsync<int[]>("getAPI", "https://localhost:7232/Defeated/" + infoHamster.Id);
            for (int i = 0; i < result.Length; i++)
            {
                var hamster = await JS.InvokeAsync<HamsterDTO>("getAPI", "https://localhost:7232/hamsters/" + result[i]);
                hamsterKilled.Add(hamster);
            }
            await JS.InvokeVoidAsync("OnScrollEvent");
            StateHasChanged();
        }
    }
}
