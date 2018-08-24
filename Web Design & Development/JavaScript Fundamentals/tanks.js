function solve(args) {

    let arr = args[0].split(' ').map(Number),
        rows = arr[0],
        cols = arr[1];

    let field = new Array(rows);
    field.fill(0);

    for (let i in field) {
        field[i] = new Array(cols);
        field[i].fill(-1);
    }

    let tankPosition = [
        { row: 0, col: 0 },
        { row: 0, col: 1 },
        { row: 0, col: 2 },
        { row: 0, col: 3 },
        { row: rows - 1, col: cols - 1 },
        { row: rows - 1, col: cols - 2 },
        { row: rows - 1, col: cols - 3 },
        { row: rows - 1, col: cols - 4 },
    ];

    for (let id in tankPosition) {
        field[tankPosition[id].row][tankPosition[id].col] = +id
    }

    // - - - - - - - - - - - - 

    let debri = args[1].split(';');

    debri.forEach(function (r) {
        let arr = r.split(' '),
            x = arr[0],
            y = arr[1];

        field[x][y] = 9;
    })

    // - - - - - - - - - - - - 

    function tankMove(id, n, dir) {

        let tankRow = tankPosition[id].row,
            tankCol = tankPosition[id].col;

        let deltaRow = 0,
            deltaCol = 0;

        if (dir === 'u') {
            deltaRow = - 1;
        } else if (dir === 'd') {
            deltaRow = +1;
        } else if (dir === 'l') {
            deltaCol = -1;
        } else if (dir === 'r') {
            deltaCol = +1;
        } else {

        }

        field[tankPosition[id].row][tankPosition[id].col] = -1;

        while (n > 0) {

            newPosRow = tankRow + deltaRow;
            newPosCol = tankCol + deltaCol;

            if (newPosCol < 0 || newPosRow < 0) {
                break;
            } else if (newPosRow >= rows || newPosCol >= cols) {
                break;
            } else if (field[newPosRow][newPosCol] !== -1) {
                break;
            } else {

            }

            tankRow = newPosRow;
            tankCol = newPosCol;

            n -= 1;
        }

        tankPosition[id].row = tankRow;
        tankPosition[id].col = tankCol;

        field[tankPosition[id].row][tankPosition[id].col] = id;

    }

    // - - - - - - - - - - - - 
    let playerTanks = [4, 4];

    function tankShoot(id, dir) {


        let deltaRow = 0,
            deltaCol = 0;

        if (dir === 'u') {
            deltaRow = - 1;
        } else if (dir === 'd') {
            deltaRow = +1;
        } else if (dir === 'l') {
            deltaCol = -1;
        } else if (dir === 'r') {
            deltaCol = +1;
        } else {

        }

        let tankShootRow = tankPosition[id].row + deltaRow,
            tankShootCol = tankPosition[id].col + deltaCol;

        while (tankShootCol >= 0 && tankShootRow >= 0 && tankShootRow <= rows && tankShootCol <= cols) {

            if (field[tankShootRow][tankShootCol] === -1) {
                tankShootRow += deltaRow;
                tankShootCol += deltaCol;
            } else if (field[tankShootRow][tankShootCol] === 9) {
                field[tankShootRow][tankShootCol] = -1;
                break;
            } else {
                const deadTankId = field[tankShootRow][tankShootCol];
                console.log(`Tank ${deadTankId} is gg`);
                field[tankShootRow][tankShootCol] = -1;

                const playerId = deadTankId < 4 ? 0 : 1;
                playerTanks[playerId] -= 1;
                if (playerTanks[playerId] === 0) {
                    const loserName = ['Koceto', 'Cuki'][playerId];
                    console.log(`${loserName} is gg`);
                }
                break;
            }
        }
    }
    const n = +args[2];

    for (let i = 3; i < n + 3; i += 1) {
        let command = args[i].split(' ');
        if (command[0] === 'mv') {
            tankMove(+command[1], +command[2], command[3]);
        } else if (command[0] === 'x') {
            tankShoot(+command[1], command[2]);
        } else {

        }
    }
    console.log(field);
}


solve([
    '5 5',
    '2 0;2 1;2 2;2 3;2 4',
    '13',
    'mv 7 2 l',
    'x 7 u',
    'x 0 d',
    'x 6 u',
    'x 5 u',
    'x 2 d',
    'x 3 d',
    'mv 4 1 u',
    'mv 4 4 l',
    'mv 1 1 l',
    'x 4 u',
    'mv 4 2 r',
    'x 2 d'
])

