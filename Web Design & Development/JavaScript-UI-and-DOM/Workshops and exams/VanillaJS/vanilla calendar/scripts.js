function createCalendar(selector, events) {

    var MONTH = 6;
    var DAYS = 31;
    var selectedBox = null;

    var body = document.getElementById('calendar-container');
    var container = document.createElement('div');
    var dayBox = document.createElement('div');
    var dayBoxTitle = document.createElement('strong');
    var dayBoxContent = document.createElement('div');
    dayBoxContent.className = 'day-content';

    dayBox.appendChild(dayBoxTitle);
    dayBox.appendChild(dayBoxContent);

    function createMonthBoxes() {
        var dayBoxes = [];
        for (var index = 0; index < DAYS; index++) {
            dayBoxTitle.innerText = 'DAY ' + index;
            dayBox.style.height = '100px';
            dayBox.style.width = '100px';
            dayBox.style.border = '1px solid black';
            dayBox.style.display = 'inline-block';
            dayBox.style.float = 'left';
            dayBox.style.margin = '0.5px';

            dayBox.className = 'daybox' + index;

            dayBoxes.push(dayBox.cloneNode(true));
        }
        return dayBoxes;
    }

    function addCalendarEvents(boxes, events) {
        for (var index = 0; index < events.length; index++) {
            var event = events[index];
            var contentDiv = boxes[event.date - 1].querySelector('.day-content');
            contentDiv.innerText =
                event.title + '\n' +
                event.hour + '\n' +
                event.duration + ' min';
        }
    }

    function onBoxClick(box) {
        if (selectedBox) {
            selectedBox.style.background = '';
        }
        if (selectedBox && selectedBox === this) {
            selectedBox = null;
        } else {
            this.style.background = 'green';
            selectedBox = this;
        }
    }

    function onMouseover(box) {
        if (selectedBox !== this) {
            this.style.background = 'yellowgreen';
        }
    }

    function onMouseleave(box) {
        if (selectedBox !== this) {
            this.style.background = '';
        }
    }

    var boxes = createMonthBoxes();
    addCalendarEvents(boxes, events);

    var dacFragment = document.createDocumentFragment();
    for (var index = 0; index < DAYS; index++) {
        dacFragment.appendChild(boxes[index]);
        boxes[index].addEventListener('click', onBoxClick);
        boxes[index].addEventListener('mouseover', onMouseover);
        boxes[index].addEventListener('mouseleave', onMouseleave);
    }
    container.appendChild(dacFragment);

    body.appendChild(container);

}