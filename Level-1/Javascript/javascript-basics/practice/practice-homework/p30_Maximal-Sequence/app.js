function findMaxSeuence(arr) {
    var maxSequence = [0];
    var currSequence = 0;

    for (var i = 1; i < arr.length; i++) {
        if (arr[i] == arr[i - 1]) {
            currSequence++;

            if (currSequence > maxSequence[0]) {
                maxSequence[0] = currSequence;
                maxSequence[1] = arr[i];
            }
        } else {
            currSequence = 1;
        }
    }

    return maxSequence;
}

console.log(findMaxSeuence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSeuence(['happy']));
console.log(findMaxSeuence([2, 'qwe', 'qwe', 3, 3, '3']));