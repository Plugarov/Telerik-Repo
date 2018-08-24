function solve() {

    var player,
        playlist,
        playable,
        audio,
        video;

    var validator = {

    }

    player = function () {
        var player = {
            init: function (name) {
                this._name = name;
                this._playlists = [];
                return this;
            },

            addPlaylist: function (playlistToAdd) {
                this._playlists.push(playlistToAdd);
            },

            getPlaylistById: function (id) {
                return this._playlists.filter(x => x._id === id);
            },

            removePlaylist: function (value) {
                var id = value;

                if (typeof (value) === 'undefined') {
                    throw {
                        name: IvalidIdProvided,
                        message: IvalidIdProvided
                    }
                }

                if (typeof (id) !== 'number') {
                    id = value.id;
                }

                return this._playlists.filter(x => x._id === id);
            },

            listPlaylists: function (page, size) {
                if (
                    page * size > this._playlists.length ||
                    page < 0 ||
                    size <= 0) {
                    throw {
                        name: 'listPlaylistsError'
                    }
                }

                return this._playlists.slice(page * size - size, page * size);
            },

            search: function (pattern) {
                return this._playlists.filter(function (playlist) {
                    return playlist.getPlayables()
                        .some(function (playable) {
                            return playable._title
                                .toLowerCase()
                                .indexOf(pattern) >= 0;
                        });
                });

            }
        }


        return player;
    }();

    playlist = function () {
        var nextId = 0;
        var playlist = {
            init: function (name) {
                this._id = nextId += 1;
                this._name = name;
                this._playables = [];
                return this;
            },

            addPlayable: function (playableToAdd) {
                this._playables.push(playableToAdd);
                return this;
            },

            getPlayables: function () {
                return this._playables;
            }

        }

        return playlist;
    }();

    playable = function () {
        var nextId = 0;
        var playable = {
            init: function (title, author) {
                this._id = nextId += 1;
                this._title = title;
                this._author = author;
            }
        }

        return playable;
    }();

    audio = function (parent) {
        var audio = Object.create(parent);

        audio = {
            init: function (title, author, length) {
                parent.init.call(this, title, author);
                this._length = length;
                return this;
            }
        }

        return audio;
    }(playable);

    video = function (parent) {
        var video = Object.create(parent);
        video = {
            init: function (title, author, imdbRating) {
                parent.init.call(this, title, author);
                this._imdbRating = imdbRating;
                return this;
            }
        }

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
player.addPlaylist(module.getPlaylist('RAP')
    .addPlayable(module.getAudio('Welcome', 'bob', 3))
    .addPlayable(module.getAudio('Welcome', 'john', 3)));

player.addPlaylist(module.getPlaylist('Chalga')
    .addPlayable(module.getAudio('Welcome', 'bob', 3))
    .addPlayable(module.getAudio('neee ', 'john', 3)));

    player.addPlaylist(module.getPlaylist('ddz')
    .addPlayable(module.getAudio('Welcome', 'bob', 3))
    .addPlayable(module.getAudio('neee ', 'john', 3)));


console.log(player.search('neee'));