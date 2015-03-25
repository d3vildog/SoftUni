String.prototype.startsWith = function startsWith(substring) {
    var currString = this;
    var hasStart = true;
    
    for (var i = 0; i < substring.length; i++) {
        if (currString[i] != substring[i]) {
            hasStart = false;
            break;
        }
    }
    
    return hasStart;
}

String.prototype.endsWith = function endsWith(substring) {
    var currString = this;
    var hasEnd = true;
    var counter = (currString.length - substring.length);
    
    for (var i = currString.length - 1; i >= counter; i--) {
        var letter = currString[i];
        var subsLetter = substring[i - counter];

        if (letter != subsLetter) {
            hasEnd = false;
            break;
        }
    }
    
    return hasEnd;
}

String.prototype.left = function left(count) {
    var currString = this.slice(0);
    var cuttedString = currString.slice(0, count);

    return cuttedString;
}

String.prototype.right = function right(count) {
    var currString = this.slice(0);
    var cuttedString = currString.slice(count + 1, currString.length);
    
    return cuttedString;
}

String.prototype.padLeft = function padLeft(count, character) {
    var currentString = this;
    character = character || " ";
    var repeatedChar = Array(count + 1).join(character);
    var newString = repeatedChar + currentString;

    return newString;
}

String.prototype.padRight = function padRight(count, character) {
    var currentString = this;
    character = character || " ";
    var repeatedChar = Array(count + 1).join(character);
    var newString = currentString + repeatedChar;
    
    return newString;
}

String.prototype.repeat = function repeat(count) {
    var currString = this;
    var repeatedStr = Array(count + 1).join(currString);

    return repeatedStr;
}

var pepa = "*";
console.log(pepa.endsWith("ya"));
console.log(pepa.startsWith("pe"));
console.log(pepa.left(50));
console.log(pepa.right(3));
console.log(pepa.padLeft(3));
console.log(pepa.padRight(3, "@"));
console.log(pepa.repeat(20));
console.log(pepa);
// Another combination
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));

