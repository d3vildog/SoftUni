function findMostFreqWord(str) {
    var words = str.toLowerCase().split(/[^A-Za-z]+/);
    var occurance = {};
    var mostFreqWord = 0;
    var freqWords = [];

    for (var i = 0; i < words.length; i++) {
        if (!(words[i] in occurance)) {
            occurance[words[i]] = 1;
        } else {
            occurance[words[i]] += 1;
        }
        mostFreqWord = mostFreqWord > occurance[words[i]] ? mostFreqWord : occurance[words[i]];
    }

    for (var word in occurance) {
        if (occurance[word] >= mostFreqWord) {
            mostFreqWord = occurance[word];
            freqWords.push(word);
        }
    }

    freqWords.sort();
    for (var key in freqWords) {
        console.log(freqWords[key] + " -> " + mostFreqWord + " times");
    }
}

findMostFreqWord('in the middle of the night');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');