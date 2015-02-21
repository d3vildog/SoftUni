<html>
<head>
    <meta charset="UTF-8">
    <title>HTML Table</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>

    <div id="wrapper">
        <section>
            <form method="get">
                <label for="name">Name</label>
                <input type="text" id="name" name="table[]"/>
                <br/>

                <label for="tel">Telephone</label>
                <input type="tel" id="tel" name="table[]"/>
                <br/>

                <label for="age">Age</label>
                <input type="text" id="age" name="table[]"/>
                <br/>

                <label for="address">Address</label>
                <input type="text" id="address" name="table[]"/>

                <input type="submit" value="Create Table"/>
            </form>
        </section>
    </div>

<?php
if (isset($_GET['table'])) {
    $table = $_GET['table'];
    echo "<table>";
    echo "<tr>";
    echo "<th colspan='2' style='text-align: center; background-color: darkgoldenrod'>";
    echo "Dynamic table";
    echo "</th>";
    echo "</tr>";
    echo "<tr>";
    echo "<th>";
    echo "Name";
    echo "</th>";
    echo "<td>";
    echo "$table[0]";
    echo "</td>";
    echo "</tr>";
    echo "<tr>";
    echo "<th>";
    echo "Telephone";
    echo "</th>";
    echo "<td>";
    echo "$table[1]";
    echo "</td>";
    echo "</tr>";
    echo "<tr>";
    echo "<th>";
    echo "Age";
    echo "</th>";
    echo "<td>";
    echo "$table[2]";
    echo "</td>";
    echo "</tr>";
    echo "<tr>";
    echo "<th>";
    echo "Address";
    echo "</th>";
    echo "<td>";
    echo "$table[3]";
    echo "</td>";
    echo "</tr>";
    echo "</table>";
}
?>
</body>
</html>