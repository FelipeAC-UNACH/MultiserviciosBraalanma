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
    </header> <br>
    <div class="container-all">
    <?php
			include_once 'conexion.php';
            $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
            $sqlQuery="SELECT * FROM Servicio WHERE Idservicio='3' ";
            $resultado=$mysqlConexion->query($sqlQuery);
            while ($row=$resultado->fetch_assoc()){
        ?>
       <h1 class="title"><?php echo $row['NombreS'];?></h1>
       <img src="<?php  echo $row["images"];?>" class="img-fluid">
       <h1 class="sub-title"> Multiservicios Braalanma</h1>
       <p>  Empresa dedicada a la Instalación Eléctrica de Baja Tensión. Tratamos todo tipo de instalaciones electricas en Comunidades, Negocios, Viviendas Particulares. Tambien nos dedicamos a la instalación de CCTV y Alarmas sin Cuota de Mantenimientos, y sin CRA, no cobrando ningun tipo de mantenimiento mensual. </p>
       <p>  En Multiservicios Braalanma contamos con una amplia gama de personal encargados de asesorar y gestionar los tramites cara a industria para asegurar así que nuestros proyectos e instalaciones cumplen la normativa vigente. </p>
       <p>  Instalaciones y mantenimientos eléctricos en general Nuestra experiencia nos permite desarrollar el trabajo de forma rápida y eficaz. Siendo siempre competentes en aquello que hacemos. No dudes en contactar con nosotros, solicita una cita para que podamos asesorarte y guiarte. Nuestros presupuestos siempre se ajustan a las necesidades de cada cliente. Puedes visitar nuestro perfil, ver las fotos de trabajos que realizamos y las opiniones de todos nuestros clientes satisfechos. </p>
     
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
          <img src="../../img_index/Servicios/electricidad_1.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/electricidad_2.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/electricidad_3.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/electricidad_4.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/electricidad_5.jpg">
          </div>

          <div class="col-lg-4 col-md-6 col-sm-12">
          <img src="../../img_index/Servicios/electricidad_6.jpg">
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