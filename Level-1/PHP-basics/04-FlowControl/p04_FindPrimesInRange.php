<html>
<head>
    <meta charset="UTF-8">
    <title>Find Primes in Range</title>
</head>
<body>
    <div id="wrapper">
        <form method="post">
            <label for="startIndex">Starting Index:</label>
            <input type="text" name="startIndex"/>

            <label for="startIndex">End:</label>
            <input type="text" name="endIndex"/>

            <input type="submit"/>
            <input type="hidden" name="hid"/>
        </form>
    </div>

<?php
if (isset($_POST['hid'])) {
    if (isset($_POST['startIndex']) && isset($_POST['endIndex'])) {
        $start = $_POST['startIndex'];
        $end = $_POST['endIndex'];
        $first = true;

        function isPrime($numb){
            for ($i = 2; $i < $numb; $i++) {
                if ($numb % $i == 0) {
                    return false;
                }
            }
            return true;
        }

        for ($i = $start; $i <= $end; $i++) {
            echo $first ? "" : "<span>, </span>";
            if (isPrime($i)) {
                echo "<span style='font-weight: bold'>$i</span>";
            }else {
                echo "<span>$i</span>";
            }
            $first = false;
        }
    }
}
?>
</body>
</html>