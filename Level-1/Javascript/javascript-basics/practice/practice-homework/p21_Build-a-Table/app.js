function buildTable(arr) {
    var startNumb = arr[0];
    var endNumb = arr[1];
    console.log("<table>");
    console.log("<tr><th>Num</th><th>Square</th><th>Fib</th></tr>");

    for (var i = startNumb; i <= endNumb; i++) {
        console.log("<tr><td>%s</td><td>%s</td><td>%s</td></tr>", i, i * i, calcFibonacciNums(i) ? "yes" : "no");
    }
    
    function calcFibonacciNums(maxNum) {
        var fibNums = { 1: true };
        var f1 = 1;
        var f2 = 1;
        while (true) {
            var f3 = f1 + f2;
            if (f3 > maxNum) {
                return fibNums;
            }
            fibNums[f3] = true;
            f1 = f2;
            f2 = f3;
        }
    }

    console.log("</table>");
}