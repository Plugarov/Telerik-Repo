
function solve(args) {

    let arr = args[0].split(' ').map(Number),
        rows = arr[0],
        cols = arr[1];

    let field = Array(rows);
    field.fill(0)

    for (let i in field) {
        field[i] = Array(cols);
        field[i].fill(-1)
    }

    let playerCoords = args[1].split(/;|\s/g).map(Number);
    let trollW = {
        row: playerCoords[0],
        col: playerCoords[1],
        trapped: false
    }

    let trollN = {
        row: playerCoords[2],
        col: playerCoords[3],
        trapped: false
    }

    let trollP = {
        row: playerCoords[4],
        col: playerCoords[5]
    }

    let traps = [];
    for (let i = 0; i < rows; i += 1) {
        let row = new Array(rows);
        row.fill(false);
        traps.push(row);
    }


    let len = args.length;
    for (let i = 2; i < len; i += 1) {

        let command = args[i].split(' ');
        if (command[0] === 'mv') {
            let unitToMove;

            if (command[1][0] === 'W') {
                unitToMove = trollW;
            } else if (command[1][0] === 'N') {
                unitToMove = trollN;
            } else if (command[1][0] === 'L') {
                unitToMove = trollP;
            } else {
                // nothing to happen
            }

            if (trollW.row === trollN.row && trollN.col === trollW.col) {
                trollN.trapped = false;
                trollW.trapped = false
            }

            if (unitToMove.trapped === false || command[1][0] === 'L') {

                if (command[2] === 'd' && unitToMove.row < rows - 1) {
                    unitToMove.row += 1;
                } else if (command[2] === 'u' && unitToMove.row > 0) {
                    unitToMove.row -= 1;
                } else if (command[2] === 'l' && unitToMove.col > 0) {
                    unitToMove.col -= 1;
                } else if (command[2] === 'r' && unitToMove.col < cols - 1) {
                    unitToMove.col += 1;
                } else {

                }

                if (traps[unitToMove.row][unitToMove.col] && command[1][0] !== 'L') {
                    unitToMove.trapped = true;
                }

                if (trollP.row - trollN.row < 2 && trollP.col - trollN.col < 2) {
                    console.log(`The trolls caught Lsjtujzbo at ${trollP.row} ${trollP.col}`);
                    break;
                } else if (trollP.row - trollW.row < 2 && trollP.col - trollW.col < 2) {
                    console.log(`The trolls caught Lsjtujzbo at ${trollP.row} ${trollP.col}`);
                    break;
                }

                if (trollP.row === rows - 1 && trollP.col === cols - 1) {
                    console.log(`Lsjtujzbo is saved! ${trollW.row} ${trollW.col} ${trollN.row} ${trollN.col}`);
                }
            }

        } else if (command[0] === 'lay') {
            traps[trollP.row][trollP.col] = true;
        } else {

        }

    }

    field[trollW.row][trollW.col] = 'W';
    field[trollN.row][trollN.col] = 'N';
    field[trollP.row][trollP.col] = 'P';

    console.log(field);
    console.log(traps);
}



solve([
    '5 5',
    '1 1;0 1;2 3',
    'mv Lsjtujzbo d',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Wboup r',
    'mv Wboup r',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d'
]);