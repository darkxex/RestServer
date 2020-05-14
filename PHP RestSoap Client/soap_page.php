
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
  <h3>Cliente en PHP para servidor Soap. (Saludar)</h3>
  <?php 
  $parameters = ($_GET["nombre"]) . "/" . $_GET["paterno"] . "/" . $_GET["materno"] . "/" . $_GET["genero"];

$soapclient = new SoapClient('http://localhost:8080/test/Servicio.svc?wsdl', array('trace' => true));
$param = array('NOMBRES' => ($_GET["nombre"]),'AP_PATERNO' => $_GET["paterno"],'AP_MATERNO' => $_GET["materno"],'G' => $_GET["genero"],);

$response = $soapclient->Nombre($param);

echo $response->NombreResult;

	 ?>
  
</div>

</body>
</html>



