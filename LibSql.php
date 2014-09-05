<?

class Query {
	
  
   private $Key = array();
   private $Value = array();
    
   function assign($key, $value) {
		
	   $this->Key[] =  $key;
	   $this->Value[] =  $value;
	      
   }	
  
  function InsertToDB($db_name, $table_name) {
	
	$temp_key = NULL;
	$temp_val = NULL;
	$result   = NULL;  
	
	for ($i = 0; $i < count($this->Key) ; $i++) {
		
		$temp_key .= $this->Key[$i] . ", ";
		$temp_val .= "'" . $this->Value[$i] . "', ";
	
    }
	
    $temp_key = substr($temp_key,0, strlen($temp_key)-2);
	$temp_val = substr($temp_val,0, strlen($temp_val)-2);

	
	$result = "insert into $table_name(" . $temp_key . ") values(" . $temp_val . ")" ;
	
	mysql_db_query($db_name,$result);
	
  }
  
  function UpdateDB($db_name, $table_name, $primaryKey, $rowIndex) {
	  
	$temp = NULL;
	$result = NULL; 
	
	for ($i = 0; $i < count($this->Key) ; $i++) {
		
		$temp .= $this->Key[$i] . " = " . "'" . $this->Value[$i] . "', " ;
				
	}
	
	  $temp = substr($temp,0, strlen($temp)-2);
	  $result = "UPDATE $table_name SET " . $temp . " WHERE " . $primaryKey . " = '" . $rowIndex . "'";
	  	
	  mysql_db_query($db_name,$result);
	  
	  
  }
	

  function DeleteRecord($db_name, $table_name, $primaryKey, $rowIndex) {
	 	  
	  $result = "DELETE FROM " . $table_name . " WHERE " . $primaryKey . " = " . "'" . $rowIndex . "'" ;
	  mysql_db_query($db_name,$result);
	  
	  echo $result;
	 	   
  }
    	

}

?>