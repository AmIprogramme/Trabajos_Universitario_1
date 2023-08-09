/*
Universidad Estatal a Distancia
Cátedra de informática
Segundo cuatrimestre
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.

 */

using aplicacion_restaurante;
using System;
using System.Runtime.InteropServices;

namespace aplicacion_restaurante
{
    internal class Program
    { 

        public class Global
        {
            private static restaurante[] restaurante = new restaurante[20];
            private static categoria_de_plato[] categoria_de_plato = new categoria_de_plato[20];
            private static platos[] platos = new platos[20];
            private static clientes[] clientes = new clientes[20];
            private static PlatoRestaurante[] registrar_plato_por_restaurante = new PlatoRestaurante[20];

            private static int contador_de_registros_restaurante = 0;
            private static int contador_de_registros_categoria = 0;
            private static int contador_de_registrar_platos = 0;
            private static int contador_de_clientes_registrados = 0;
            private static int contador_de_PLATO_RESTAURANTE = 0;
            private static int contador_de_PLATO_RESTAURANTE_numero_2 = 0;

            public static restaurante[] Restaurante { get => restaurante; set => restaurante = value; }
            public static categoria_de_plato[] Categoria_de_plato { get => categoria_de_plato; set => categoria_de_plato = value; }
            internal static platos[] _Platos_restaurante { get => platos; set => platos = value; }
            internal static clientes[] Clientes { get => clientes; set => clientes = value; }
            internal static PlatoRestaurante[] Registrar_plato_por_restaurante { get => registrar_plato_por_restaurante; set => registrar_plato_por_restaurante = value; }

            public static int Contador_de_registros_restaurante { get => contador_de_registros_restaurante; set => contador_de_registros_restaurante = value; }
            public static int Contador_de_registros_categoria { get => contador_de_registros_categoria; set => contador_de_registros_categoria = value; }
            public static int Contador_de_registrar_platos { get => contador_de_registrar_platos; set => contador_de_registrar_platos = value; }
            public static int Contador_de_clientes_registrados { get => contador_de_clientes_registrados; set => contador_de_clientes_registrados = value; }
            public static int Contador_de_PLATO_RESTAURANTE { get => contador_de_PLATO_RESTAURANTE; set => contador_de_PLATO_RESTAURANTE = value; }
            public static int Contador_de_PLATO_RESTAURANTE_numero_2 { get => contador_de_PLATO_RESTAURANTE_numero_2; set => contador_de_PLATO_RESTAURANTE_numero_2 = value; }
        }


        static void Main(string[] args)
        {

            bool fin_del_programa;
            try
            {
                Relleno_de_arreglos();
                do
                {
                    
                    String numero_de_seleccion = "";


                    // !!!!!!!!!!!!! Fin de lista de variables locales en el main!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    System.Console.WriteLine("Elige una de las siguientes opciones:\n");

                    System.Console.WriteLine("1- Registrar Restaurante \n2- Registrar Categoría Plato\n3- Registrar Plato\n");

                    System.Console.WriteLine("4- Registrar Clientes\n5- Registrar Platos por Restaurante\n6- Consultar Restaurante\n7- Consultar Categoría Plato\n");

                    System.Console.WriteLine("8- Consultar Plato\n9- Consultar Clientes\n10- Consultar Platos por Restaurante\n11- Salir del menú de opciones.");

                    numero_de_seleccion = Console.ReadLine(); // Se lee el dígito que el usuario vaya a elegir para su respectivo uso.


                    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Inicio del switch !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    switch (numero_de_seleccion)
                    {
                        case "1": // Registrar Restaurante.

                            Registrar_restaurante(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "2": // 2- Registrar Categoría.

                            Registrar_categoria(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "3": // 3- Registrar Plato.

                            Registrar_plato(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "4": // 4- Registrar Clientes.

                            Registrar_clientes(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "5": // 5- Registrar Platos por Restaurante.

                            Registrar_platos_por_restaurante(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "6": // 6- Consultar Restaurante.

                            Consultar_restaurante(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "7": // 7- Consultar Categoría Plato.

                            Consultar_categoria_plato(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "8": // 8- Consultar Plato.

                            Consultar_plato(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "9": // 9- Consultar Clientes.

                            Consultar_clientes(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;
                            break;

                        case "10": // 10- Consultar Platos por Restaurante.

                            Console.Clear();

                            Consultar_platos_por_restaurante(); // INICIO DE LA FUNCIÓN.
                            fin_del_programa = false;

                            break;

                        case "11": // 11- Salir del menú de opciones.

                            fin_del_programa = false;

                            Console.Clear();    
                            Console.WriteLine("¿Está seguro que desea salir?: Presione S para salir o cualquier tecla para continuar.");
                            String seguro_de_salir = Console.ReadLine();

                            if (seguro_de_salir == "s" || seguro_de_salir == "S")
                            {
                                fin_del_programa = true;
                                Console.Clear();
                            }
                            break;

                        // !!!!!!!!!!!!!!!!!! En caso de que el usuario no allá digitado algún número, el sistema lo sabrá. !!!!!
                        default:

                            Console.Clear();
                            Console.WriteLine("El dígito que usted marcó no corresponde.\nVuelva a intentarlo.");
                            Console.ReadKey();
                            Console.Clear();

                            fin_del_programa = false;
                            break;


                    }

                    Console.Clear();   
                } while (fin_del_programa == false);



            }
            catch (Exception e)
            {
                Console.WriteLine("Excepción de tipo: " + e);

            }

        } // Fin de la clase principal
          //---------------------------------------------------------------------------------------------------------------

        public static void Registrar_restaurante()
        {
            Console.Clear();

            String id_de_restaurante; // Tener en cuenta que es un único, por lo cual se debe de ver si está repetido.
            int id_de_restaurante_en_int;
            

            string nombre_de_restaurante = "";
            string direccion = "";
            bool estado = true;
            string telefono = "";
            


            String volver_a_registrar;

            bool fin_de_registro = true;

            restaurante recolector_de_objetos= new restaurante();

            
            do
            {
                try
                {


                    /*Primera sección: Verificar si todavía hay campos*/

                    if (Global.Contador_de_registros_restaurante >= 19)
                    {
                        throw new Exception("Ya se excedió de registros, ya no puede realizar más registros.");

                    }
                    /*Segunda sección: Filtro. ¿Existen elementos similares anteriormente?
                     ¿ Esta bién escrito el registro? */

                    Console.Clear();
                    Console.WriteLine("Escriba el identificador del nuevo restaurante a registrar: ");
                    id_de_restaurante = Console.ReadLine();

                    if (Verificador_de_id_restaurante(id_de_restaurante))
                    {
                        throw new Exception("El registro que usted realizó, ya existe o esta mal escrito. \n");
                        
                    }

                    id_de_restaurante_en_int = Int32.Parse(id_de_restaurante);

                    recolector_de_objetos.Id_de_restaurante = id_de_restaurante_en_int;

                    Console.Clear();
                    Console.WriteLine("Registra el nombre del restaurante: ");
                    nombre_de_restaurante = Console.ReadLine();

                    recolector_de_objetos.Nombre_de_restaurante = nombre_de_restaurante;
                    Console.Clear();

                    Console.WriteLine("Registre la dirección del restaurante: ");
                    direccion = Console.ReadLine();
                    recolector_de_objetos.Direccion = direccion;
                    Console.Clear();

                    Console.WriteLine("Digite el número de teléfono de este: ");
                    telefono = Console.ReadLine();
                    recolector_de_objetos.Telefono = telefono;  
                    Console.Clear();


                    bool registro_de_estado;
                    String atrapa_opcion_de_estado;

                    do
                    {
                        Console.WriteLine("¿En qué estado se encuentra el restaurante?: \n S para activo, N para inactivo.");
                        atrapa_opcion_de_estado= Console.ReadLine();

                        switch (atrapa_opcion_de_estado) 
                        {
                            case "S":

                                estado = true;
                                registro_de_estado = false;

                                break;
                            case "s":

                                estado = true;
                                registro_de_estado = false;

                                break;
                            case "N":

                                estado = false;
                                registro_de_estado = false;

                                break;
                            case "n":

                                estado = false;
                                registro_de_estado = false;

                                break;
                            default:

                                Console.Clear();
                                Console.WriteLine("Por favor digite un valor de N o S");
                                Console.ReadLine();
                                registro_de_estado = true;
                                Console.Clear();

                                break;
                        
                        }

                    } while (registro_de_estado);

                    recolector_de_objetos.Estado = estado;

                    //---------------------------------------------------------
                    // Todos se termina bien por lo cual se procede a preguntar al usuario si quiere volver a registrar.
                    Global.Restaurante[Global.Contador_de_registros_restaurante] = recolector_de_objetos;
                    Contador_de_Registros_restaurantes_acumulador();

                    //Console.WriteLine("Registros del contador después del acumulador: "+ Global.Contador_de_registros_restaurante);
                    //Console.ReadKey();
                    

                    Console.WriteLine("Registro exitoso.");
                    Console.ReadKey();
                    Console.Clear();
                   
                } // Fin del try
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                    Console.Clear ();


                } // Fin del catch


                Console.WriteLine("¿Desea volver a hacer otro?: S para volver a registrar o presione cualquier tecla para salir");
                volver_a_registrar = Console.ReadLine();

                if (volver_a_registrar == "s" || volver_a_registrar == "S")
                {
                    fin_de_registro = true;
                }
                else { fin_de_registro = false; }

                Console.Clear();
                
            } while (fin_de_registro);

        } // Fin de la función Restaurante.
          //-----------------------------------------------------------------------------------------------------

        public static void Registrar_categoria()
        {
            Console.Clear();
            String id_categoria;
            int id_en_int;
            string descripcion;
            bool estado = false;

            bool terminar_registro = true;
            bool parte_registro = false;
            String opcion_de_salida;

            categoria_de_plato recolector_de_objetos = new categoria_de_plato();


            
            do
            {
                try
                {
                    //Primera parte: Filtro de campos.
                    if (Global.Contador_de_registros_categoria >= 20) 
                    {
                        throw new Exception("Se sobrepasó el límite de registros");
                    
                    }
                    

                    // Segunda parte: Filtro de existencias.

                    Console.WriteLine("Digite el id de la categoría de plato que va a registrar.");
                    id_categoria = Console.ReadLine();


                    if (Evaluador_de_categoria_plato(id_categoria)) 
                    {
                        throw new Exception("Lo sentimos, pero su registro ya existe o está mal escrito");

                    }

                    //Se procede a registrar los datos correspondientes.

                    id_en_int = Int32.Parse(id_categoria);

                    recolector_de_objetos.Id_categoria = id_en_int;

                   
                    Console.WriteLine("Registre la descripción de esta:");
                    descripcion = Console.ReadLine();

                    recolector_de_objetos.Descripcion = descripcion;


                    String activo_o_no;

                    do {

                        Console.WriteLine("¿Se encuentra activo?: S para activo, N para inactivo."); 
                        activo_o_no = Console.ReadLine();



                        switch (activo_o_no)
                        {
                            case "S":

                                parte_registro = false;
                                estado = true;

                                break;
                            case "s":

                                parte_registro = false;
                                estado = true;

                                break;
                            case "N":

                                estado = false;
                                parte_registro = false;

                                break;
                            case "n":

                                estado = false;
                                parte_registro = false;

                                break;
                            default:

                                Console.Clear();
                                Console.WriteLine("Por favor digite un valor de N o S");
                                Console.ReadLine();
                                parte_registro = true;
                                Console.Clear();
                                break;

                        }


                    } while(parte_registro);

                    recolector_de_objetos.Estado = estado;

                    

                    Console.WriteLine("Sus registros han sido realizados con éxito.");
                    Console.ReadKey();

                    Global.Categoria_de_plato[Global.Contador_de_registros_categoria] = recolector_de_objetos;
                    Contador_de_categoria_de_platos_acumulador();
                }
                catch (Exception e) 
                { 
                    Console.WriteLine(e);
                
                }


                Console.WriteLine("¿Desea volver a dar un nuevo registro?: S para volver a intentar, o presione cualquier tecla para finalizar.");    
                opcion_de_salida = Console.ReadLine();

                if (opcion_de_salida == "S" || opcion_de_salida == "s")
                {
                    terminar_registro = true;
                }
                else { terminar_registro = false; }


            } while (terminar_registro);


        }

        public static void Registrar_plato()
        {
            Console.Clear ();
            String id_de_plato;
            String nombre;
            String precio;

            String opcion_de_salida;

            int contador_for;

            bool terminar_registro;

            platos recolector_de_objetos = new platos();
            Objeto_categoria recolector_de_categoria = new Objeto_categoria();  

            do
            {
                try 
                {
                    //Verificamos si aún hay espacio.
                    if (Global.Contador_de_registrar_platos >= 20)
                    {
                        throw new Exception("Ya se excedió el campo, el límite de espacios disponibles.");
                    }
                    // Verificamos si por lo menos éxite un elemento de categoría.

                    if (Global.Categoria_de_plato[0].Id_categoria == 0) 
                    {
                        throw new Exception("No existe ninguna categoría registrada por el momento");
                    }



                    // Verificamos que el plato que se va a registrar no este en la lista.
                    Console.WriteLine("Digite el id del plato que desea registrar.");
                    id_de_plato = Console.ReadLine();


                    if (Existencia_de_platos(id_de_plato))
                    {
                        throw new Exception("El registro que usted realizó ya existe o esta mal escrito.");
                    }

                    recolector_de_objetos.Id_plato = Int32.Parse(id_de_plato);

                    Console.WriteLine("Escriba el nombre del plato que desea agregarle");
                    nombre = Console.ReadLine();
                    recolector_de_objetos.Nombre = nombre;

                    Console.WriteLine("Digite el precio que tiene esta.");
                    precio = Console.ReadLine();
                    recolector_de_objetos.Precio = Int32.Parse(precio);


                    // Recordar ponerle una categoría a la lista.

                   
                    bool seleccionador_de_categoria_bool = false;
                    String atrapa_seleccion_de_categoria = "";

                    do {
                        int contador_seleccionador = 1;
                        Console.Clear();
                        Console.WriteLine("Escoja en pantalla la siguiente categoría que se muestra:\n-------------------------------------------------------");

                        // Inicio de busqueda en pantalla
                        for (contador_for = 0; contador_for <= Global.Categoria_de_plato.Length - 1; contador_for++) 
                        {
                            if (Global.Categoria_de_plato[contador_for].Id_categoria == 0) 
                            {
                                break;
                            }

                            Console.WriteLine("Categoría número: " + contador_seleccionador + "\n");
                            Console.WriteLine("Identificación: " + Global.Categoria_de_plato[contador_for].Id_categoria + "\n");
                            Console.WriteLine("Descripción: " + Global.Categoria_de_plato[contador_for].Descripcion + "\n");

                            if (Global.Categoria_de_plato[contador_for].Estado == true) 
                            {
                                Console.WriteLine("Estado: Activo \n----------------------------------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Estado: Inactivo \n----------------------------------------------------------------");
                            }

                            contador_seleccionador++;

                        } // Fin del for para mostrar en pantalla.
                        

                        // Se recupera la cifra que se va a buscar.
                       atrapa_seleccion_de_categoria = Console.ReadLine();

                        int es_un_numero = 0;

                        if (!(int.TryParse(atrapa_seleccion_de_categoria, out es_un_numero)))
                        {
                            Console.Clear();
                            Console.WriteLine("Por favor introduzca una cifra valida para poder registrarla, presione cualquier tecla para continuar.");
                            Console.ReadLine();
                            seleccionador_de_categoria_bool = true;
                        }
                        else 
                        {
                            es_un_numero = Int32.Parse(atrapa_seleccion_de_categoria);
                            if (es_un_numero > contador_seleccionador || es_un_numero < -1 || es_un_numero == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Por favor introduzca una cifra valida para poder registrarla, presione cualquier tecla para continuar.");
                                    Console.ReadLine();
                                    seleccionador_de_categoria_bool = true;
                            }
                            else
                            {
                                    recolector_de_categoria._Id_categoria = Retorno_id_categoria(es_un_numero - 1);
                                    recolector_de_categoria.Descripcion = Retorno_descripcion(es_un_numero - 1);
                                    recolector_de_categoria.Estado = Retorno_de_estado(es_un_numero - 1);


                                seleccionador_de_categoria_bool = false;
                            }   
                        }
                        Console.Clear() ;

                    } while (seleccionador_de_categoria_bool);



                    Console.WriteLine("Sus registros han sido realizados con éxito.");
                    Console.ReadKey();

                    Global._Platos_restaurante[Global.Contador_de_registrar_platos] = recolector_de_objetos;
                    Global._Platos_restaurante[Global.Contador_de_registrar_platos].Id_categoria = recolector_de_categoria;
                    Contador_de_registros_de_platos_acumulador();

                }
                catch(Exception e) 
                { 
                    Console.WriteLine(e); 
                    Console.ReadKey();
                
                }


                Console.WriteLine("Desea volver a dar un nuevo registro: S para volver a intentar, o presione cualquier tecla para finalizar.");
                opcion_de_salida = Console.ReadLine();

                if (opcion_de_salida == "S" || opcion_de_salida == "s")
                {
                    terminar_registro = true;
                }
                else { terminar_registro = false; }

            } while (terminar_registro);

        }

        public static void Registrar_clientes()
        {
            Console.Clear();
            String identificacion;
            String nombre;
            String primer_apellido;
            String segundo_apellido;
            DateTime fecha_de_nacimiento;
            Char sexo = 'x';

            clientes recolector_de_objetos = new clientes();

            bool terminar_registro;
            bool registro_de_sexo;

            String opcion_de_salida;

            do
            {


                try
                {
                    // Verificar que haya campo para registrar otro usuario.
                    if (Global.Contador_de_clientes_registrados >= 20)
                    {
                        throw new Exception("El limite de registro ya llego a su limite.");
                    }

                    // Verificamos que la identificación no este repetida.
                    Console.WriteLine("Digite el número de registro de la persona a registrar.");
                    identificacion = Console.ReadLine();

                    if (Existencia_de_clientes(identificacion))
                    {
                        throw new Exception("La identificación que usted marcó ya existe o esta mal escrito.");
                    }

                    recolector_de_objetos.Identificación = identificacion;

                    Console.WriteLine("Escriba el nombre de la persona que desea registrar: ");
                    nombre = Console.ReadLine();
                    recolector_de_objetos.Nombre = nombre;


                    Console.WriteLine("Escriba el primer apellido de la persona a registrar: ");
                    primer_apellido = Console.ReadLine();
                    recolector_de_objetos.Primer_apellido = primer_apellido;

                    Console.WriteLine("Escriba el segundo apellido de la persona a registrar: ");
                    segundo_apellido = Console.ReadLine();
                    recolector_de_objetos.Segundo_apellido= segundo_apellido;

                    Console.WriteLine("Digite la fecha de nacimiento de la persona: ");
                    fecha_de_nacimiento = DateTime.Parse( Console.ReadLine());
                    recolector_de_objetos.Fecha_de_nacimiento = fecha_de_nacimiento;


                    String seleccion_de_sexo;
                    do 
                    {
                        Console.Clear();    
                        Console.WriteLine("Escoga el sexo del individuo a registrar: M = Hombre, F = Mujer");
                        seleccion_de_sexo = Console.ReadLine();

                        switch (seleccion_de_sexo)
                        {
                            case "M":

                                sexo = 'M';
                                registro_de_sexo = false;

                                break;
                            case "m":

                                sexo = 'M';
                                registro_de_sexo = false;

                                break;
                            case "F":

                                sexo = 'F';
                                registro_de_sexo = false;

                                break;
                            case "f":

                                sexo = 'F';
                                registro_de_sexo = false;

                                break;
                            default:

                                Console.Clear();
                                Console.WriteLine("Por favor digite un valor de M o F");
                                Console.ReadLine();
                                registro_de_sexo = true;
                                Console.Clear();
                                break;

                        }
                        
                    } while (registro_de_sexo);

                    recolector_de_objetos.Sexo = sexo;

                    Console.Clear();
                    Console.WriteLine("Su registro se dio sin inconvenientes.");
                    Global.Clientes[Global.Contador_de_clientes_registrados] = recolector_de_objetos;
                    Contador_de_registros_de_clientes();

                    Console.ReadKey();
                    Console.Clear();

                }
                catch(Exception e)
                { 
                    Console.WriteLine (e);  
                
                }
                Console.WriteLine("¿Desea volver a dar un nuevo registro?: S para volver a intentar, o presione cualquier tecla para finalizar.");
                opcion_de_salida = Console.ReadLine();

                if (opcion_de_salida == "S" || opcion_de_salida == "s")
                {
                    terminar_registro = true;
                }
                else { terminar_registro = false; }

            } while (terminar_registro);

        }

        public static void Registrar_platos_por_restaurante()
        {
            Console.Clear();
            bool terminar_registro = false;
            String desea_terminar_o_volver;
            int contador_for;
            bool terminar_segundo_do_while = true;
            int selector_de_restaurante = 1;
            String selector_de_restaurante_String;
            String numero_de_ASIGNACION;
            int contador_de_ACTIVOS = 0;
           

            Objeto_sucursal recoletor_de_sucursal = new Objeto_sucursal();
            platos recolector_de_platos = new platos();
            PlatoRestaurante recolector_de_registros = new PlatoRestaurante();


            do
            {
                try
                {
                    // Verificamos que por lo menos tengamos un restaurante registrado.
                    if (Global.Restaurante[0].Id_de_restaurante == 0)
                    {
                        throw new Exception("No se encuentran registro de ningún restaurante por el momento.");

                    }

                    // Verificamos que por lo menos tengamos un platillo a disposición.

                    if (Global._Platos_restaurante[0].Id_plato == 0)
                    {
                        throw new Exception("No se encuentran registro de ningún plato por el momento.");
                    }

                    // Verificamos que hayan restaurantes activos
                    for (contador_for = 0; contador_for <= Global.Restaurante.Length - 1; contador_for++) 
                    {
                        if(Global.Restaurante[contador_for].Id_de_restaurante == 0)
                        {
                            break;
                        }

                        if (Global.Restaurante[contador_for].Estado == false) 
                        {
                            contador_de_ACTIVOS += 1;
                        }

                        if (contador_de_ACTIVOS == 0 && contador_for >= Global.Restaurante.Length - 2) 
                        {
                            throw new Exception("Por el momento no se encuentran restaurantes activos.");
                        }
                        
                    
                    } // Si llega a terminar hasta aquí quiere decir que la condición se cumple con éxito


                    Console.WriteLine("Digite el número de asignación para el siguiente registro");
                    numero_de_ASIGNACION = Console.ReadLine();
                    Console.Clear();

                    if (!(int.TryParse(numero_de_ASIGNACION, out selector_de_restaurante)))
                    {
                        throw new Exception("La cadena de números que marcó no corresponde");
                    }

                    selector_de_restaurante = Int32.Parse(numero_de_ASIGNACION);

                    recolector_de_registros.Id_asignacion = selector_de_restaurante;
                    recolector_de_registros.Fecha = DateTime.Now; // Se registra la fecha de hoy como parte del proceso.

                    Console.Clear();

                   do // Do secundario para volver a registrar un plato al restaurante en caso de error.
                    {
                        selector_de_restaurante = 1;
                           
                        //--------------------------------------------------------------------------------------------------------------------------------
                        // Aquí se proyectan todos los restaurantes por el momento.
                        Console.WriteLine("Se muestra en pantalla los siguientes restaurantes registrados\n--------------------------------------------------------------\n");
                        for (contador_for = 0; contador_for <= Global.Restaurante.Length - 1; contador_for++)
                        {
                            // Si el recorrido llega a una cifra que solo sea cero, este saltara y saldra del registro
                            if (Global.Restaurante[contador_for].Id_de_restaurante == 0)
                            {
                                break;
                            }

                            // En este caso como el trabajo lo solicita, solo dará prioridad a los restaurantes que este activos.
                            if (Global.Restaurante[contador_for].Estado)
                            {
                                Console.WriteLine("Restaurante número: " + selector_de_restaurante + "\n");
                                Console.WriteLine("Identificación: " + Global.Restaurante[contador_for].Id_de_restaurante + "\n");
                                Console.WriteLine("Nombre : " + Global.Restaurante[contador_for].Nombre_de_restaurante + "\n");
                                Console.WriteLine("Dirección: " + Global.Restaurante[contador_for].Direccion + "\n");
                                Console.WriteLine("Teléfono: " + Global.Restaurante[contador_for].Telefono + "\n---------------------------------------------------------------------------------\n");
                            }
                        }
                            Console.WriteLine("Digite el número de identificación del restaurante que va a escoger.");
                            selector_de_restaurante_String= Console.ReadLine();

                           // Si es un número, entra en la condicional.
                           if (int.TryParse(selector_de_restaurante_String, out selector_de_restaurante)) 
                            {
                                    selector_de_restaurante = Int32.Parse(selector_de_restaurante_String);

                                    // En caso de que exista un registro previo, dará paso al registro 
                                    if (Verificador_de_id_restaurante(selector_de_restaurante_String))
                                    {
                                        // Aquí es donde la selección se va a dar 
                                        recoletor_de_sucursal.Id_del_restaurante = REtorno_de_ID_ADMITIDO(selector_de_restaurante);
                                        recoletor_de_sucursal.Nombre_del_restaurante = Retorno_NOMBRE_DE_RESTAURATE(selector_de_restaurante, 0);
                                        recoletor_de_sucursal.Direccion = Retorno_NOMBRE_DE_RESTAURATE(selector_de_restaurante, 1);
                                        recoletor_de_sucursal.Telefono= Retorno_NOMBRE_DE_RESTAURATE(selector_de_restaurante, 2);

                                        terminar_segundo_do_while = false;
                                    }
                                    else
                                    {
                                        
                                        Console.Clear();
                                        Console.WriteLine("Por favor, digite un digito que se muestre en pantalla.");
                                        Console.ReadLine();

                                    }

                           }
                           else // De lo contrario salta este mensaje de error.
                           {
                                    Console.Clear();
                                    Console.WriteLine("El digito que marcó esta mal, vuelva a intentarlo.");
                                    Console.ReadLine(); 
                           }

                       
                        
                            //------------------------------------------------------------------------------------------------------------------------------------
                        
                            Console.Clear();
                   }while (terminar_segundo_do_while);

                        Console.Clear();

                    // Sección donde se va a almacenar el tipo de plato
                    do
                    {
                            selector_de_restaurante = 1;
                            terminar_segundo_do_while = true;

                            Console.WriteLine("Se muestra en pantalla los siguientes platos registrados\n--------------------------------------------------------------\n");
                            for (contador_for = 0; contador_for <= Global._Platos_restaurante.Length - 1; contador_for++)
                            {
                                // Si el recorrido llega a una cifra que solo sea cero, este saltara y saldra del registro
                                if (Global._Platos_restaurante[contador_for].Id_plato == 0)
                                {
                                    break;
                                }

                                Console.WriteLine("Plato número: " + selector_de_restaurante + "\n");
                                Console.WriteLine("Identificación: " + Global._Platos_restaurante[contador_for].Id_plato + "\n");
                                Console.WriteLine("Nombre : " + Global._Platos_restaurante[contador_for].Nombre + "\n");
                                Console.WriteLine("Precio: " + Global._Platos_restaurante[contador_for].Precio + "\n---------------------------------------------------------------------------------\n");
                            }

                            Console.WriteLine("Digite el identificador del plato que desea registrar:");
                            selector_de_restaurante_String = Console.ReadLine();
                            try
                            {

                                if (int.TryParse(selector_de_restaurante_String, out selector_de_restaurante))
                                {
                                    if (Existencia_de_platos(selector_de_restaurante_String))
                                    {
                                        selector_de_restaurante = Int32.Parse(selector_de_restaurante_String);

                                        recolector_de_platos.Id_plato = selector_de_restaurante;
                                        recolector_de_platos.Nombre = Retorno_DE_TODOS_LOS_PLATOS(selector_de_restaurante, 0);

                                        contador_de_ACTIVOS = Int32.Parse(Retorno_DE_TODOS_LOS_PLATOS(selector_de_restaurante, 1));
                                        recolector_de_platos.Precio = contador_de_ACTIVOS;

                                    }
                                    else 
                                    {

                                        throw new Exception("El id que usted marcó no esta registrado, vuelva a intentarlo");
                                    }

                                }
                                else
                                {
                                    throw new Exception("El id que usted marcó esta incorrecto, vuelva a intentarlo");
                                }

                                Global.Registrar_plato_por_restaurante[Global.Contador_de_PLATO_RESTAURANTE] = recolector_de_registros;
                                Global.Registrar_plato_por_restaurante[Global.Contador_de_PLATO_RESTAURANTE].Platos[Global.Contador_de_PLATO_RESTAURANTE_numero_2] = recolector_de_platos;
                                Global.Registrar_plato_por_restaurante[Global.Contador_de_PLATO_RESTAURANTE].Restaurante = recoletor_de_sucursal;

                                Console.Clear();
                                Console.WriteLine("El registro se dió sin inconvenientes. Presione cualquier tecla para continuar.");
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("¿Desea registrar otro platillo a este restaurante?: S para volver a registrar o presione cualquier tecla para continuar.");
                                selector_de_restaurante_String = Console.ReadLine();
                                if (!(selector_de_restaurante_String == "S" || selector_de_restaurante_String == "s"))
                                {
                                    terminar_segundo_do_while = false;
                                   
                                }
                                else 
                                {
                                    Acumulador_de_posiciones_de_PLATOS_POR_RESTAURANTE(2);
                                }


                            }catch (Exception ex) 
                            {
                                Console.Clear();
                                Console.WriteLine(ex);
                                Console.ReadKey();

                            }


                   } while (terminar_segundo_do_while);

                    


                    Acumulador_de_posiciones_de_PLATOS_POR_RESTAURANTE(3);

                }
                catch(Exception e) 
                {
                    Console.Clear();
                    Console.WriteLine(e);
                    Console.ReadKey();
                }

               
                Console.Clear();

                Console.WriteLine("¿Desea volver a hacer registros?: S para volver o presione cualquier tecla para volver al menú\n");
                desea_terminar_o_volver = Console.ReadLine();

                if (desea_terminar_o_volver == "s" || desea_terminar_o_volver == "S")
                {
                    terminar_registro = true;
                    
                }
                else
                {
                    terminar_registro = false;
                    
                }

                Acumulador_de_posiciones_de_PLATOS_POR_RESTAURANTE(1);

            } while (terminar_registro);


        }

        public static void Consultar_restaurante()
        {
            int contador_for = 0;

            Console.Clear ();
            try
            {

                if (Global.Restaurante[0].Id_de_restaurante == 0)
                {
                    Console.WriteLine("Lo sentimos, pero no se encuentran registros previos.");

                }
                else
                {

                    for (contador_for = 0; contador_for <= Global.Restaurante.Length - 1; contador_for++)
                    {
                        if (Global.Restaurante[contador_for].Id_de_restaurante == 0)
                        {
                            break;
                        }

                        Console.WriteLine("Nombre del restaurante:" + Global.Restaurante[contador_for].Nombre_de_restaurante + "\n");
                        Console.WriteLine("ID: " + Global.Restaurante[contador_for].Id_de_restaurante);
                        if (Global.Restaurante[contador_for].Estado == true)
                        {
                            Console.WriteLine("Estado: Activo");
                        }
                        else
                        {
                            Console.WriteLine("Estado: Inactivo");
                        }

                        Console.WriteLine("Teléfono: " + Global.Restaurante[contador_for].Telefono);
                        Console.WriteLine("Dirrección: " + Global.Restaurante[contador_for].Direccion + "\n");
                        Console.WriteLine("------------------------------------------------------------------------\n");



                    }
                }

            }
            catch(Exception e) 
            {
                Console.WriteLine(e);

            
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void Consultar_categoria_plato()
        {
            int contador_for = 0;
            Console.Clear() ;

            try 
            {

                if (Global.Categoria_de_plato[0].Id_categoria == 0)
                {
                    Console.WriteLine("No se encuentran registros previos");  
                }
                else
                {
                    Console.WriteLine("Lista de todas las categorías de platos disponibles: \n------------------------------------------");
                    for (contador_for = 0; contador_for <= Global.Categoria_de_plato.Length - 1; contador_for++)
                    {
                        if (Global.Categoria_de_plato[contador_for].Id_categoria == 0)
                        {
                            break;                        
                        }
                        Console.WriteLine("Id de categoría: " + Global.Categoria_de_plato[contador_for].Id_categoria + "\n");
                        Console.WriteLine("Descripción: " + Global.Categoria_de_plato[contador_for].Descripcion);
                        if (Global.Categoria_de_plato[contador_for].Estado == true)
                        {
                            Console.WriteLine("Estado: Activo");
                        }
                        else
                        {
                            Console.WriteLine("Estado: Inactivo \n\n---------------------------------------------------");
                        }
                    }
                }

            }
             catch(Exception e) 
            { 
                Console.WriteLine (e);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void Consultar_plato()
        {
            Console.Clear();
            int contador_for = 0;

            try
            {
                if (Global._Platos_restaurante[0].Id_plato == 0)
                {
                    Console.WriteLine("No se encuentrar registros previos.");
                }
                else
                {
                    Console.WriteLine("Lista de todos los platos registrados: \n---------------------------------------------");
                    for (contador_for = 0; contador_for <= Global._Platos_restaurante.Length - 1; contador_for++)
                    {
                        if(Global._Platos_restaurante[contador_for].Id_plato == 0) 
                        {
                            break;
                        }

                        Console.WriteLine("Id del plato: " + Global._Platos_restaurante[contador_for].Id_plato + "\n");
                        Console.WriteLine("Nombre: " + Global._Platos_restaurante[contador_for].Nombre);
                        Console.WriteLine("Precio: " + Global._Platos_restaurante[contador_for].Precio); 
                        Console.WriteLine("\nCategoría: " + "\n Id categoría: " + Global._Platos_restaurante[contador_for].Id_categoria._Id_categoria);
                        Console.WriteLine("\nDescripción: " + Global._Platos_restaurante[contador_for].Id_categoria.Descripcion);

                        if (Global._Platos_restaurante[contador_for].Id_categoria.Estado) 
                        {
                            Console.WriteLine("\n Estado: Activo\n--------------------------------------------------------------"); 
                        
                        }
                        else
                        {
                            Console.WriteLine("\n Estado: Inactivo\n--------------------------------------------------------------");
                        }
                    }
                }            
            }catch(Exception e) 
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();

        }

        public static void Consultar_clientes()
        {
            int contador_for = 0;
            Console.Clear();


            try
            {
                if (Global.Clientes[0].Identificación == "")
                { 
                    Console.WriteLine("No se encuentran registros previos");
                }
                else
                {

                    Console.WriteLine("Lista de todos los clientes registrados: \n------------------------------------------------");
                    for (contador_for = 0; contador_for <= Global._Platos_restaurante.Length - 1; contador_for++)
                    {
                        if (Global.Clientes[contador_for].Identificación == "") 
                        {
                            break;
                        }
                        Console.WriteLine("Identificación del cliente: " + Global.Clientes[contador_for].Identificación + "\n");
                        Console.WriteLine("Nombre: " + Global.Clientes[contador_for].Nombre);
                        Console.WriteLine("Primer apellido: " + Global.Clientes[contador_for].Primer_apellido);
                        Console.WriteLine("Segundo apellido: " + Global.Clientes[contador_for].Segundo_apellido);
                        Console.WriteLine("Fecha de nacimiento: " + Global.Clientes[contador_for].Fecha_de_nacimiento);
                        Console.WriteLine("Sexo: " + Global.Clientes[contador_for].Sexo + "\n----------------------------------------");
                    }
                }
            }catch (Exception e) 
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
        
        public static void Consultar_platos_por_restaurante()
        {
            int contador_for = 0;
            int contador_for2 = 0;

            Console.Clear();
            try 
            {

                if (Global.Registrar_plato_por_restaurante[0].Id_asignacion == 0) 
                {
                    
                    Console.WriteLine("No se han hecho registros previos, presione cualquier tecla para continuar.");
                    Console.Read();

                }
                else
                {
                    
                    Console.WriteLine("Aquí se muestra todos los platillos afiliados con los restaurantes.\n------------------------------------------------------------");
                    for (contador_for = 0; contador_for <= Global.Registrar_plato_por_restaurante.Length - 1; contador_for++) 
                    {

                        if (Global.Registrar_plato_por_restaurante[contador_for].Id_asignacion == 0) 
                        {
                            break;
                        
                        }
                        Console.WriteLine("Identificación de afiliación: " + Global.Registrar_plato_por_restaurante[contador_for].Id_asignacion + "\n");
                        Console.WriteLine("Nombre: " + Global.Registrar_plato_por_restaurante[contador_for].Restaurante.Nombre_del_restaurante + "\n");
                        Console.WriteLine("Fecha de afiliación: " + Global.Registrar_plato_por_restaurante[contador_for].Fecha + "\n");
                        Console.WriteLine("Id: " + Global.Registrar_plato_por_restaurante[contador_for].Restaurante.Id_del_restaurante + "\n");
                        Console.WriteLine("Dirección: " + Global.Registrar_plato_por_restaurante[contador_for].Restaurante.Direccion + "\n");
                        Console.WriteLine("Teléfono: " + Global.Registrar_plato_por_restaurante[contador_for].Restaurante.Telefono + "\n");
                        Console.WriteLine("---------------------------------------------------------------------------------------------- \n");
                        Console.WriteLine("Datos de platos asociados: \n\n");

                        for (contador_for2 = 0; contador_for2 <= Global.Registrar_plato_por_restaurante[contador_for].Platos.Length - 1; contador_for2++) 
                        {
                            if (Global.Registrar_plato_por_restaurante[contador_for].Platos[contador_for2].Id_plato == null) 
                            {
                                break;
                            }
                            Console.WriteLine("Id de plato: " + Global.Registrar_plato_por_restaurante[contador_for].Platos[contador_for2].Id_plato + "\n");
                            Console.WriteLine("Nombre: " + Global.Registrar_plato_por_restaurante[contador_for].Platos[contador_for2].Nombre + "\n");
                            Console.WriteLine("Precio: " + Global.Registrar_plato_por_restaurante[contador_for].Platos[contador_for2].Precio + "\n\n");

                        }

                        Console.WriteLine("---------------------------------------------------------------------------------------------- \n");


                    }


                    Console.Read();
                }

            }
            catch (Exception e) 
            {
                Console.Clear();
                Console.WriteLine(e);
                Console.Read();
            }


        }

        //----------------------------------------------------------------------------------------------------------------
        // Filtros de verificación de ortografía y existencia.

        public static bool verificador_de_Platos_Restaurante(string verificar_registro)
        {
            int contador_for;
            int verificador_de_int;

            // Verificamos que la cifra que nos den contenga solo números
            if (!(int.TryParse(verificar_registro, out verificador_de_int)))
            {
                return true;
            
            }

            verificador_de_int = Int32.Parse(verificar_registro);

            // Aquí vemos que no haya registros repetidos.
            for (contador_for = 0; contador_for <= Global.Registrar_plato_por_restaurante.Length - 1; contador_for++)
            {
                if (verificador_de_int == Global.Registrar_plato_por_restaurante[contador_for].Id_asignacion)
                {
                    return true;
                }
            
            }

            // Si todo sale bien, tendremos paso al siguiente paso para poder registrar lo siguiente.
            return false;
        }
        public static bool Verificador_de_id_restaurante(string verificar_registro)
        {
            int contador_for;

            int ancho_de_verificador = verificar_registro.Length - 1;
            
            char[] verificador_char = verificar_registro.ToCharArray();

            try
            {

                // Verificamos si esta bien escrito.
                for (contador_for = 0; contador_for <= ancho_de_verificador; contador_for++) 
                {
                    if (!(char.IsDigit(verificador_char[contador_for]))) 
                    {
                        return true;
                    }
                
                }

                // Pasamos a verificar si éxiste algún registro anterior a este
                int verificador_de_registro_en_int = Int32.Parse(verificar_registro);
                for (contador_for = 0; contador_for <= Global.Restaurante.Length - 1; contador_for++) 
                {
                    if (verificador_de_registro_en_int == Global.Restaurante[contador_for].Id_de_restaurante)
                    {
                        return true;
                    }
                
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Se produjo un error de tipo: " + e);
                Console.ReadKey();
            }


            // Si el programa llega aquí, significa que todo el registro se puede realizar

            return false;
        }

        public static bool Evaluador_de_categoria_plato(String numero_de_categoria) 
        {
            int verificador_de_int;
            int contador_for = 0;


            try 
            {
                //Verificamos si esta bien escrito.
                if (!(int.TryParse(numero_de_categoria, out verificador_de_int)))
                { 
                    return true;
                
                }

                // Verificamos si ya existe
                verificador_de_int = Int32.Parse(numero_de_categoria);

                for (contador_for = 0; contador_for <= Global.Categoria_de_plato.Length - 1; contador_for++) 
                {

                    if (verificador_de_int == Global.Categoria_de_plato[contador_for].Id_categoria) 
                    {
                        return true;
                    }
                }

                // Si se llega hasta acá significa que todo salió bien.
                return false;
               
            }catch (Exception e) 
            {
                Console.Clear();
                Console.WriteLine("Ocurrió una excepción de tipo: "+ e);
                Console.ReadKey();  
            
            }

            return false;
        }

        public static bool registros_previos_de_categoria(String id_de_plato) 
        {
            int id_de_plato_en_int;
            int contador_for;
            try
            {
                //Verificamos si esta bien escrito.
                if (!(int.TryParse(id_de_plato, out id_de_plato_en_int)))
                {
                    return true;
                    
                }

                // Verificamos si ya existe
                id_de_plato_en_int = Int32.Parse(id_de_plato);

                for (contador_for = 0; contador_for <= Global.Categoria_de_plato.Length - 1; contador_for++)
                {

                    if (id_de_plato_en_int == Global.Categoria_de_plato[contador_for].Id_categoria)
                    {
                        return true;
                    }
                }

                // Si se llega hasta acá significa que todo salió bien.
                return false;

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió una excepción de tipo: " + e);
                Console.ReadKey();

            }

            return false;
        }

        public static bool Existencia_de_platos(String id_de_plato) 
        {
            int id_de_plato_en_int;
            int contador_for;

            try
            {
                //Verificamos si está bien escrito.
                if (!(int.TryParse(id_de_plato, out id_de_plato_en_int)))
                {
                    return true;

                }


                // Verificamos si ya existe
                id_de_plato_en_int = Int32.Parse(id_de_plato);

                for (contador_for = 0; contador_for <= Global._Platos_restaurante.Length - 1; contador_for++)
                {

                    if (id_de_plato_en_int == Global._Platos_restaurante[contador_for].Id_plato)
                    {
                        return true;
                    }
                }

                // Si se llega hasta acá significa que todo salió bien.
                return false;

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió una excepción de tipo: " + e);
                Console.ReadKey();

            }

            return false;

        }

        public static bool Existencia_de_clientes(String id_de_CLIENTE) 
        {
            int contador_for;

            try
            {
                
                // Verificamos si ya existe.
  
                for (contador_for = 0; contador_for <= Global.Categoria_de_plato.Length - 1; contador_for++)
                {

                    if (id_de_CLIENTE == Global.Clientes[contador_for].Identificación)
                    {
                        return true;
                    }
                }

                // Si se llega hasta acá significa que todo salió bien.
                return false;

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió una excepción de tipo: " + e);
                Console.ReadKey();

            }

            return false;

        }

        //Fin de los filtros.
//------------------------------------------------------------------------------------------------------------------


        // Las funciones acumuladores.
//----------------------------------------------------------------------------------------------------------------
        public static int Contador_de_Registros_restaurantes_acumulador() 
        {

            return Global.Contador_de_registros_restaurante++;
        }
        public static int Contador_de_categoria_de_platos_acumulador() 
        { 
            return Global.Contador_de_registros_categoria++;
       
        }

        public static int Contador_de_registros_de_platos_acumulador()
        {
            return Global.Contador_de_registrar_platos++;

        }

        public static int Contador_de_registros_de_clientes()
        {
            return Global.Contador_de_clientes_registrados++;

        }

        public static int Contador_de_registros_de_PLATO_RESTAURANTE()
        {
            return Global.Contador_de_PLATO_RESTAURANTE++;

        }

        public static void Acumulador_de_posiciones_de_PLATOS_POR_RESTAURANTE(int opcion_a_escoger) 
        {

            switch (opcion_a_escoger) 
            {
                case 1: // Acumula la posición Contador_de_PLATO_RESTAURANTE

                    Global.Contador_de_PLATO_RESTAURANTE++;
                    break;
                case 2: // Acumula la posición Contador_de_PLATO_RESTAURANTE_numero_2
                    Global.Contador_de_PLATO_RESTAURANTE_numero_2++;
                    break;

                case 3: // Reinicia la posición Contador_de_PLATO_RESTAURANTE_numero_2
                    Global.Contador_de_PLATO_RESTAURANTE_numero_2 = 0;
                    break;

            }
        
        }

        //Fin de las funciones acumuladores.

        //---------------------------------------------------------------------------------------------------------------
        public static void Relleno_de_arreglos()
        {

            // Rellenamos los espacios donde se va a usar los arreglos correspondientes.
            int contador_for;
            int contador_for2;
            restaurante asignador_de_arreglo_restaurante = new restaurante();
            categoria_de_plato asignador_de_arreglo_categoria_plato = new categoria_de_plato();
            platos asignador_de_arreglo_platos = new platos();
            clientes asignador_de_arreglo_clientes = new clientes();
            PlatoRestaurante asignador_de_arreglo_plato_por_restaurante = new PlatoRestaurante();
            Objeto_sucursal asignador_sucursal = new Objeto_sucursal();


            for (contador_for = 0; contador_for <= Global.Restaurante.Length - 1; contador_for++)
            {

                // Relleno de la clase restaurante.
                asignador_de_arreglo_restaurante.Id_de_restaurante = 0;
                asignador_de_arreglo_restaurante.Nombre_de_restaurante = "";
                asignador_de_arreglo_restaurante.Direccion = "";
                asignador_de_arreglo_restaurante.Telefono = "";
                asignador_de_arreglo_restaurante.Estado = true;


                Global.Restaurante[contador_for] = asignador_de_arreglo_restaurante;

                // Relleno de la clase categoria_de_plato.
                asignador_de_arreglo_categoria_plato.Id_categoria = 0;
                asignador_de_arreglo_categoria_plato.Descripcion = "";
                asignador_de_arreglo_categoria_plato.Estado = false;

                Global.Categoria_de_plato[contador_for] = asignador_de_arreglo_categoria_plato;

                // Relleno de la clase platos_restaurante.
                asignador_de_arreglo_platos.Id_plato = 0;
                asignador_de_arreglo_platos.Nombre = "";
                asignador_de_arreglo_platos.Precio = 0;

               //asignador_de_arreglo_platos_restaurante.Id_categoria._Id_categoria = 0;
               // asignador_de_arreglo_platos_restaurante.Id_categoria.Descripcion = "";
               // asignador_de_arreglo_platos_restaurante.Id_categoria.Estado = false;

                Global._Platos_restaurante[contador_for] = asignador_de_arreglo_platos;

                // Relleno de la clase clientes

                asignador_de_arreglo_clientes.Identificación = "";
                asignador_de_arreglo_clientes.Nombre = "";
                asignador_de_arreglo_clientes.Primer_apellido = "";
                asignador_de_arreglo_clientes.Segundo_apellido = "";
                asignador_de_arreglo_clientes.Sexo = 'x';

                Global.Clientes[contador_for] = asignador_de_arreglo_clientes;

                // Relleno de la clase registrar_plato_por_restaurante

                asignador_de_arreglo_plato_por_restaurante.Id_asignacion = 0;
                asignador_de_arreglo_plato_por_restaurante.Recolector_platos.Id_plato = 0;
                
                asignador_sucursal.Direccion = "";
                asignador_sucursal.Nombre_del_restaurante = "";
                asignador_sucursal.Id_del_restaurante = 0;

                
                /*
                for (contador_for2 = 0; contador_for2 <= 9; contador_for2++) 
                {

                    Global.Registrar_plato_por_restaurante[contador_for].Platos[contador_for2] = asignador_de_arreglo_platos;

                }*/

                Global.Registrar_plato_por_restaurante[contador_for] = asignador_de_arreglo_plato_por_restaurante;
                Global.Registrar_plato_por_restaurante[contador_for].Restaurante = asignador_sucursal;
                

            } // Fin del for de relleno


        } // Fin de la función de relleno.

        public static int Retorno_id_categoria(int posicion) 
        {

            return Global.Categoria_de_plato[posicion].Id_categoria;
        }

        public static String Retorno_descripcion(int posicion)
        {

            return Global.Categoria_de_plato[posicion].Descripcion;
        }

        public static bool Retorno_de_estado(int posicion)
        {

            return Global.Categoria_de_plato[posicion].Estado;
        }

        public static String Retorno_NOMBRE_DE_RESTAURATE(int numero_de_id, int tipo_de_dato_a_retornar) 
        {
            int contador_for;
            

            switch (tipo_de_dato_a_retornar) 
            { 
            
                case 0: // Retorna el nombre
                    
                    for (contador_for = 0; contador_for <= Global.Restaurante.Length; contador_for++)
                    {
                        
                        if (numero_de_id == Global.Restaurante[contador_for].Id_de_restaurante) 
                        {
                            return Global.Restaurante[contador_for].Nombre_de_restaurante;
                        }
                    }
                    break; 

                case 1: // Retorna la dirección

                    for (contador_for = 0; contador_for <= Global.Restaurante.Length; contador_for++)
                    {

                        if (numero_de_id == Global.Restaurante[contador_for].Id_de_restaurante)
                        {
                            return Global.Restaurante[contador_for].Direccion;
                        }
                    }
                    break; 
                case 2: // Retorna el teléfono
                    for (contador_for = 0; contador_for <= Global.Restaurante.Length; contador_for++)
                    {

                        if (numero_de_id == Global.Restaurante[contador_for].Id_de_restaurante)
                        {
                            return Global.Restaurante[contador_for].Telefono;
                        }
                    }


                    break;
                
            }
            
         return Global.Restaurante[0].Direccion;
        
        }

        public static String Retorno_DE_TODOS_LOS_PLATOS(int numero_de_id, int tipo_de_dato_a_retornar)
        {
            int contador_for;


            switch (tipo_de_dato_a_retornar)
            {

                case 0: // Retorna el nombre

                    for (contador_for = 0; contador_for <= Global._Platos_restaurante.Length - 1; contador_for++)
                    {

                        if (numero_de_id == Global._Platos_restaurante[contador_for].Id_plato)
                        {
                           return Global._Platos_restaurante[contador_for].Nombre;
                        }
                    }
                    break;

                case 1: // Retorna el precio

                    for (contador_for = 0; contador_for <= Global._Platos_restaurante.Length - 1; contador_for++)
                    {

                        if (numero_de_id == Global._Platos_restaurante[contador_for].Id_plato)
                        {
                            return Global._Platos_restaurante[contador_for].Precio.ToString();
                        }
                    }
                    break;
            }

            return Global.Restaurante[0].Direccion;

        }

        public static int REtorno_de_ID_ADMITIDO(int retorno) 
        {

            return retorno;
        }

    } // Fin de todo el archivo


    
}
