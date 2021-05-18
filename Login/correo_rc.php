<?php 
use  PHPMailer\PHPMailer\PHPMailer;
use  PHPMailer\PHPMailer\Exception;
include_once 'conexion.php';
$mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
require  'Phpmailer/Exception.php' ;
require  'Phpmailer/PHPMailer.php' ;
require  'Phpmailer/SMTP.php' ;

$email=$_POST['cusuario'];
// La instanciación y el paso de `true` habilita excepciones 
$mail = new  PHPMailer ( true );

try {
    $mail->SMTPOptions = array(
		'ssl' => array(
		'verify_peer' => false,
		'verify_peer_name' => false,
		'allow_self_signed' => true
		)
	);
     // Configuración del servidor 
    $mail->SMTPDebug = 0;                      // Habilita la salida de depuración detallada 
    $mail -> isSMTP ();                                            // Enviar usando SMTP 
    $mail -> Host        = 'smtp.gmail.com' ;                    // Configure el servidor SMTP para enviar a través de 
    $mail -> SMTPAuth    = true ;                                   // Habilita la autenticación SMTP 
    $mail -> Username    = 'felipeacosta817@gmail.com' ;                     // Nombre 
    $mail -> Password    = 'PassWord1God99&' ;                               // Contraseña SMTP 
    $mail -> SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;         // Habilite el cifrado TLS; `PHPMailer :: ENCRYPTION_SMTPS` alentó 
    $mail -> Port        = 587 ;                                    // Puerto TCP para conectarse, use 465 para `PHPMailer :: ENCRYPTION_SMTPS` arriba

    // Destinatarios 
    $mail -> setFrom ( 'felipeacosta817@gmail.com' , 'SCMB' );

    $sqlQuery="SELECT nombrecompleto FROM usuario WHERE correo='$email' ";
$resultado=$mysqlConexion->query($sqlQuery);
while ($row=$resultado->fetch_assoc()){
     $mail -> addAddress ( $email, $row["nombrecompleto"]);    // Agregar un destinatario
     //echo $row["password"]; 
}
    //$mail -> addAddress ( $email, 'Holis');    // Agregar un destinatario 

    // Archivos adjuntos 
    //$ mail -> addAttachment ( '/var/tmp/file.tar.gz' );         // Agregar archivos adjuntos 
    //$ mail -> addAttachment ( '/tmp/image.jpg' , 'new.jpg' );    // Nombre opcional

    // Contenido 
    $mail -> isHTML (true);                                  // Establecer el formato de correo electrónico en HTML 
    $mail -> Subject = 'RECUPERACION DE CONTRASENA' ;

///////////////////////////////////////////////////////////

$sqlQuery="SELECT password FROM usuario WHERE correo='$email' ";
$resultado=$mysqlConexion->query($sqlQuery);
while ($row=$resultado->fetch_assoc()){
     $mail -> Body     = ('Haz solicitado recuperar tu contrasenia <br> Tu contrasena es: '.$row["password"]);
}
    
/////////////////////////////////////////////////////////

    //$mail -> Body     = ('Haz solicitado recuperar tu contrasenia <br> Tu contrasena es: '.$row["password"]);
    //$ mail -> AltBody = 'Este es el cuerpo en texto plano para clientes de correo que no son HTML' ;

    $mail -> send();
    include("index.php");
    //echo  'Mensaje enviado correctamente' ;
} catch ( Exception  $e ) {
     echo  "No se pudo enviar el mensaje. Error de correo: {$mail-> ErrorInfo}";
}
     //echo $v1['valor1']
