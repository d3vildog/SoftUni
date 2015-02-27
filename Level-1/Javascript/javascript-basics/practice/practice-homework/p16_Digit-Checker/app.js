function checkDigit(number) {
    var thirdNum = Math.floor((number % 1000) / 100);

    return thirdNum == 3;
}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));