
function solve(args) {

    let pattern = args[0].split(' ').map(Number),
        valley = args[1].split(' ').map(Number);

    let coins = 0,
        visited = [],
        index = 0,
        patternIndex = 0;

    function isOutside(valley, index) {
        return valley[index] === undefined;
    }

    while (!visited[index] && !isOutside(valley, index)) {

        coins += valley[index];
        visited[index] = true;

        index += pattern[patternIndex];

        patternIndex += 1;
        patternIndex %= pattern.length;
    }

    console.log(coins);

}
solve(['1 3 -2', '1 3 -6 7 4 1 12']);
