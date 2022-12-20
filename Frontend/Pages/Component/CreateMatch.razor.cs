using Microsoft.JSInterop;
using Frontend.DTO;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.AspNetCore.Components;

namespace Frontend.Pages.Component
{
    public partial class CreateMatch
    {
        private List<HamsterDTO>? listV;
        private List<HamsterDTO>? listH;
        private Random rnd = new();
        HamsterDTO? infoV { get; set; }
        HamsterDTO? infoH { get; set; }
        [Parameter]
        public EventCallback<int> onCreateCustomMatch { get; set; }

        public List<HamsterDTO> HamsterListV
        {
            get
            {
                if (this.listV == null)
                    return null;
                if (infoH != null)
                    return listV.Where(x => x.Id != infoH.Id).ToList();
                else
                    return listV;
            }
            set
            {
                listV = value;
            }
        }

        public List<HamsterDTO> HamsterListH
        {
            get
            {
                if (this.listH == null)
                    return null;
                if (infoV != null)
                    return listH.Where(x => x.Id != infoV.Id).ToList();
                else
                    return listH;
            }
            set
            {
                listH = value;
            }
        }
        public async Task ShowGalleryScreenV()
            => HamsterListV = await GetHamsters();
        public async Task ShowGalleryScreenH()
            => HamsterListH = await GetHamsters();


        public async Task ShowHamsterV(int id)
            => infoV = HamsterListV.FirstOrDefault(x => x.Id == id);


        public async Task ShowHamsterH(int id)
            => infoH = HamsterListH.FirstOrDefault(x => x.Id == id);

        public async Task<List<HamsterDTO>> GetHamsters()
            => await JS.InvokeAsync<List<HamsterDTO>>("getAPI", "https://localhost:7232/hamsters/");
        public async Task RndHamsterV()
        {
            if (HamsterListV == null || HamsterListH == null)
            {
                var result = await GetHamsters();
                HamsterListH = result;
                HamsterListV = result;
            }
            infoV = HamsterListV.ElementAt(rnd.Next(HamsterListV.Count()));
        }

        public async Task RndHamsterH()
        {
            if (HamsterListV == null || HamsterListH == null)
            {
                var result = await GetHamsters();
                HamsterListH = result;
                HamsterListV = result;
            }
            infoH = HamsterListH.ElementAt(rnd.Next(HamsterListH.Count()));
        }

        public async Task CreateCustomMatch()
        {
            if (infoV == null || infoH == null)
                return;
            MatchCreateDTO m = new MatchCreateDTO(infoV.Id, infoH.Id, DateTime.Now, null);
            var match = await JS.InvokeAsync<MatchDTO>("postAPI", "https://localhost:7232/matches/", m);
            await onCreateCustomMatch.InvokeAsync(match.Id);
        }
    }
}
