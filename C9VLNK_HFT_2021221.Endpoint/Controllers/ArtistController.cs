using C9VLNK_HFT_2021221.Endpoint.Services;
using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C9VLNK_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        IArtistLogic artistLogic;
        IHubContext<SignalRHub> hub;
        public ArtistController(IArtistLogic asrtisLogic,IHubContext<SignalRHub> hubContext)
        {
            this.artistLogic = asrtisLogic;
            this.hub = hubContext;
        }

        // GET: /artist
        [HttpGet]
        public IQueryable<Artist> ReadAll()
        {
            return artistLogic.ReadAllArtis();
        }

        // GET artist/1
        //[Route("/{id}")]
        [HttpGet("{id}")]
        public Artist Get(int id)
        {
            return artistLogic.GetArtist(id);
        }

        // POST /artist
        [HttpPost]
        public void Post([FromBody] Artist value)
        {
            artistLogic.AddArtist(value);
            hub.Clients.All.SendAsync("ArtistCreated", value);
        }

        // PUT /artist
        [HttpPut]
        public void Put([FromBody] Artist value)
        {
            artistLogic.UpdateFullArtist(value);
            hub.Clients.All.SendAsync("ArtistUpdated", value);

        }

        // PUT /artist
        [Route("updatename/{id}/{newName}")]
        [HttpPut("{id} {newName}")]
        public void UpdateName(int id, string newName)
        {
            artistLogic.UpdateArtistName(id, newName);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            artistLogic.DeleteArtist(id);
            hub.Clients.All.SendAsync("ArtistDeleted", null);
        }


        // PUT /artist /newNationality
        [Route("updatecountry/{id}/{newCountry}")]
        [HttpPut("{id} {newCountry}")]
        public void UpdateCountry(int id, Countries newCountry)
        {
            artistLogic.UpdateArtistCountry(id, newCountry);
        }

        // DELETE artist/1
        

        [Route("mostfamouscountrybyartistscount")]
        [HttpGet]
        public string MostFamousCountryByArtistsCount()
        {
            return artistLogic.MostFamousCountryByArtistsCount();
        }
    }
}
