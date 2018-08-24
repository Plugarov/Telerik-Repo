//https://github.com/t1m0n/air-datepicker/blob/master/dist/js/datepicker.js

(function ($) {
    $.fn.datepicker = function () {

        var DAYS_OF_WEEK = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"];

        var root = $(this);
        var body = createBody();
        appendStyles(body);
        appendEvents(body);

        function createBody() {
            var datepickerRoot = $('<div/>')
                .addClass('datepicker-root')

            var datepickerHeader = createCalendarHeader();
            var datepickerCalendar = createCalendarTable();

            function createCalendarHeader() {
                var header = $('<div/>')
                    .addClass('datepicker-main');
                var buttonPrev = $('<a/>')
                    .addClass('datepicker-prev-btn');
                var buttonNext = $('<a/>')
                    .addClass('datepicker-next-btn');
                var title = $('<div/>')
                    .addClass('datepicker-title');
                var month = $('<span/>')
                    .addClass('datepicker-month');
                var year = $('<span/>')
                    .addClass('datepicker-year');

                var date = new Date();
                var currnetMonth = MONTH_NAMES[date.getMonth()]
                var currentYear = date.getFullYear()

                month.text(currnetMonth);
                year.text(currentYear);
                buttonPrev.text('Prev')
                buttonNext.text('Next')

                title
                    .append(month)
                    .append(year);

                header
                    .append(buttonPrev)
                    .append(buttonNext)
                    .append(title);

                return header;
            }

            function createCalendarTable() {
                var table = $('<table/>')
                    .addClass('datepicker-calendar');
                var thead = createThead();
                var tbody = createTbody();

                appendDaysToCalendar(tbody);

                function createThead() {
                    var thead = $('<thead/>');
                    var rows = $('<tr/>');

                    for (var i = 0; i < 7; i += 1) {
                        var cols = $('<th/>')
                        $('<span/>')
                            .text(DAYS_OF_WEEK[i])
                            .appendTo(cols);
                        rows.append(cols);
                    }
                    thead.append(rows);
                    return thead;
                }

                function createTbody() {
                    var tbody = $('<tbody/>');

                    for (var row = 0; row < 6; row += 1) {
                        var tr = $('<tr/>');
                        for (var col = 0; col < 7; col += 1) {
                            var th = $('<th/>')
                            tr.append(th);
                        }
                        tbody.append(tr);
                    }

                    return tbody;
                }

                function appendDaysToCalendar(tbody) {
                    var currentDate = new Date();
                    var dataBoxes = tbody.find('th');
                    var totalDays = daysInThisMonth(currentDate);
                    var firstDay = new Date(currentDate.getFullYear(), currentDate.getMonth(), 1)
                        .getDay();

                    var day = 0;
                    var linkElement;
                    var currentElement;
                    for (var i = firstDay; i < totalDays + firstDay; i += 1) {
                        linkElement = $('<a/>')
                            .text(day + 1);
                        currentElement = $(dataBoxes[i])
                            .addClass('active')
                            .css({
                                'border': '1px solid #eaeae5',
                                'background': '#f9f9f9',
                            })
                            .append(linkElement);

                        day += 1;
                    }

                    function daysInThisMonth(currentDate) {
                        return new Date(currentDate.getFullYear(), currentDate.getMonth() + 1, 0).getDate();
                    }
                }

                return table
                    .append(thead)
                    .append(tbody);
            }
            return datepickerRoot
                .append(datepickerHeader)
                .append(datepickerCalendar);
        }

        function appendStyles(root) {
            root.css({
                'border': '1px solid #cccccc',
                'border-radius': '3px',
                'width': '280px',
                'position': 'absolute',
                'width': 'auto'
            });

            root.find('.datepicker-header').css({
                'background': 'white',
                'border': '1px solid white',
                'border-radius': '2px',
            });

            root.find('.datepicker-calendar').css({
                'background': '#fcfcfc',
                'border': '1px solid white',
                'border-radius': '2px',
            });

            root.find('th').css({
                'borderRadius': '2px',
                'height': '14px',
                'width': '25px',
                'padding': '5px',
                'margin': '1px'
            });

            root.find('.datepicker-main').css({
                'padding': '10px',
                'position': 'relative',
                'border-radius': '3px',
                'border': '1px solid #cccccc',
                'margin': '3px',
                'background': '#eaeaea',
            });

            root.find('.datepicker-prev-btn').css({
                'position': 'absolute',
                'left': '5px',
            });

            root.find('.datepicker-next-btn').css({
                'position': 'absolute',
                'right': '5px',
            });

            root.find('.datepicker-title').css({
                'text-align': 'center',
            });

            root.find('.datepicker-title span').css({
                'margin': '5px'
            });
        }

        function appendEvents(root) {
            var root = $(root);
            var dateBoxes = root.find('.active');
            var nextBtn = root.find('.datepicker-next-btn');

            nextBtn.on('click', function () {
                console.log(1);
            });

            dateBoxes.on('mouseover', function () {
                $(this).css({ 'background': '#e2e2e2' })
            });

            dateBoxes.on('mouseleave', function () {
                $(this).css({ 'background': '#f9f9f9' })
            });
        }

        root.append(body);
    }
}(jQuery));