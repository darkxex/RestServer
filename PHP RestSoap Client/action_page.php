
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
  <h3>Cliente en PHP para servidor Rest. (Saludar)</h3>
  <?php 
  $parameters = rawurlencode($_GET["nombre"]) . "/" . rawurlencode($_GET["paterno"]) . "/" . rawurlencode($_GET["materno"]) . "/" . rawurlencode($_GET["genero"]);
  $server = file_get_contents('http://localhost:5000/api/Name/' . (($parameters)));

$obj = json_decode($server);
echo $obj->{'msgSaludo'}; 

	 ?>
  
</div>

</body>
</html>



