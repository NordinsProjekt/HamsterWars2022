using Microsoft.JSInterop;
using Frontend.DTO;

namespace Frontend.Pages
{
    public partial class Galleri
    {
        public List<HamsterDTO>? galleryList;
        public HamsterDTO? infoHamster;
        public List<HamsterDTO> hamsterKilled = new();
        public bool ShowInputField { get; set; } = false;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            galleryList = await JS.InvokeAsync<List<HamsterDTO>>("getAPI", "https://localhost:7232/hamsters");
            StateHasChanged();
        }

        public async Task ShowMore(int id)
        {
            hamsterKilled.Clear();
            infoHamster = galleryList.FirstOrDefault(x => x.Id == id);
            var result = await JS.InvokeAsync<int[]>("getAPI", "https://localhost:7232/Defeated/" + infoHamster.Id);
            for (int i = 0; i < result.Length; i++)
            {
                var hamster = await JS.InvokeAsync<HamsterDTO>("getAPI", "https://localhost:7232/hamsters/" + result[i]);
                hamsterKilled.Add(hamster);
            }
            await JS.InvokeVoidAsync("OnScrollEvent");
            StateHasChanged();
        }

        public async Task DeleteHamster(int? id)
        {
            if (id == null || id <= 0)
                return;
            await JS.InvokeVoidAsync("delAPI", "https://localhost:7232/hamsters/" + id);
            infoHamster = null;
            StateHasChanged();
        }
        public void ShowCreateHamster()
        {
            ShowInputField = true;
            infoHamster = null;
        }
        public async Task CreateHamsterObjekt(CreateHamsterDTO hamster)
        {
            await JS.InvokeVoidAsync("postAPI", "https://localhost:7232/hamsters/", hamster);
            ShowInputField = false;
        }
    }
}
