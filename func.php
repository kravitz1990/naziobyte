<?php 

include 'LibSql.php';

define("HOST", "localhost");
define("USER", "root");
define("PASSWORD", "1234");
define("DATABASE", "dolly_bigeye");

class Dolly extends Query {

	
	function __construct() {

		$conn = mysql_connect(HOST,USER,PASSWORD);
	    mysql_select_db(DATABASE,$conn);		
     	mysql_query("SET NAMES UTF8");
		mysql_query("SET character__results=utf8");
		mysql_query("SET character_set_client=utf8");
		mysql_query("SET character_set_connection=utf8");
		
	}
	
	function __destruct() {}	

	
	function  Employee_Login($username, $password) {
		
		$tmpuser  = $username;
		$tmppass =  md5($password);
		$sq = "SELECT employee_id FROM employee WHERE User_name = '$tmpuser' AND Password = '$tmppass'";		
		$mc = mysql_db_query(DATABASE,$sq);
		$rs = mysql_fetch_array($mc);
		$id = $rs['Employee_id'];
		
		echo $id;
						
		if ($id != null) { return 1; } else {  return 0; }
			
	}
	
	
	function Member_Login($username, $password) {

	 $tmpuser  = $username;
	 $tmppass =  md5($password);		 
	 $sq = "SELECT Member_id FROM member WHERE User_name = '$tmpuser' AND Password = '$tmppass'";
	 $mc = mysql_db_query(DATABASE,$sq);
	 $rs = mysql_fetch_array($mc);
	 $id  = $rs['Member_id'];	 	 

	 if ($id != null) { return 1; } else {  return 0; }
	
	}
	 
	 
	 
	function  RegisterMember() {
		
		
		
	}
	
	

		
}

?>