<?php
$str = "hello";
echo gettype($str);
var_dump($str);

$int = 15;
var_dump($int);
echo gettype($int);

$double = 1.234;
var_dump($double);
echo gettype($double);

$arr = [1, 1, 12];
var_dump($arr);
echo gettype($arr);

$obj = (object)[2, 34];
var_dump($obj);
echo gettype($obj);
?>