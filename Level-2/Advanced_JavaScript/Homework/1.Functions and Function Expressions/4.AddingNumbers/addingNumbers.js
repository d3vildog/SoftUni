function add(numb) {
    var sum = numb;

    function sumNumbers(number) {
        sum += number;

        return sumNumbers;
    }

    sumNumbers.toString = function() {return sum;}

    return sumNumbers;
}

var addTwo = add(2);
console.log(+addTwo); //2

var addTwo = add(2);
console.log(+addTwo(3)(5)(1)(7)); //18










