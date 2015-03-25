function Vector() {
    var vector = arguments[0];

    function addd(otherVector) {
        var newVector = vector.slice(0);

        for (var i = 0; i < newVector.length; i++) {
            var dimensionA = newVector[i];
            var dimensionB = otherVector[i];
            newVector[i] += otherVector[i];
        }

        return newVector;
    }

    function toString() {
        return vector;
    }

    return {
        addd: addd,
        toString: toString
    }
}

var a = new Vector([1, 2, 3]);
var b = new Vector([2, 2, 2]);
console.log(a.addd(b));
console.log(a.toString());
