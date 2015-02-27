function solve(arr) {
    var maxLenght = 0;
    var filledString = [];
    var rotation = arr[0] % 360;
    
    // getting the max length of words
    for (var i = 1; i < arr.length; i++) {
        var currLenght = arr[i].length;
        if (currLenght > maxLenght) {
            maxLenght = currLenght;
        }
    }
    
    for (var j = 1; j < arr.length; j++) {
        filledString[j] = fill(arr[j]);
    }
    
    // making new string for rotated words
    if (rotation == 90) {
        var count = 0;
        for (var k = 0; k < maxLenght; k++) {
            for (var r = arr.length - 1; r >= 0; r++) {

            }
        }
    }

    // Filling the word with empty spaces
    function fill(word) {
        var filledWord = word;

        while (filledWord.length < maxLenght) {
            filledWord = filledWord + " ";
        }

        return filledWord;
    }

    return maxLenght;
}

solve(["Rotate(90)", "hello", "softuni", "exam", "madafucker"]);