using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C9VLNK_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {

        ISongLogic songLogic;
        public SongController(ISongLogic songLogic)
        {
            this.songLogic = songLogic;
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
        }





        // PUT /song
        [HttpPut("{id}")]
        public void Put(Song value)
        {
            songLogic.UpdateFullSong(value);
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




        // DELETE api/<SongController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            songLogic.DeleteSong(id);
        }
    }
}
