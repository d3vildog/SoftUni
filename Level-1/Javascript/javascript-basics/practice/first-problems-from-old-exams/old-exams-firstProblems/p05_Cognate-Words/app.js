function solve(param) {
    var input = param[0];
    var words = input.split(/[^A-Za-z]+/).filter(Boolean);
    var cognateWords = [];
    
    for (var a = 0; a < words.length; a++) {
        for (var b = 0; b < words.length; b++) {
            for (var c = 0; c < words.length; c++) {
                if (a != b && words[a] + words[b] == words[c] 
                    && cognateWords.indexOf(words[a] + "|" + words[b] + "=" + words[c]) < 0) {
                    cognateWords.push(words[a] + "|" + words[b] + "=" + words[c]);
                }
            }
        }
    }
    
    if (cognateWords == "") {
        return console.log("No");
    }
    
    console.log(cognateWords.join("\n"));
}