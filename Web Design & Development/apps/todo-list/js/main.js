
$.fn.taskManager = function (tasks) {

    var row = $(this).find('.row');

    var body = createBody();
    var selectedBox = null;

    addEvents(body);
    addStyles(body);

    row.append(body);

    function createBody() {
        var taskManager = $('<div/>')
            .addClass('task-manager');

        var inputContainer = $('<div/>')
            .addClass('input-container')
            .appendTo(taskManager);

        var input = $('<textarea/>')
            .addClass('input-field')
            .appendTo(inputContainer);

        var inputBtn = $('<button/>')
            .addClass('input-add-btn')
            .attr({ type: 'button', value: 'add-btn' })
            .html('Add')
            .appendTo(inputContainer);

        var listContainer = $('<div/>')
            .addClass('list-container')
            .appendTo(taskManager);

        var list = $('<ul>')
            .addClass('list list-group mt-3 mb-3')
            .appendTo(listContainer);

        return taskManager;
    }

    function addStyles(body) {
        var taskManager = body;
        var inputContainer = body.find('.input-container');
        var listContainer = body.find('.list-container');

        taskManager
            .addClass('col-6')
            .css({
                'background': '#99FF99',
                'border': '2px solid #33ff33',
                'border-radius': '3px'
            });

        inputContainer.find('.input-add-btn')
            .addClass('btn btn-primary mt-2')

        inputContainer.find('textarea')
            .addClass('form-control mt-2')
            .attr({
                id: 'exampleTextarea',
                rows: '3'
            });
    }

    function addEvents(body) {
        var root = body;

        var addButton = root.find('.input-add-btn');
        var inputField = root.find('.input-field');
        var listItems = root.find('.list');

        addButton.on('click', addListItem);
        // listItems.on('mouseenter', '.list-item', hoverOnMouseover);
        // listItems.on('mouseleave', '.list-item', hoverOutOnMouseout);
        listItems.on('click', '.list-item', removeListItem);

        function addListItem() {
            var value = inputField.val();

            if (value.length < 3) {
                alert('Input should be at least 10 characters long.');
                return;
            }

            var item = $('<li/>')
                .addClass('list-item list-group-item')
                .css({
                    'list-style-type': 'none',
                })
                .appendTo(listItems);

            var paragraphDiv = $('<div/>')
                .addClass('paragraph-container col-10')
                .appendTo(item);

            $('<p/>')
                .text(value)
                .appendTo(paragraphDiv);

            $('<button/>')
                .addClass('del-btn btn btn-outline-primary')
                .attr({
                    href: '#'
                })
                .text('Delete')
                .appendTo(item);
        }

        function removeListItem(ev) {
            var $target = $(ev.target);
            var $hover = $(ev.currentTarget);

            if ($target.hasClass('del-btn')) {
                $target.parents('li').remove();
            };
        }

        function hoverOnMouseover(ev) {
            var $target = $(ev.currentTarget);
            if (selectedBox != $target) {
                $target.css('background', '#CEE6E9');
            }
        }

        function hoverOutOnMouseout(ev) {
            var $target = $(ev.currentTarget);
            if (selectedBox !== $target) {
                $target.css('background', '');
            }
        }
    }
}