using C9VLNK_HFT_2021221.Endpoint.Services;
using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C9VLNK_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        IHubContext<SignalRHub> hub;
        ISongLogic songLogic;
        public SongController(ISongLogic songLogic, IHubContext<SignalRHub> hubContext)
        {
            this.songLogic = songLogic;
            this.hub = hubContext;
        }
        // GET: api/<SongController>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songLogic.ReadAllSongs();
        }

        // GET song/1
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return songLogic.GetSong(id);
        }

        // POST /song
        [HttpPost]
        public void Post([FromBody] Song value)
        {
            songLogic.AddSong(value);
            hub.Clients.All.SendAsync("SongCreated", value);
        }

        // DELETE api/<SongController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            songLogic.DeleteSong(id);
            hub.Clients.All.SendAsync("SongDeleted",null);
        }

        // PUT /song
        [HttpPut]
        public void Put([FromBody] Song value)
        {
            songLogic.UpdateFullSong(value);
            hub.Clients.All.SendAsync("SongUpdated", value);
        }

        [Route("updateStitle/{id}/{newTitle}")]
        [HttpPut("{id} {newTitle}")]
        public void UpdateTitle(int id, string newTitle)
        {
            songLogic.UpdateSongTitle(id, newTitle);
        }

        [Route("updatesonglength/{id}/{newLength}")]
        [HttpPut("{id} {newLength}")]
        public void UpdateLength(int id, TimeSpan newLength)
        {
            songLogic.UpdateSongLength(id, newLength);
        }

        [Route("updatesongplays/{id}/{newPlays}")]
        [HttpPut("{id} {newPlays}")]
        public void UpdatePlays(int id, int newPlays)
        {
            songLogic.UpdateSongPlays(id, newPlays);
        }


        [Route("updatesongreleasedate/{id}/{newReleaseDate}")]
        [HttpPut("{id} {newReleaseDate}")]
        public void UpdateReleaseDate(int id, DateTime newReleaseDate)
        {
            songLogic.UpdateSongReleaseDate(id, newReleaseDate);
        }


        [Route("updatesongproducer/{id}/{newProducer}")]
        [HttpPut("{id} {newProducer}")]
        public void UpdateProducer(int id, string newProducer)
        {
            songLogic.UpdateSongProducer(id, newProducer);
        }
    }
}
