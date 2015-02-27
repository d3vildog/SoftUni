<html>
<head>
    <meta charset="UTF-8">
    <title>Square root</title>
    <style>
        table, tr, td, th {
            border: 1px solid black;
            text-align: left;
        }
    </style>
</head>
<body>
<?php
echo '<table>';
echo '</tbody>';
echo '<tr>';
echo '<th>';
echo 'Number';
echo '<th>';
echo 'Square';
$sum = 0;
for ($i = 0; $i <= 100; $i+=2) {
    echo '<tr>';
    echo '<td>';
    echo $i;
    echo '<td>';
    echo (double)number_format(sqrt($i), 2);
    $sum += (double)number_format(sqrt($i), 2);
}
echo '<tr>';
echo '<th>';
echo 'Total:';
echo '<td>';
echo $sum;
?>
</body>
</html>