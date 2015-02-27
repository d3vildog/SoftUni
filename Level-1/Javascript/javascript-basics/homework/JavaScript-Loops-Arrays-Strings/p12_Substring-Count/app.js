function countSubstringOccur(arr) {
    var keyWord = arr[0].toLowerCase();
    var text = arr[1].toLowerCase();
    var index = text.indexOf(keyWord);
    var counter = 0;

    while (index !== -1) {
        counter++;
        index = text.indexOf(keyWord, index + 1);
    }

    console.log(counter);
}

countSubstringOccur(['in', 'We are living in a yellow submarine. We donthave anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.']);
countSubstringOccur(['your', 'No one heard a single word you said. They should have seen it in your eyes. What was going around your head.']);
countSubstringOccur(['but', 'But you were living in another world tryin to get your message through.']);