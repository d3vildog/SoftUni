function biggestTableRow(input) {
    var biggestSum = [Number.NEGATIVE_INFINITY, ""];

    for (var i = 2; i < input.length - 1; i++) {
        var currStr = input[i];
        var numbers = currStr.split(/[^0-9.-]+/);
        var currSum = sumOf(numbers);

        if (currSum > biggestSum[0]) {
            biggestSum[0] = currSum;
            biggestSum[1] = numbers;
        }
    }

    function sumOf(nums) {
        var a = parseFloat(nums[1]) || 0;
        var b = parseFloat(nums[2]) || 0;
        var c = parseFloat(nums[3]) || 0;

        return a + b + c;
    }

    var firstNumber = (biggestSum[1][1] || "") == "-" ? "" : (biggestSum[1][1] || "");
    var secondNumber = (biggestSum[1][2] || "") == "-" ? "" : (biggestSum[1][2] || "");
    var thirdNumber = (biggestSum[1][3] || "") == "-" ? "" : (biggestSum[1][3] || "");

    if (firstNumber == "" && secondNumber == "" && thirdNumber == "") {
        console.log("no data");
    } else if ((firstNumber == "" && secondNumber == "")) {
        console.log(biggestSum[0] + " = " + thirdNumber);
    } else if ((secondNumber == "" && thirdNumber == "")) {
        console.log(biggestSum[0] + " = " + firstNumber);
    } else if ((firstNumber == "" && thirdNumber == "")) {
        console.log(biggestSum[0] + " = " + secondNumber);
    }else if (firstNumber == "") {
        console.log(biggestSum[0] + " = " + secondNumber + " + " + thirdNumber);
    }else if (secondNumber == "") {
        console.log(biggestSum[0] + " = " + firstNumber + " + " + thirdNumber);
    }else if (thirdNumber == "") {
        console.log(biggestSum[0] + " = " + firstNumber + " + " + secondNumber);
    } else {
        console.log(biggestSum[0] + " = " + firstNumber + " + " + secondNumber + " + " + thirdNumber);
    }
}

//biggestTableRow(
//    ["<table>",
//    "<tr><th>town</th><th>store1</th><th>store2</th><th>store3</th></tr>",
//    "<tr><td>sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>",
//    "<tr><td>varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>",
//    "<tr><td>plovdiv</td><td>17.2</td><td>12.3</td><td>6.4</td></tr>",
//    "<tr><td>bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>",
//    "</table>"]
//);

//biggestTableRow(
//    ["<table>",
//    "<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>",
//    "<tr><td>Varna</td><td>-</td><td>18.02</td><td>36.11</td></tr>",
//    "<tr><td>Pleven</td><td>1</td><td>-</td><td>1</td></tr>",
//    "<tr><td>Vidin</td><td>12850</td><td>-560</td><td>20833</td></tr>",
//    "<tr><td>Rousse</td><td>-</td><td>299.999999</td><td>-</td></tr>",
//    "<tr><td>Bourgas</td><td>-</td><td>25000</td><td>-</td></tr>",
//    "<tr><td>Plovdiv</td><td>17.2</td><td>-</td><td>6.4</td></tr>",
//    "<tr><td>Sofia</td><td>-</td><td>1</td><td>1</td></tr>",
//    "</table>"]
//);

//biggestTableRow(
//    ["<table>",
//    "<tr><th>town</th><th>store1</th><th>store2</th><th>store3</th></tr>",
//    "<tr><td>Sofia</td><td>12850</td><td>-560</td><td>20833</td></tr>",
//    "<tr><td>Rousse</td><td>-</td><td>50000.0</td><td>-</td></tr>",
//    "<tr><td>Bourgas</td><td>25000</td><td>25000</td><td>-</td></tr>",
//    "</table>"]
//);

biggestTableRow(
    ["<table>",
    "<tr><th>town</th><th>store1</th><th>store2</th><th>store3</th></tr>",
    "<tr><td>Pleven</td><td>-100</td><td>-200</td><td>-</td></tr>",
    "<tr><td>Varna</td><td>-100</td><td>-</td><td>-300</td></tr>",
    "<tr><td>Rousse</td><td>-</td><td>-200</td><td>-100</td></tr>",
    "</table>"]
);