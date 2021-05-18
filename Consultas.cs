using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SCMB
{
    class Consultas
    {
        Conexion bd = new Conexion();
        public DataSet datos = new DataSet();
        public void pedidosProductosTodos()
        {
            string consulta = "SELECT * FROM Pedidoproducto INNER JOIN Producto on Pedidoproducto.idproducto=Producto.idProducto";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "Pedidoproducto, Producto");
        }

        public void pedidosServiciosTodos()
        {
            string consulta = "SELECT * FROM Pedidoservicio INNER JOIN Servicio on Pedidoservicio.idservicio=Servicio.idservicio";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "Pedidoservicio, Servicio");
        }

        public void buscarProductoID(string clavePedidoID)
        {
            string consulta = "SELECT * FROM Pedidoproducto INNER JOIN Producto ON PedidoProducto.idproducto=Producto.IdProducto WHERE PedidoProducto.idpedido='" + clavePedidoID + "'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "PedidoProducto, Producto");
        }
        public void buscarServicioID(string clavePedidoID)
        {
            string consulta = "SELECT * FROM Pedidoservicio INNER JOIN Servicio ON Pedidoservicio.Idservicio=Servicio.Idservicio WHERE PedidoServicio.Idservicio='" + clavePedidoID + "'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "PedidoServicio, Servicio");
        }
        public void actualizarPrecioServicio(string precioServicio, string idPedidoServicio)
        {
            string consulta = "UPDATE PedidoServicio SET Precio='" + precioServicio + "'" + " WHERE IdPedido = '" + idPedidoServicio + "'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "PedidoServicio");
        }
        public void actualizarHerramienta()
        {
            string consulta = "SELECT * FROM Herramienta";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "Herramienta");
        }
        public void muestraProducto()
        {
            string consulta = "SELECT * FROM Producto";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "Producto");
        }
        public void muestraServicio()
        {
            string consulta = "SELECT * FROM Servicio";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "Servicio");
        }
        public void muestraMaterialProducto(string cantidad, string clave)
        {
            string consulta = "SELECT IdMaterialUnit, NombreMaterial, Cantidad*"+cantidad+", Medidas, Idproducto FROM MaterialUnit WHERE Idproducto='" + clave+"'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "MaterialUnit");
        }
        public void muestraGastoIndirecto()
        {
            string consulta = "SELECT * FROM GastoIndirecto";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "GastoIndirecto");
        }
        public void muestraVentaCreditProdTodo()
        {
            string consulta = "SELECT * FROM VentadeCreditoP INNER JOIN Producto ON VentadeCreditoP.Idproducto=Producto.Idproducto";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "VentadeCreditoP, Producto");
        }
        public void muestraVentaCreditServTodo()
        {
            string consulta = "SELECT * FROM VentadeCreditoS INNER JOIN Servicio ON VentadeCreditoS.Idservicio=Servicio.Idservicio";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "VentadeCreditoS, Servicio");
        }
        public void buscarVentaCreditProdID(string clavePedidoID)
        {
            string consulta = "SELECT * FROM VentadeCreditoP INNER JOIN Producto ON VentadeCreditoP.idproducto=Producto.IdProducto WHERE VentadeCreditoP.IdVentadeCreditoP='" + clavePedidoID + "'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "VentadeCreditoP, Producto");
        }
        public void buscarVentaCreditServID(string clavePedidoID)
        {
            string consulta = "SELECT * FROM VentadeCreditoS INNER JOIN Servicio ON VentadeCreditoS.Idservicio=Servicio.Idservicio WHERE VentadeCreditoS.IdVentadeCreditoS='" + clavePedidoID + "'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, bd.GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "VentadeCreditoS, Servicio");
        }
    }
}
