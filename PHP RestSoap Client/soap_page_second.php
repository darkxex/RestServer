
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
  <h3>Cliente en PHP para servidor SOAP. (Validación de Rut)</h3>

<?php 

$parameters = ($_GET["rut"]);
//Create the client object
$soapclient = new SoapClient('http://localhost:8080/test/Servicio.svc?wsdl', array('trace' => true));

//Use the functions of the client, the params of the function are in 
//the associative array
//$params = array('CountryName' => 'Spain', 'CityName' => 'Alicante');
//$response = $soapclient->getWeather($params);

//var_dump($response);

// Get the Cities By Country
$param = array('r' => $parameters);

$response = $soapclient->Rut($param);

echo $response->RutResult;

 

	 ?>
  
</div>

</body>
</html>



