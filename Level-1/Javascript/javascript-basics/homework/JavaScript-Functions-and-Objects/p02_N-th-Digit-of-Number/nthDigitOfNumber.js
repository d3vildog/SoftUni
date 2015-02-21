function findNthDigit(arr) {
    var position = arr[0];
    var number = "" + arr[1];
    var numbers = number.split('').filter(
        function(numb) {
            return (numb !== ".");
        }
    );

    if (number[numbers.length - position] == undefined) {
        return  (position > 1 ? ("The number doesn’t have " + position +" digits") : ("The number doesn’t have " + position + " digit"));
    } else {
        return number[numbers.length - position];
    }
}

console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([2, 356]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([6, 888.88]));