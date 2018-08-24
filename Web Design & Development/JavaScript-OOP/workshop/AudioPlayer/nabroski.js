
function solve() {
    var player,
        playlist,
        playable,
        audio,
        video;

    player = function () {
        var player = {
            init: function (name) {
                this.name = name;
                this.playlists = [];
                return this;
            },

            addPlaylist: function (playlist) {
                this.playlists.push(playlist);
                return this;
            },

            getPlaylistById: function (id) {
                for (i = 0, len = this.playlists.length; i < len; i += 1) {
                    if (this.playlists[i].id === id) {
                        return this.playlists[i];
                    }
                }
                return null;
            },

            removePlaylist: function (value) {
                var id = value;

                if (typeof (value) === 'undefined') {
                    throw {
                        name: 'InvalidIdError',
                        message: 'No parameters passed.',
                    }
                }

                if (typeof (id) !== 'number') {
                    id = value.id;
                }

                var index = this.playlists.findIndex(x => x.id === id);
                if (index < 0) {
                    throw {
                        name: 'InvalidId',
                        message: 'Invalid ID provided.'
                    }
                }
                this.playlists.splice(index, 1);

                return this;
            },

            listPlaylists: function (page, size) {

                if (page < 0 || size <= 0) {
                    throw {
                        name: 'listPlaylists',
                        message: 'Invalid parameter passed.'
                    }
                }
                var start = (page * size) - size;

                this.playlists.sort(function (pl1, pl2) {
                    if (pl1.title === pl2.title) {
                        return pl1.id - pl2.id;
                    }
                    return pl1.title.localeCompare(pl2.title);
                });

                return this.playlists.splice(start, size);
            }
        };
        return player;
    }();

    playlist = function playlist() {
        var lastId = 0;
        var playlist = {
            init: function (name) {
                this.id = lastId += 1;
                this.name = name;
                this.playables = [];
                return this;
            },

            addPlayable: function (playable) {
                this.playables.push(playable);
            },

            listPlayables: function (page, size) {

                if (page < 0 || size <= 0) {
                    throw {
                        name: 'listPlayables',
                        message: 'Invalid parameter passed.'
                    }
                }
                var start = (page * size) - size;

                this.playables.sort(function (pl1, pl2) {
                    if (pl1.title === pl2.title) {
                        return pl1.id - pl2.id;
                    }
                    return pl1.title.localeCompare(pl2.title);
                });

                return this.playables.splice(start, size);
            }
        };
        return playlist;
    }();

    playable = function playable() {
        var lastId = 0;
        var playable = {
            init: function (title, author) {
                this.id = lastId += 1;
                this.title = title;
                this.author = author;
            },

            play: function () {
                return this.id + ' ' + this.title + ' ' + this.author;
            }
        }

        return playable;
    }();

    audio = (function (parent) {
        var audio = Object.create(parent);

        audio.init = function (title, author, length) {
            parent.init.call(this, title, author);
            this.length = length;
            return this;
        };

        return audio;
    }(playable));

    video = function (parent) {
        var video = Object.create(parent);

        video.init = function (title, author, imdbRating) {
            parent.init.call(this, title, author);
            this.imdbRating = imdbRating;
            return this;
        };

        return video;
    }(playable);

    var module = {
        getPlayer: function (name) {
            return Object.create(player)
                .init(name);
        },
        getPlaylist: function (name) {
            return Object.create(playlist)
                .init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio)
                .init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video)
                .init(title, author, imdbRating);
        }
    };

    return module;
}

var module = solve();

var player = module.getPlayer('WinAM');
var playlist = module.getPlaylist('Rap');
player.addPlaylist(playlist);
// console.log(player.getPlaylistById(1));
// console.log(module.getVideo('Scarface', 'Bill', 93));
console.log(player.listPlaylists(3, 3));
playlist.addPlayable(module.getAudio('Song 1', 'Autor', 3));
playlist.addPlayable(module.getAudio('Song 2', 'Autor', 3));
playlist.addPlayable(module.getAudio('Song 3', 'Autor', 3));
playlist.addPlayable(module.getAudio('Song 5', 'Autor', 3));
playlist.addPlayable(module.getAudio('Song 6', 'Autor', 3));
playlist.addPlayable(module.getAudio('Song 4', 'Autor', 3));
console.log(playlist.listPlayables(2, 3));

//2 07