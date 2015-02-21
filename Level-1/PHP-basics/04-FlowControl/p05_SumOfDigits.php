<html>
<head>
    <meta charset="UTF-8">
    <title>Sum of Digits</title>
    <style>
        table, tbody, tr, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <div id="wrapper">
        <form method="post">
            <label for="input">Input string:</label>
            <input type="text" name="input"/>
            <input type="submit"/>
            <input type="hidden" name="hid"/>
        </form>
    </div>

<?php
if (isset($_POST['hid']) && isset($_POST['input'])) {
    $array = $_POST['input'];
    $numbers = preg_split("/, /", $array, -1, PREG_SPLIT_NO_EMPTY);
    //$numbers = array_map('intval', $numbers);

    function sumDigits($number){
        $sum = 0;

        while($number > 0){
            $sum = $sum + ($number % 10);
            $number = $number / 10;
        }
        return $sum;
    }

    echo '<table>';
    echo '<tbody>';
    for ($i = 0; $i < count($numbers); $i++) {
        echo '<tr>';
        echo '<td>';
        echo $numbers[$i];
        echo '<td>';

        if (is_int((int)$numbers[$i]) == true && sumDigits($numbers[$i]) != 0 ) {
            echo sumDigits($numbers[$i]);
        }else {
            echo "I cannot sum that";
        }
    }
}
?>
</body>
</html>