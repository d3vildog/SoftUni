<html>
<head>
    <meta charset="UTF-8">
    <title>Show Annual Expenses</title>
    <style>
        table, tr, td, th {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <div id="wrapper">
        <form method="post">
            <label for="inp">Enter number of years:</label>
            <input type="text" id="inp" name="inp"/>
            <input type="submit" value="Show costs"/>
            <input type="hidden" name="hid"/>
        </form>
    </div>

<?php
if (isset($_POST['hid'])) {
    if (isset($_POST['inp'])) {
        $years = $_POST['inp'];
        $currentYear = 2014;

        echo '<table>';
        echo '<tbody>';
        echo '<tr>';
        echo '<th>';
        echo 'Year';
        echo '<th>';
        echo 'January';
        echo '<th>';
        echo 'February';
        echo '<th>';
        echo 'March';
        echo '<th>';
        echo 'April';
        echo '<th>';
        echo 'May';
        echo '<th>';
        echo 'June';
        echo '<th>';
        echo 'July';
        echo '<th>';
        echo 'August';
        echo '<th>';
        echo 'September';
        echo '<th>';
        echo 'October';
        echo '<th>';
        echo 'November';
        echo '<th>';
        echo 'December';
        echo '<th>';
        echo 'Total';

        for ($i = 0; $i < $years; $i++) {
            $totalSum = 0;
            echo '<tr>';
            echo '<td>';
            echo $currentYear - $i;
            for ($k = 0; $k < 12; $k++) {
                $randNumb = rand(0, 999);
                echo '<td>';
                echo $randNumb;
                $totalSum += $randNumb;
            }
            echo '<td>';
            echo $totalSum;
        }
    }
}

?>
</body>
</html>