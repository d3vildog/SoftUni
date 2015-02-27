<?php
    $firstNumber = 10;
    $secondNumber = 7;

    echo '$firstNumber + $secondNumber = ' . "$firstNumber + $secondNumber = " .
        number_format((float)($firstNumber + $secondNumber), 2, '.', '');
?>