# RestServer/SoapServer c# y clientes PHP
Rest Server en c# para verificar rut y nombres.
Usando Visual Studio 2017.
Rest Client en PHP para acceder al servidor.
sé usó algo de Javascript para validar algunos datos.

Instrucciones
-----------------------------------------------
1. Instalar Xammpp.
2. habilitar SoapClient en Xammpp. aquí un tutorial si no sabes. https://www.youtube.com/watch?v=ZIv06qYntnI
3. mover el contenido de "PHP RestSoap Client" a htdocs de tu Xammpp.
4. iniciar Xammpp y entrar a localhost para cargar los clientes.
5. iniciar los servidores correspondientes con Visual Studio 2017.

Compilados
----------------------------------------------------------
1. el restservercompiled es un ejecutable, llegar y abrir que usa el puerto 5000.
2. el soapservercompiled es un archivo svc que debe ser ejecutado con IIS. (con framework 4.5)
3. la ruta del soap debe quedar así http://localhost:8080/test/Servicio.svc?wsdl por ende el IIS debe usar
el puerto 8080.


