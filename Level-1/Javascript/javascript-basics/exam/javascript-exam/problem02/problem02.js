function solve(input) {
    var output = [];

    for (var row = 0; row < input.length; row++) {
        output[row] = input[row].split('');
        input[row] = input[row].toLowerCase();
    }

    for (var row = 0; row < input.length; row++) {
        for (var col = 0; col < input[row].length; col++) {
            if (input[row + 2] != undefined) {
                checkForPlus(row, col);   
            }
        }
    }

    function checkForPlus(row, col) {
        if (input[row + 1][col - 1] == undefined ||
            input[row + 1][col] == undefined ||
            input[row + 1][col + 1] == undefined ||
            input[row + 2][col] == undefined) {
            return false;
        }

        var a = input[row][col];
        var b = input[row + 1][col - 1];
        var c = input[row + 1][col];
        var d = input[row + 1][col +1];
        var e = input[row + 2][col];

        if (a == b && a == c && a == d && a == e) {
            output[row][col] = '';
            output[row + 1][col - 1] = '';
            output[row + 1][col] = '';
            output[row + 1][col + 1] = '';
            output[row + 2][col] = '';
        }
    }

    for (var row = 0; row < input.length; row++) {
        console.log(output[row].join(''));
    }
}

solve([
    'ab**l5',
    'bBb*555',
    'absh*5',
    'ttHHH',
    'ttth'
]);
