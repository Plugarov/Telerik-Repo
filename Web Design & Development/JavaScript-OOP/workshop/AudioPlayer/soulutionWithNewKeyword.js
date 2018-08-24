function solve() {

    Item = (function (Parent) {
        var idGenerator;
        idGenerator = idGeneratorFactory.get();

        function Item(name, description) {
            this.id = idGenerator.getNext();
            this.name = name;
            this.description = description;
        }
        return Item;
    }(function () { }));

    return {
        getBook: function (name, isbn, genre, description) {
            return new Book(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return new Media(name, rating, duration, description);
        },
        getBookCatalog: function (name) {
            return new BookCatalog(name);
        },
        getMediaCatalog: function (name) {
            return new MediaCatalog(name);
        }
    };
}

module.exports = solve;