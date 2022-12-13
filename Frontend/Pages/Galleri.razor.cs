using Microsoft.JSInterop;
using Frontend.DTO;

namespace Frontend.Pages
{
    public partial class Galleri
    {
        public List<HamsterDTO> galleryList;
        public HamsterDTO infoHamster;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            galleryList = await JS.InvokeAsync<List<HamsterDTO>>("getAPI", "https://localhost:7232/hamsters");
            StateHasChanged();
        }

        public async void ShowMore(int id)
        {
            infoHamster = galleryList.Where(x => x.Id == id).FirstOrDefault();
            await JS.InvokeVoidAsync("OnScrollEvent");
            StateHasChanged();
        }
    }
}
