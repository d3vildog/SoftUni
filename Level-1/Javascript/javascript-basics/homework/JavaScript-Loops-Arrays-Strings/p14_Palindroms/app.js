function findPalindromes(str) {
    var words = str.toLowerCase().split(/[^A-Za-z]+/).filter(Boolean);
    var palindromes = [];
    var equal = true;

    for (var word = 0; word < words.length; word++) {

        for (var charr = 0; charr < words[word].length / 2; charr++) {
            if (words[word][charr] !== words[word][words[word].length - 1 - charr]) {
                equal = false;
                break;
            }
        }

        if (equal == true) {
            palindromes.push(words[word]);
        }
        equal = true;
    }

    console.log(palindromes.join(", "));
}

findPalindromes('There is a man, his name was Bob.');