function solve(input) {
    var rotationDegrees = input[0].split(/[^0-9]+/).filter(Boolean)[0];
    var matrix = [];
    var rotatedMatrix = [];

    for (var i = 1; i < input.length; i++) {
        matrix.push(input[i]);
    }

    for (var j = 0; j < matrix.length; j++) {
        if (rotationDegrees == 90) {

            for (var k = 0; k < matrix.length; k++) {
                for (var l = 0; l < 1; l++) {
                    console.log();
                }
            }
        }
    }

    console.log(matrix);
}

solve([ "Rotate(90)", "hello", "softuni", "exam"]);