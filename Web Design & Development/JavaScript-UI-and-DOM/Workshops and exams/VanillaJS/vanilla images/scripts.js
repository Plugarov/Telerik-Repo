function createImagesPreviewer(selector, items) {
    var root = document.querySelector(selector);

    var df = document.createDocumentFragment();

    var table = document.createElement('table');
    table.style.border = '1px solid black';

    var tableRow = document.createElement('tr');
    table.appendChild(tableRow);
    root.appendChild(table);

    /* Left panel */
    var leftPanel = document.createElement('th');

    var imagePreviewer = document.createElement('div');
    imagePreviewer.className = 'image-preview';

    var imagePreviewerName = document.createElement('span')
    imagePreviewerName.innerHTML = items[0].title;

    var imagePreviewerImage = document.createElement('img');
    imagePreviewerImage.src = items[0].url;

    imagePreviewer.appendChild(imagePreviewerName);
    imagePreviewer.appendChild(imagePreviewerImage);

    leftPanel.appendChild(imagePreviewer);

    /* End of left panel */

    /* Right panel */
    var rightPanel = document.createElement('th');

    var filterBox = document.createElement('input');
    rightPanel.appendChild(filterBox);

    var imageContainer = document.createElement('div');
    imageContainer.className = 'image-container';
    rightPanel.appendChild(imageContainer)

    var imagesList = document.createElement('ul');
    imagesList.style.height = '400px';
    imagesList.style.overflowY = 'scroll'
    imagesList.id = 'catsList';

    for (let i = 0; i < items.length; i += 1) {
        var imgItem = document.createElement('li');

        var imgItemName = document.createElement('span');
        imgItemName.innerHTML = items[i].title;

        var imgItemImg = document.createElement('img');
        imgItemImg.src = items[i].url;

        imgItem.appendChild(imgItemName);
        imgItem.appendChild(imgItemImg);

        imagesList.appendChild(imgItem);
    }

    imageContainer.appendChild(imagesList);

    /* End of right panel */

    /* Events */

    imagesList.addEventListener('click', function (item) {
        var hearer = item.target.previousElementSibling.innerText;

        imagePreviewerName.innerText = hearer;
        imagePreviewerImage.src = item.target.getAttribute("src");
    });

    imagesList.addEventListener('mouseover', function (item) {
        if (item.target.tagName !== 'LI' &&
            item.target.parentNode.parentNode.id == 'catsList') {
            item.target.parentNode.style.backgroundColor = "grey";
        }
    });

    imagesList.addEventListener('mouseout', function (item) {
        if (item.target.tagName !== 'LI' &&
            item.target.parentNode.parentNode.id == 'catsList') {
            item.target.parentNode.style.backgroundColor = "";
        }
    });

    filterBox.addEventListener('keyup', function (input) {
        var text = input.target.value;
        var liChildren = imagesList.getElementsByTagName('li');
        for (let i = 0; i < liChildren.length; i += 1) {
            var currentLi = liChildren[i];
            var header = currentLi.firstElementChild.innerText;
            if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                currentLi.style.display = 'block';
            } else {
                currentLi.style.display = 'none';
            }
        }
    });

    /* End of events */

    tableRow.appendChild(leftPanel);
    tableRow.appendChild(rightPanel);
}
