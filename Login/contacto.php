<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <!-- Mis estilos CSS 
    <link rel="stylesheet" href="../css_index/Stilosc.css">-->

     <!-- SCRIPTS
     <link rel="stylesheet" href="../css_contacto/estilos_CONTACTO.css">-->
     <link rel="stylesheet" href="../css_contacto/font-awesome.css">
 
     <script src="../jscript/jquery-3.2.1.js"></script>
     <script src="../jscript/script.js"></script>
     
    <meta http-equiv="X-UA-Compatible" content="IE=edge">

    <title>SCMB|CONTACTO</title>
  </head>
  <body>
    
    <header class="header">
      <h1 class="titulo text-center my-4">Multiservicios<span>Braalanma</span></h1> 
    <div class="login-box">
        <img class="iclogin" src="../Login/img/Logo.png" alt="Logo de "><br>
    </div>
    

      <nav class="navbar navbar-expand-lg navbar-light justify-content-center">
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#nav-principal" 
              aria-label="NavegacionPrincipal">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div id="nav-principal" class="collapse navbar-collapse">
              <nav class="navegacion-principal nav justify-content-between container
              flex-column flex-lg-row text-center">
                  <a href="../Login/index.php" class="nav-link ">Inicio</a>
                  <a href="../Login/galeria_productos.php" class="nav-link "> Productos </a>
                  <a href="../Login/servicios.php" class="nav-link">Servicios</a>
                  <a href="../Login/contacto.html" class="nav-link nav-link__select">Contacto</a>
                  <a href="../Login/ubicacion.php" class="nav-link">Ubicación</a>
                  <a href="../Login/Nosotros.php" class="nav-link">Nosotros</a>
                  <a href="../Login/datos.php" class="nav-link">Registrarse</a>
              </nav>
          </div>
      </nav>  
    </header> <br>
        <h1 class="titulo text-center my-4"> </h1> 
    

        
        <section class="form_wrap">

          <section class="cantact_info">
              <section class="info_title">
                  <span class="fa fa-user-circle"></span>
                  <h2>INFORMACION<br>DE CONTACTO</h2>
              </section>

              <section class="info_items">
                <p><span class="fa fa-envelope"></span> Multiservicios-braalanma@gmail.com</p>
                <p><span class="fa fa-mobile"></span> +52(961) 654 89 90</p>
            </section>
          </section>
  
          <form action="enviar_contacto.php" method="POST" class="form_contact">
              <h2>Escribenos un mensaje</h2>
              <div class="user_info">
                  <label for="names" >Nombres *</label>
                  <input type="text" id="names" name="nombre" required>
  
                  <label for="phone">Telefono / Celular</label>
                  <input type="text" id="phone" name="telefono "required>
  
                  <label for="email">Correo electronico *</label>
                  <input type="text" id="email" name="correo" required>
  
                  <label for="mensaje">Mensaje *</label>
                  <textarea id="mensaje" name="mensaje" required></textarea>
  
                  <input type="submit" value="Enviar Mensaje" id="btnSend">
              </div>
          </form>
      </section>
</body>

  <footer class="container-fluid footer text-center pt-4 pb-4">
    <p class="copy"> &copy; 2021 Braalanma | Todos los derechos reservados</p>
  </footer>

<!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</html>