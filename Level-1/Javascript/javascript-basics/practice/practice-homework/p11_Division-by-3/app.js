function divisionBy3(number) {
    if (number < 10) {
        console.log("The number cannot be less than 10!");
        return;
    } else if (sumDigits(number) == true) {
        console.log("the number is divided by 3 without remainder");
    } else {
        console.log("the number is not divided by 3 without remainder");
    }

    function sumDigits(num) {
        var sum = 0;

        while (num > 0) {
            sum += num % 10;
            num = Math.floor(num / 10);
        }

        return sum % 3 == 0;
    }
}

divisionBy3(12);
divisionBy3(188);
divisionBy3(591);