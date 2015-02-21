function findLargestBySum(arr) {
    var biggestSum = [0, 0];

    for (var i = 0; i < arr.length; i++) {
        var currSum = calcSum(Math.abs(arr[i]));

        if (currSum > biggestSum[0]) {
            biggestSum[0] = currSum;
            biggestSum[1] = arr[i];
        }
    }

    if (biggestSum[0] == 0) {
        return undefined;
    } else {
        return biggestSum[1];
    }

    function calcSum(numb) {
        var sum = 0;

        if (numb < 10) {
            return 0;
        }

        while (numb > 0) {
            sum = sum + numb % 10;
            numb = Math.floor(numb / 10);
        }

        return sum;
    }
}

console.log(findLargestBySum([5, 10, 15, 111]));
console.log(findLargestBySum([33, 44, -99, 0, 20]));
console.log(findLargestBySum(['hello']));
console.log(findLargestBySum([5, 3.3]));
