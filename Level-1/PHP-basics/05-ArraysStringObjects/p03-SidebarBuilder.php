<html>
<head>
    <meta charset="UTF-8">
    <title>Sidebar Builder</title>
    <style>
        label {
            display: inline-block;
            width: 70px;
        }

        ul {
            display: block;
            width: 160px;
            border: 1px solid black;
            background-color: cadetblue;
            padding: 20px;
        }
    </style>
</head>
<body>
    <div id="wrapper">
        <form method="post">
            <label for="categories">Categories</label>
            <input type="text" id="categories" name="cat"/>
            <br/>

            <label for="tags">Tags</label>
            <input type="text" id="tags" name="tags"/>
            <br/>

            <label for="months">Months</label>
            <input type="text" id="months" name="months"/>
            <br/>

            <input type="submit" value="Generate"/>
        </form>
    </div>

<?php
if (isset($_POST['cat']) && isset($_POST['tags']) && isset($_POST['months'])) {
    $categories = $_POST['cat'];
    $categories = preg_split("/, /", $categories, -1);

    $tags = $_POST['tags'];
    $tags = preg_split("/, /", $tags, -1);

    $months = $_POST['months'];
    $months = preg_split("/, /", $months, -1);

    echo "<ul>";
    echo "<h2>Categories</h2>";
    foreach ($categories as $cat) {
        echo "<li>$cat</li>";
    }
    echo "</ul>";

    echo "<ul>";
    echo "<h2>Tags</h2>";
    foreach ($tags as $tag) {
        echo "<li>$tag</li>";
    }
    echo "</ul>";

    echo "<ul>";
    echo "<h2>Months</h2>";
    foreach ($months as $mon) {
        echo "<li>$mon</li>";
    }
    echo "</ul>";
}

?>
</body>
</html>