<?php

 include 'func.php';
 
 $doll = new Dolly();
 
 echo md5("1234") . "<br>";
  
 echo $doll->Member_Login("Nazio", "1234") . "<br>";
 echo $doll->Employee_Login("momo", "1234");


?>