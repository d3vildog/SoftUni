function findMaxSequence(arr) {
    var biggesttArray = [];
    var currArray = [];
    var first = true;

    for (var i = 0; i < arr.length; i++) {
        var currNumber = arr[i];
        var nextNumber = arr[i + 1];

        if (nextNumber > currNumber) {
            if (first == true) {
                currArray.push(currNumber);
                first = false;
            }
            currArray.push(nextNumber);
        } else {
            currArray = [];
            first = true;
        }

        if (currArray.length > biggesttArray.length) {
            biggesttArray = currArray.slice();
        }
    }

    if (biggesttArray.length < 1) {
        return "no";
    }
    
    return biggesttArray;
}

console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));

