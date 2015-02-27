<html>
<head>
    <meta charset="UTF-8">
    <title>Rich People's Problems</title>
    <style>
        table, tr, th, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <div id="wrapper">
        <form method="get">
            <label for="input">Enter cars</label>
            <input type="text" id="input" name="inp"/>
            <input type="submit" value="Show result"/>
        </form>
    </div>

<?php
if (isset($_GET['inp'])) {
    $array = $_GET['inp'];
    $colors = array('black', 'yellow', 'grey', 'green', 'blue', 'red', 'orange');
    $cars = preg_split("/, /", $array, -1, PREG_SPLIT_NO_EMPTY);

    echo '<table>';
    echo '<tr>';
    echo '<th>';
    echo 'Car';
    echo '<th>';
    echo 'Color';
    echo '<th>';
    echo 'Count';

    for ($i = 0; $i < count($cars); $i++) {
        echo '<tr>';
        echo '<td>';
        echo $cars[$i];
        echo '<td>';
        echo $colors[rand(0, count($colors) - 1)];
        echo '<td>';
        echo rand(1, 5);;
    }

}

?>
</body>
</html>