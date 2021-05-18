<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <!-- Mis estilos CSS -->
    <link rel="stylesheet" href="../../css_index/Stilos.css">
    <link rel="stylesheet" href="../../css_servicios/estilos_gallery.css">
    <link rel="stylesheet" href="../../css_index/estilos_textos.css">
    <title>SCMB</title>
  </head>
  <body>
    
    <header class="header">
    <h1 class="titulo text-center my-4">Multiservicios<span>Braalanma</span></h1> 
    <div class="login-box">
        <img class="ilogin" src="../../Login/img/Logo.png" alt="Logo de VisuaLook"><br>
    </div>
    

      <nav class="navbar navbar-expand-lg navbar-light justify-content-center">
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#nav-principal" 
              aria-label="NavegacionPrincipal">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div id="nav-principal" class="collapse navbar-collapse">
              <nav class="navegacion-principal nav justify-content-between container
              flex-column flex-lg-row text-center">
                  <a href="../../Login/index.php" class="nav-link ">Inicio</a>
                  <a href="../../Login/galeria_productos.php" class="nav-link "> Productos </a>
                  <a href="../../Login/servicios.php" class="nav-link nav-link__select">Servicios</a>
                  <a href="../../Login/contacto.html" class="nav-link">Contacto</a>
                  <a href="../../Login/ubicacion.php" class="nav-link">Ubicación</a>
                  <a href="../../Login/Nosotros.php" class="nav-link">Nosotros</a>
                  <a href="../../Login/datos.php" class="nav-link">Registrarse</a>
              </nav>
          </div>
      </nav>  
    </header> 
    <div class="container-all">
    <?php
			include_once 'conexion.php';
            $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
            $sqlQuery="SELECT * FROM Servicio WHERE Idservicio='8' ";
            $resultado=$mysqlConexion->query($sqlQuery);
            while ($row=$resultado->fetch_assoc()){
        ?>
       <h1 class="title"><?php echo $row['NombreS'];?></h1>
       <img src="<?php  echo $row["images"];?>" class="img-fluid">

       <h1 class="sub-title"> Multiservicios Braalanma</h1>
       <p> SERVIMANTX cuenta con un equipo profesional certificado dedicado a ofrecer soluciones Industriales, Residenciales y Comerciales en servicio de impermeabilización, aislamiento térmico y recubrimientos. </p> 
       <p> Hemos sido contratados por empresas e instituciones públicas y privadas, quienes han comprobado la calidad de nuestros servicios. Confía en Impermeabilizantes Al Koat, contamos con personal altamente calificado que te ayudará a encontrar los productos y servicios ideales para tu inmueble. Recuerda que tenemos el impermeabilizante ideal para tu inmueble, además de enseñarte a aplicarlo. </p>
       <p> Llama, recuerda que más de 20 años de experiencia nos avalan. Después de que las goteras se hayan reparado adecuadamente, las paredes interiores afectadas deberán secarse por completo antes de poder repararlas. También es necesario realizar inspecciones de seguimiento para garantizar que las fugas se hayan detenido antes de que comiences cualquier trabajo de reparación en las paredes afectadas.  </p>
       <p> Antes de llegar al punto en que las goteras han maltratado tus espacios, es mejor contar con el servicio de impermeabilización. Tu hogar es una de las inversiones más valiosas que tienes, ¡mantenla protegida del agua con una impermeabilización profesional! </p>
       
       <a class="btn btn-success mb-2 btn-lg text-uppercase font-weight-bold" href=".././compra_s.php?id=<?php echo $row['Idservicio']; ?>">Contactar Servicio</a>
       <?php
          }
        ?>
   </div>

    <section id="galeria" class="container">
      <div class="text-center pt-5">
        <h1>  Nuestros trabajos</h1>
      </div>

      <div class="row">
          <div class="col-lg-4 col-md-6 col-sm-12">
            <img src="../../img_index/Servicios/impermeabilizacion_1.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/impermeabilizacion_2.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/impermeabilizacion_3.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/impermeabilizacion_4.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/impermeabilizacion_5.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/impermeabilizacion_6.jpg">
          </div>
      </div>
    </section>
    
    <footer class="container-fluid footer text-center pt-4 pb-4">
      <p class="copy"> &copy; 2021 Braalanma | Todos los derechos reservados</p>
    </footer>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>