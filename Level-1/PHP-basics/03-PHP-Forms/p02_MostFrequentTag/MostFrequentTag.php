<html>
<head>
    <meta charset="UTF-8">
    <title>Most Frequent Tag</title>
</head>
<body>

<form method="post">
    <span style="display: block; margin-bottom: 10px">Enter Tags:</span>
    <input type="text" name="field"/>
    <input type="hidden" name="submitted"/>
    <input type="submit"/>

<?php
if (isset($_POST['submitted'])) {
    if (isset($_POST['field']) && $_POST['field'] != "") {
        $list = explode(', ',$_POST['field']);

        for ($i = 0; $i < count($list); $i++) {
            $currKey = $list[$i];
            if (!isset($obj[$currKey])) {
                $obj[$currKey] = 1;
            }else{
                $obj[$currKey]++;
            }
        }
        arsort($obj);

        if (array_keys($obj) != "") {
            foreach($obj as $key => $value){
                echo "<p>$key : $value</p>";
            }

            echo "Most frequent Tag is: " . array_keys($obj)[0];
        }

    }
}

?>
</form>

</body>
</html>