const checkPassword = (function () {
    const CORRECT_PASS = 'pesho';

    return function () {
        const enteredPassowrd = passField.value;
        passField.value = '';

        if (enteredPassowrd === CORRECT_PASS) {
            messageField.innerHTML = 'Correct pass.'
        } else {
            messageField.innerHTML = 'Incorect pass.'
        }
    }
})();

button.addEventListener('click', checkPassword);