function pricesTrends(input) {
    var numbers = input.map(Number);
    var prevPrice = undefined;
    console.log("<table>");
    console.log("<tr><th>Price</th><th>Trend</th></tr>");
    
    for (var i = 0; i < numbers.length; i++) {
        var price = numbers[i];
        var priceStr = price.toFixed(2);
        
        if (prevPrice == undefined || priceStr == prevPrice) {
            var trend = "fixed";
        } else if (price > prevPrice) {
            var trend = "up";
        } else {
            var trend = "down";
        }
        
        console.log('<tr><td>' + priceStr + '</td><td><img src="' + trend + '.png"/></td></td>');
        prevPrice = priceStr;
    }
    console.log("</table>");
}