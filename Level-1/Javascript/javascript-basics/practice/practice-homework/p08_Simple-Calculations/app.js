function roundNumber(number) {
    var floored = Math.floor(number);
    var rounded = Math.round(number);

    return [floored, rounded];
}

console.log(roundNumber(22.7));
console.log(roundNumber(12.3));
console.log(roundNumber(58.7));