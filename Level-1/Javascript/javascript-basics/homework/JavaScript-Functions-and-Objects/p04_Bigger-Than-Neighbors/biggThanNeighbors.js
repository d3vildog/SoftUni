function biggerThanNeighors(index, arr) {
    if (arr[index] == undefined) {
        return "invalid index";
    } else if ((arr[index - 1] == undefined && typeof arr[index + 1] == "number") ||
                    (arr[index + 1] == undefined && typeof arr[index - 1] == "number")) {
        return "only one neighbor";
    }else if (arr[index] > arr[index + 1] && arr[index] > arr[index - 1]) {
        return "bigger";
    } else {
        return "not bigger";
    }
}

console.log(biggerThanNeighors(2, [1, 2, 3, 3, 5]));
console.log(biggerThanNeighors(2, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighors(5, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighors(0, [1, 2, 5, 3, 4]));
