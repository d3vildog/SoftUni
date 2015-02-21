function reverseWordsInString(str) {
    var words = str.split(" ");
    var reversedWords = [];

    for (var i = 0; i < words.length; i++) {
        var currReversedWord = words[i].split('').reverse().join("");

        reversedWords[i] = currReversedWord;
    }

    return reversedWords.join(' ');
}

console.log(reverseWordsInString('Hello, how are you.'));
console.log(reverseWordsInString('Life is pretty good, isn’t it?'));