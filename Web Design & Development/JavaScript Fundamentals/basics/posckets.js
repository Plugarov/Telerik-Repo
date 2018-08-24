function solve(args) {

    let numbers = args[0].split(' ').map(Number);

    function isPeak(index) {
        if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1]) {
            return true;
        }
        return false;
    }

    let peaks = [];

    numbers.forEach(function (x, y) {
        if (isPeak(y)) {
            peaks.push(y);
        }
    });

    // FIRST

    // let lowestPocketSum = 0;

    // for (let i = 1; i < peaks.length; i += 1) {
    //     if (peaks[i] - peaks[i - 1] === 2) {
    //         lowestPocketSum += numbers[peaks[i] - 1];
    //     }
    // }

    // SECOND // mn puti proverqva dali sa poketi

    // let lowestPocketSum = 0;

    // for (let i = 2; i < numbers.length; i += 1) {
    //     if (numbers[i - 2] < numbers[i - 1] &&
    //         numbers[i + 2] < numbers[i + 1] &&
    //         numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1]) {
    //         sumPocketVal += numbers[i];
    //     }
    // }

    // THIRD 

    // 25 min

    // console.log(lowestPocketSum);


    
}

solve([
    "53 20 1 30 2 40 3 10 1"
]);
solve([
    "53 20 1 30 30 2 40 3 10 1"
]);
solve([
    "53 20 1 30 2 40 3 3 10 1"
]);