Array.prototype.clone = function() {
    return this.slice(0);
}

Array.prototype.flattern = function flattern() {
    var newArray = this.clone();
    return newArray;
}

var arr = [1, 2, 3, [1, 3]];
console.log(arr.flattern());
console.log(arr);
