<html>
<head>
    <meta charset="UTF-8">
    <title>Form-Data</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
    <div id="wrapper">
        <form method="post">
            <input type="text" name="name"/>
            <input type="text" name="age"/>

            <div class="radio">
                <input type="radio" id="male" name="gender" value="male"/>
                <label for="male">Male</label>
            </div>
            <div class="radio">
                <input type="radio" id="female" name="gender" value="female"/>
                <label for="female">Female</label>
            </div>
            <input type="submit" value="Submit"/>
        </form>
    </div>

<?php
if (isset($_POST['name'])) {
    $name = $_POST['name'];
    $age = $_POST['age'];
    $gender = $_POST['gender'];
    echo "My name is $name. I am $age years old. I am $gender.";
}
?>
</body>
</html>