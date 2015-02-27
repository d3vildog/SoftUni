<?php
$n = 247;
$diffDigits = false;
$output = [];
for ($i = 100; $i <= $n; $i++) {
    $allDigits = $i . "";
    $firstDigit = $allDigits[0];
    for ($a = 1; $a <= 1; $a++) {
        $currDigit = $allDigits[1];
        $currInnerDigit = $allDigits[2];

        if ($firstDigit == $currDigit || $firstDigit == $currInnerDigit || $currDigit == $currInnerDigit) {
            $diffDigits = true;
            continue;
        }
    }

    if (!$diffDigits) {
        $output[] = $i;
    }else {
        $diffDigits = false;
    }
}
if (empty($output)) {
    echo "no";
    die;
}
echo implode(', ', $output);
?>