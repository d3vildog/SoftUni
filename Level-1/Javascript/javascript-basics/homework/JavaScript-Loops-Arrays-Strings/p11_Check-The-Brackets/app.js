function checkBrackets(str) {
    var brackets = str.split(/[^()]+/);
    var leftBracket = 0;
    var rightBracket = 0;

    for (var i = 0; i < brackets.length; i++) {
        if (brackets[i] === "(") {
            leftBracket++;
        }else if (brackets[i] === ")") {
            rightBracket++;
        }
    }

    if (leftBracket == rightBracket) {
        console.log("correct");
    } else {
        console.log("incorrect");
    }
}

checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');