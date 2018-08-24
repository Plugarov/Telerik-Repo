/* globals document, window, console */

function solve() {
    return function (selector, initialSuggestions) {
        "use strict";

        var element = document.querySelector(selector);
        var addingButton = element.querySelector('.btn-add');
        var list = element.querySelector('.suggestions-list');
        var input = element.querySelector('.tb-pattern');
        input.value = '';

        var item = document.createElement('li');
        item.className = 'suggestion';
        item.style.display = "none"

        var attribute = document.createElement('a');
        attribute.href = '#';
        attribute.className = 'suggestion-link';
        item.appendChild(attribute);

        function createListElement() {
            var node = item.cloneNode(true);
            node.innerHTML = input.value;
            list.appendChild(node);

            input.value = ''
            list.style.display = 'none';
        }

        function searchElement() {
            var items = list.children;
            var pattern = this.value.toLowerCase();

            if (pattern === '') {
                list.style.display = 'none';
                return;
            }

            list.style.display = '';

            for (var i = 0; i < items.length; i++) {
                if (items[i].textContent.toLowerCase().indexOf(pattern) >= 0) {
                    items[i].style.display = '';
                } else {
                    items[i].style.display = 'none';
                }
            }
        }

        function selectElement(element) {
            var selectedText = element.target.textContent;
            input.value = selectedText;
        }

        addingButton.addEventListener('click', createListElement, false);
        input.addEventListener('input', searchElement);
        list.addEventListener('click', selectElement);


    };
}

