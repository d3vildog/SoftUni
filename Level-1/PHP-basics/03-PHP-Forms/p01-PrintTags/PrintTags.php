<html>
<head>
    <meta charset="UTF-8">
    <title>Print Tags</title>
    <style>
        input, span {
            display: block;
            margin: 5px;
        }
    </style>
</head>
<body>

<form method="get">
    <span>Enter Tags:</span>
    <input type="text" name="field"/>
    <input type="submit"/>
</form>

<?php
if (isset($_GET['field'])) {
    $list = explode(", ", $_GET['field']);
    for ($i = 0; $i < count($list); $i++) {
        echo "$i : $list[$i]" . '<br />';
    }
}
?>

</body>
</html>