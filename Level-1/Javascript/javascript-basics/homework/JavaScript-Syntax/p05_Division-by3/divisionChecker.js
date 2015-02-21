function divisionBy3(number){
    var sum = 0;

    if (number < 10) {
        return "The number must be bigger or equal than 10!";
    }

    while(number > 0){
        sum = sum + (number % 10);
        number = parseInt(number / 10);
    }

    if (sum % 3 == 0) {
        return "the number is divided by 3 without remainder";
    }else {
        return "the number is not divided by 3 without remainder";
    }
}

console.log(divisionBy3(12));
console.log(divisionBy3(188));
console.log(divisionBy3(591));