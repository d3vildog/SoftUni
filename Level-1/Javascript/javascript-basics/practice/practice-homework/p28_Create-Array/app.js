function createArray() {
    var arr = new Array(20);
    var newArray = [];

    for (var i = 0; i < arr.length; i++) {
        newArray[i] = i * 5;
    }

    return newArray;
}

console.log(createArray);