
<!DOCTYPE html>
<html>
<head>
<script>
function validateForm() {
  var x = document.forms["datosnombre"]["nombre"].value;
  if (x == "" || x == null) {
    alert("Completa los Nombres");
    return false;
  }
  
  var x = document.forms["datosnombre"]["paterno"].value;
  if (x == "" || x == null) {
    alert("Completa el apellido Paterno");
    return false;
  }
   var x = document.forms["datosnombre"]["materno"].value;
  if (x == "" || x == null) {
    alert("Completa el apellido Materno");
    return false;
  }
}

function validateForm2() {
  var x = document.forms["datosrut"]["rut"].value;
  if (x == "" || x == null) {
    alert("Ingresa el Rut");
    return false;
  }
  
  
}
</script>
</head>
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

<h3>Cliente en PHP para servidor SOAP.</h3>
<p>
<h3>Nombre Propio.</h3>
<div>
  <form name="datosnombre" action="/soap_page.php" onsubmit="return validateForm()">
    <label for="name">Nombres:</label>
    <input type="text" id="name" name="nombre" placeholder="Nombres...">

    <label for="papellido">Apellido Paterno:</label>
    <input type="text" id="papellido" name="paterno" placeholder="Apellido Paterno...">
	
 <label for="pmaterno">Apellido Materno:</label>
    <input type="text" id="pmaterno" name="materno" placeholder="Apellido Materno...">
	
    <label for="gen">Género</label>
    <select id="gen" name="genero">
      <option value="M">Masculino</option>
      <option value="F">Femenino</option>
    </select>
  
    <input type="submit" value="Enviar datos">
  </form>
</div>
<h3>Validación dígito verificador.</h3>
<div>
  <form name="datosrut" action="/soap_page_second.php" onsubmit="return validateForm2()">
    <label for="crut">Rut:</label>
    <input type="text" id="crut" name="rut" placeholder="Rut a verificar... (ej: 18828818-9)">

    <input type="submit" value="Enviar Rut">
  </form>
</div>
</body>
</html>



