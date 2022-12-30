using Microsoft.JSInterop;
using Frontend.DTO;


namespace Frontend.Pages
{
    public partial class Galleri
    {
        public List<HamsterDTO>? galleryList { get; set; } = new List<HamsterDTO>();
        public HamsterDTO? infoHamster { get; set; }
        public List<HamsterMiniDTO> hamsterKilled { get; set; } = new List<HamsterMiniDTO>();
        public bool ShowInputField { get; set; } = false;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                galleryList = await JS.InvokeAsync<List<HamsterDTO>>("getAPI", "https://localhost:7232/hamsters");
                StateHasChanged();
            }
        }

        public async Task ShowMore(int id)
        {
            hamsterKilled.Clear();
            var h = await JS.InvokeAsync<HamsterDTO>("getAPI", "https://localhost:7232/hamsters/" + id);
            if (h != null) 
            { 
                infoHamster = h;
                hamsterKilled = await JS.InvokeAsync<List<HamsterMiniDTO>>("getAPI", "https://localhost:7232/Defeated/" + infoHamster.Id);
            }
            await JS.InvokeVoidAsync("OnScrollEvent");
            StateHasChanged();
        }

        public async Task DeleteHamster(int? id)
        {
            if (id == null || id <= 0)
                return;
            await JS.InvokeVoidAsync("delAPI", "https://localhost:7101/hamster/" + id);
            infoHamster = null;
            galleryList = await JS.InvokeAsync<List<HamsterDTO>>("getAPI", "https://localhost:7232/hamsters");
            StateHasChanged();
        }
        public void ShowCreateHamster()
        {
            ShowInputField = true;
            infoHamster = null;
            StateHasChanged();
        }

        public void CloseCreateHamster()
        {
            ShowInputField = false;
            StateHasChanged();
        }
        public async Task CreateHamsterObjekt(CreateHamsterDTO hamster)
        {
            await JS.InvokeVoidAsync("postAPI", "https://localhost:7101/hamsters", hamster);
            ShowInputField = false;
        }
    }
}
