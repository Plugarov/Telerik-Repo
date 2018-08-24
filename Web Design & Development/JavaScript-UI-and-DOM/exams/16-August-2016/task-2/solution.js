function solve() {
    return function (filesMap) {
        'use strict';

        var root = $('#file-explorer');
        var fileExplorer = root.children('.file-explorer');
        var filePreview = root.children('.file-preview');

        var items = fileExplorer.children('.items');

        var addButton = root.find('.add-btn');
        var deleteButton = items.find('.del-btn');

        addButton.on('click', function () {
            var element = $(this);
            var parentElement = element.parent();

            $('<input/>')
                .addClass('input visible')
                .appendTo(parentElement);

            $('<a/>', {
                class: "input-add-button",
                href: "#",
                text: "Add"
            })
                .appendTo(parentElement);

            element.removeClass('visible');
        });



        deleteButton.on('click', function () {
            var element = $(this);
            element.parent().remove();
        });

        items.on('click', '.item', function () {
            var item = $(this);
            var itemName = item.children('.item-name').text();

            if (item.hasClass('file-item')) {
                $.each(filesMap, function (key, value) {
                    if (key === itemName) {
                        filePreview.children('.file-content').text(value);
                        return;
                    };
                });
            }

            if (item.hasClass('dir-item')) {
                
                item.toggleClass('collapsed');
                
                $.each(filesMap, function (key, value) {
                    if (key === itemName) {
                        filePreview.children('.file-content').text(value);
                        return;
                    };
                });
            }

        });
    }
}

if (typeof module !== 'undefined') {
    module.exports = solve;
}