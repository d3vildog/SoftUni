function checkDigit(number) {
    if (number < 1000) {
        return "Invalid input";
    }
    return parseInt((number / 100) % 10) == 3;
}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));