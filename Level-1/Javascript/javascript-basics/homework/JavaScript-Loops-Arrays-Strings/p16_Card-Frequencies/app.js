function findCardFrequency(cards) {
    var cardFaces = cards.split(/[^\dJQKA]+/).filter(Boolean);
    var frequencies = {};

    for (var i = 0; i < cardFaces.length; i++) {
        if (!(cardFaces[i] in frequencies)) {
            frequencies[cardFaces[i]] = 1;
        } else {
            frequencies[cardFaces[i]] += 1;
        }
    }

    for (var key in frequencies) {
        console.log(key + " -> " + frequencies[key] / cardFaces.length * 100 + "%");
    }
}

console.log(findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦'));
console.log(findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠'));
console.log(findCardFrequency('10♣ 10♥'));