
<!DOCTYPE html>
<html>
<style>
input[type=text], select {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

input[type=submit] {
  width: 100%;
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}

input[type=submit]:hover {
  background-color: #45a049;
}

div {
  border-radius: 5px;
  background-color: #f2f2f2;
  padding: 20px;
}
</style>
<body>



<div>
  <h3>Cliente en PHP para servidor Rest. (Validación de Rut)</h3>
  
  <?php 
  $parameters = ($_GET["rut"]);
  $server = file_get_contents('http://localhost:54901/api/rut/' . rawurlencode(($parameters)));
$obj = json_decode($server);
echo $obj->{'msgValido'}; 
	 ?>
  
</div>

</body>
</html>


