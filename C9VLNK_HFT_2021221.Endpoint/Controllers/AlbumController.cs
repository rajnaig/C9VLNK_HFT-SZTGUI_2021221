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
    public class AlbumController : ControllerBase
    {
        IAlbumLogic albumLogic;
        IHubContext<SignalRHub> hub;
        public AlbumController(IAlbumLogic albumLogic,IHubContext<SignalRHub> hubContext)
        {
            this.albumLogic = albumLogic;
            this.hub = hubContext;  
        }

        // GET: /album
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return albumLogic.ReadAllAlbums();
        }

        // GET api/album/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return albumLogic.GetAlbum(id);
        }

        // POST /album
        [HttpPost]
        public void Post([FromBody] Album album)
        {
            albumLogic.AddAlbum(album);
            hub.Clients.All.SendAsync("AlbumCreated", album);
        }

        // PUT api/<AlbumController>/5
        [HttpPut]
        public void Put([FromBody] Album album)
        {
            albumLogic.UpdateFullAlbum(album);
            hub.Clients.All.SendAsync("AlbumUpdated", album);
        }

        // DELETE album/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            albumLogic.DeleteAlbum(id);
            hub.Clients.All.SendAsync("AlbumUpdated", null);
        }


        //[Route("updatecountry/{id}/{newCountry}")]
        //[HttpPut("{id} {newCountry}")]

        [Route("updatetitle/{id}/{newTitle}")]
        [HttpPut("{id} {newTitle}")]
        public void UpdateTitle(int id, string newTitle)
        {
            albumLogic.UpdateAlbumTitle(id, newTitle);
        }

        [Route("updatealbumreleasedate/{id}/{newReleaseDate}")]
        [HttpPut("{id} {newReleaseDate}")]
        public void UpdateReleaseDate(int id, DateTime newReleaseDate)
        {
            albumLogic.UpdateAlbumReleaseDate(id, newReleaseDate);
        }
    }
}
