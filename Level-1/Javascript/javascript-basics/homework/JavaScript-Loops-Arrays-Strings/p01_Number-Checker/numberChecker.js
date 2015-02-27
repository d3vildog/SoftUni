function printNumbers(number) {
    var notDivisible = [];

    for (var i = 1; i <= number; i++) {
        if (i % 4 !== 0 && i % 5 !== 0) {
            notDivisible.push(i);
        }
    }

    if (notDivisible.length < 1) {
        return console.log("no");
    }

    console.log(notDivisible.join(", "));
}

printNumbers(20);
printNumbers(-5);
printNumbers(13);