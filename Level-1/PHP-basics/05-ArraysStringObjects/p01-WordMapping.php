<html>
<head>
    <meta charset="UTF-8">
    <title>Word Mapping</title>
    <style>
        input {
            display: block;
        }

        table, tr, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>

<form method="post">
    <textarea name="input" id="input" cols="30" rows="2"></textarea>

    <input type="submit" value="Count words"/>
</form>

<?php
if (isset($_POST['input'])) {
    $text = $_POST['input'];
    strtolower($text);
    $words = preg_split("/[^a-zA-Z]+/", $text, -1, PREG_SPLIT_NO_EMPTY);
    $wordMap = [];

    foreach ($words as $word) {
        if (!array_key_exists($word, $wordMap)) {
            $wordMap[$word] = 1;
        }else {
            $wordMap[$word]++;
        }
    }
    echo '<table>';

    foreach ($wordMap as $key => $value) {
        echo "<tr><td>$key</td><td>$value</td></tr>";
    }
}
?>
</body>
</html>