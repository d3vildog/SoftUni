<html>
<head>
    <meta charset="UTF-8">
    <title>Coloring Texts</title>
</head>
<body>

<form method="post">
    <input type="text" name="input"/>
    <input type="submit"/>
</form>

<?php
if (isset($_POST['input'])) {
    $text = $_POST['input'];
    $text = str_replace(" ", "", $text);

    for ($i = 0; $i < strlen($text); $i++) {
        $word = $text[$i];

        if (ord($word) % 2 != 0) {
            echo "<span style='color: blue'>$word </span>";
        }else{
            echo "<span style='color: red'>$word </span>";
        }
    }
}

?>
</body>
</html>