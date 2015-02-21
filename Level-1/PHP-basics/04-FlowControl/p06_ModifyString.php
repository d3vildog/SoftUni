<html>
<head>
    <meta charset="UTF-8">
    <title>Modify String</title>
</head>
<body>

    <div id="wrapper">
        <form method="post">
            <input type="text" name="txt"/>

            <input type="radio" name="modify" id="p" value="p"/>
            <label for="p">Check Palindrome</label>
            <input type="radio" name="modify" id="rs" value="rs"/>
            <label for="rs" >Reverse String</label>
            <input type="radio" name="modify" id="s" value="s"/>
            <label for="s" >Split</label>
            <input type="radio" name="modify" id="h" value="h"/>
            <label for="h" >Hash String</label>
            <input type="radio" name="modify" id="ss" value="ss"/>
            <label for="ss" >Suffle String</label>

            <input type="submit" value="Submit"/>
            <input type="hidden" name="hid"/>
        </form>
    </div>

<?php
if (isset($_POST['hid']) && isset($_POST['txt']) && isset($_POST['modify'])) {
    $text = strtolower($_POST['txt']);

    function checkPalindrome(){
        global $text;
        $length = strlen($text) - 1;
        $palindrome = true;

        for ($i = 0; $i < $length; $i++) {
            if ($text[$i] != $text[$length - $i]) {
                $palindrome = false;
                break;
            }
        }

        if ($palindrome == true) {
            echo $text . " is palindrome!";
        }else {
            echo $text . " is not palindrome!";
        }

    }

    function reverseString(){
        global $text;
        $reversedString = "";
        $length = strlen($text) - 1;

        for ($i = $length; $i >= 0; $i--) {
            $reversedString .= $text[$i];
        }

        echo $reversedString;
    }

    function splitUM(){
        global $text;

        if (preg_match('/[^a-zA-Z ]+/', $text) == 0) {
            $shit = preg_split('//', $text, -1, PREG_SPLIT_NO_EMPTY);
        }else {
            exit("Only letters are allowed!!!");
        }

        echo implode(' ', $shit);
    }

    switch($_POST['modify']){
        case "p":
            checkPalindrome();
            break;
        case "rs":
            reverseString();
            break;
        case "s":
            splitUM();
            break;
        case "h";
            $crypt = crypt($text);
            echo $crypt;
            break;
        case "ss":
            echo str_shuffle($text);
            break;
        default;
    }
}

?>
</body>
</html>