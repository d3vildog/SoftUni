function findMaxSequence(arr) {
    var maxSequence = 0;
    var currSequence = 0;
    var char;
    
    for (var i = 0; i < arr.length; i++) {
        var currNumb = arr[i];
        var nextNumb = arr[i + 1];

        if (currNumb === nextNumb) {
            currSequence++;
        } else {
            currSequence = 1;
        }

        if (maxSequence <= currSequence) {
            maxSequence = currSequence;
            char = currNumb;
        }
    }

    var result = [];
    for (var j = 0; j < maxSequence; j++) {
        result.push(char);
    }

    return result;
}

console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));