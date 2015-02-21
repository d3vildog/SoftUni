function printNumers(number) {
    var newArray = [];

    for (var i = 1; i <= number; i++) {
        if (!(i % 4 == 0 || i % 5 == 0)) {
            newArray.push(i);
        }
    }

    return newArray == 0 ? "no" : newArray;
}

console.log(printNumers(20));
console.log(printNumers(-5));
console.log(printNumers(13));