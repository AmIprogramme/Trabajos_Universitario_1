/*
Universidad Estatal a Distancia
Cátedra de informática
Segundo cuatrimestre
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion_restaurante
{

    class Objeto_categoria
    {
        private int _id_categoria;
        private string descripcion;
        private bool estado;

        public int _Id_categoria { get => _id_categoria; set => _id_categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
    }


    class restaurante
    {
       private  int id_de_restaurante; // Tener en cuenta que es un único, por lo cual se debe de ver si está repetido.
       private  string nombre_de_restaurante;
       private  string direccion;
       private  bool estado;
       private  string telefono;

        public int Id_de_restaurante { get => id_de_restaurante; set => id_de_restaurante = value; }
        public string Nombre_de_restaurante { get => nombre_de_restaurante; set => nombre_de_restaurante = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }

    class categoria_de_plato
    {
        private int id_categoria; // Tener en cuenta que es un único, por lo cual se debe de ver si está repetido. 
        private string descripcion;
        private bool estado;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
    }

     class platos
    {
        private int id_plato; // Tener en cuenta que es un único, por lo cual se debe de ver si está repetido.  
        private string nombre;
        private int precio;
        private Objeto_categoria id_categoria;

        public int Id_plato { get => id_plato; set => id_plato = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public Objeto_categoria Id_categoria { get => id_categoria; set => id_categoria = value; }

        // !!!!!!!!!!!!!!!!!!!!!!Id Categoría (Objeto Categoría) debe almacenar un objeto de tipo Categoría, por lo tanto, debe 
        //validar que exista en el arreglo de Categorías.  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }

    class clientes
    {
        private String identificacion; // Se debe de validar que no haya dos o más clientes iguales.
        private String nombre;
        private String primer_apellido;
        private String segundo_apellido;
        private DateTime fecha_de_nacimiento;
        private Char sexo;

        public String Identificación { get => identificacion; set => identificacion = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public String Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public DateTime Fecha_de_nacimiento { get => fecha_de_nacimiento; set => fecha_de_nacimiento = value; }
        public Char Sexo { get => sexo; set => sexo = value; }
    }

   class PlatoRestaurante: platos
    {
        private int id_asignacion;
        private DateTime fecha;
        private Objeto_sucursal restaurante;
        private platos[] platos= new platos[10];
        private platos recolector_platos = new platos();
         
        public int Id_asignacion { get => id_asignacion; set => id_asignacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public platos[] Platos { get => platos; set => platos = value; }
        public Objeto_sucursal Restaurante { get => restaurante; set => restaurante = value; }
        public platos Recolector_platos { get => recolector_platos; set => recolector_platos = value; }
    }

    class Objeto_sucursal 
    {
        private String nombre_del_restaurante;
        private int id_del_restaurante;
        private String direccion;
        private String telefono;

        public string Nombre_del_restaurante { get => nombre_del_restaurante; set => nombre_del_restaurante = value; }
        public int Id_del_restaurante { get => id_del_restaurante; set => id_del_restaurante = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
