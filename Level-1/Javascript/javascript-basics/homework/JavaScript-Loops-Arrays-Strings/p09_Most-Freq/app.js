function findMostFreqNum(arr) {
    var numbers = {};
    var biggestNumber = [0, 0];

    for (var i = 0; i < arr.length; i++) {
        var key = arr[i];

        if (!(key in numbers)) {
            numbers[key] = 1;
        } else {
            numbers[key]++;
        }
    }

    for (var key in numbers) {
        if (numbers[key] > biggestNumber[1]) {
            biggestNumber[1] = numbers[key];
            biggestNumber[0] = key;
        }
    }

    console.log("%s (%s times)", biggestNumber[0], biggestNumber[1]);
}

findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);