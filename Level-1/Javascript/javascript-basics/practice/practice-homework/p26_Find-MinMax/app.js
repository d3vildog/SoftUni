function findMinAndMax(arr) {
    var minNumber = Math.min.apply(null, arr);
    var maxNumber = Math.max.apply(null, arr);

    return {
        min: minNumber,
        max: maxNumber
    }
}

console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));