let artists = [];
let albums = [];
let songs = [];

getdata();

async function getdata() {

    await fetch('http://localhost:48039/artist')
        .then(x => x.json())
        .then(y => {
            artists = y;
            console.log(artists);
            displayArtists();
        });


    await fetch('http://localhost:48039/album')
        .then(x => x.json())
        .then(y => {
            albums = y;
            console.log(albums);
            displayAlbums();
        });


    await fetch('http://localhost:48039/song')
        .then(x => x.json())
        .then(y => {
            songs = y;
            console.log(songs);
            displaySongs();
        });
}


function displayArtists() {
    document.getElementById('artistResultArea').innerHTML = "";
    artists.forEach(t => {
        document.getElementById('artistResultArea').innerHTML +=
            "<tr><td>" + t.artistId + "</td><td>" +
            t.name + "</td><td>" +
            t.artistGenre + "</td><td>" +
             t.country + "</td><td>" +
             t.profilPicture + "</td><td>" +
        `<button type="button" onclick="removeArtist(${t.artistId})">Remove Artist</button>`
            "</td><tr>";
        console.log(t.name);
    })
}

function displayAlbums() {
    document.getElementById('albumResultArea').innerHTML = "";
    albums.forEach(t => {
        document.getElementById('albumResultArea').innerHTML +=
            "<tr><td>" + t.albumId + '.' + "</td><td>" +
            t.albumTitle + "</td><td>" +
            t.releaseDate + "</td><td>" +
            t.artistId + '.' + "</td><td>" +
            t.albumCover + "</td><td>" +
            `<button type="button" onclick="removeAlbum(${t.albumId})">Remove Album</button>`
        "</td><tr>";

        console.log();
    })
}

function displaySongs() {
    document.getElementById('songResultArea').innerHTML = "";
    songs.forEach(t => {
        document.getElementById('songResultArea').innerHTML +=
            "<tr><td>" + t.songId + '.' + "</td><td>" +
            t.albumId + '.' + "</td><td>" +
            t.title + "</td><td>" +
            t.plays + "</td><td>" +
            t.songGenre + "</td><td>" +
            t.producer + "</td><td>" +
            t.songCover + "</td><td>" +
            `<button type="button" onclick="removeSong(${t.songId})">Remove Song</button>`
            "</td><tr>";
        console.log();
    })
}



function createArtist() {
    let artistName = document.getElementById('artistname').value;
    let genre = document.getElementById('artistgenre').value;
    let artistCountry = document.getElementById('artistcountry').value;
    let artistPic = document.getElementById('artistPic').value;

    fetch('http://localhost:48039/artist', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json', },
        body: JSON.stringify(
            {
                name: artistName,
                artistGenre: Number(genre),
                country: Number(artistCountry),
                profilPicture: artistPic
            })
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getdata();
        })
        .catch((error) => { console.error('Error:', error); });

    document.getElementById('artistname').value = "";
    document.getElementById('artistgenre').value = "";
    document.getElementById('artistcountry').value = "";
    document.getElementById('artistPic').value = "";

}

function createAlbum() {
    let title = document.getElementById('albumTitle').value;
    let date = document.getElementById('albumDate').value;
    let artId = document.getElementById('aldumArtistId').value;
    let albCov = document.getElementById('albumCover').value;

    fetch('http://localhost:48039/album', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json', },
        body: JSON.stringify(
            {
                albumTitle: title,
                releaseDate: date,
                artistId: Number(artId),
                albumCover: albCov
            })
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getdata();
        })
        .catch((error) => { console.error('Error:', error); });

    document.getElementById('albumTitle').value = "";
    document.getElementById('albumDate').value = "";
    document.getElementById('aldumArtistId').value = "";
    document.getElementById('albumCover').value = "";
}

function createSong() {
    let album = document.getElementById('songAlbumId').value;
    let songTitle = document.getElementById('songTitle').value;
    let songProducer = document.getElementById('songProducer').value;
    let songCov = document.getElementById('songCover').value;
    let songPly = document.getElementById('songPlays').value;
    let songGen = document.getElementById('songGenre').value;


    fetch('http://localhost:48039/song', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json', },
        body: JSON.stringify(
            {
                albumId: Number(album),
                title: songTitle,
                producer: songProducer,
                songCover: songCov,
                plays: Number(songPly),
                songGenre: Number(songGen)
            })
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getdata();
        })
        .catch((error) => { console.error('Error:', error); });

    document.getElementById('songAlbumId').value = "";
    document.getElementById('songTitle').value = "";
    document.getElementById('songProducer').value = "";
    document.getElementById('songCover').value = "";
    document.getElementById('songPlays').value = "";
    document.getElementById('songGenre').value = "";
}


function removeAlbum(id) {
    fetch('http://localhost:48039/album/' + id, {
        method: 'DELETE',
        headers: { 'Content-Type': 'application/json', },
        body: null
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getdata();
        })
        .catch((error) => { console.error('Error:', error); });
}

function removeArtist(id) {
    fetch('http://localhost:48039/artist/' + id, {
        method: 'DELETE',
        headers: { 'Content-Type': 'application/json', },
        body: null
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getdata();
        })
        .catch((error) => { console.error('Error:', error); });
}

function removeSong(id) {
    fetch('http://localhost:48039/song/' + id, {
        method: 'DELETE',
        headers: { 'Content-Type': 'application/json', },
        body: null
    })
        .then(response => response)
        .then(data => {
            console.log('Success:', data);
            getdata();
        })
        .catch((error) => { console.error('Error:', error); });
}





