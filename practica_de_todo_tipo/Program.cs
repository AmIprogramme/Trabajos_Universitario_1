



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using libreria_dll;

namespace practica_de_todo_tipo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // clases_aqui objeto_de_registro = new clases_aqui();

            //LinkedList<clases_aqui> lista = new LinkedList<clases_aqui> ();
            /*
                        arreglo_de_objetos = objeto_de_registro.retorno_de_datos();

                        Console.WriteLine($"El arreglo tiene: {objeto_de_registro.cantidad_de_puestos()}\n\n");

                        for (int i = 0; i < objeto_de_registro.cantidad_de_puestos(); i++) 
                        {
                            if (arreglo_de_objetos[i] == null) 
                            {
                                break;
                            }
                            objeto_de_registro = new clases_aqui(arreglo_de_objetos[i].Id, arreglo_de_objetos[i].Name, arreglo_de_objetos[i].Estado);
                            lista.AddLast(objeto_de_registro);
                        }

                        foreach (clases_aqui f in lista) 
                        { 
                            Console.WriteLine ($"Identificación: {f.Id} \nNombre: {f.Name}\nEstado: {f.Estado} \n\n-------------------------------------------");

                        }
            

            objeto_de_registro = new clases_aqui(3, "El pepe", true);
            lista.AddLast (objeto_de_registro);

            objeto_de_registro = new clases_aqui(8930328, "Ete sech", false);
            lista.AddLast(objeto_de_registro);

            objeto_de_registro = new clases_aqui(9728, "Panocha peluda", true);
            lista.AddLast(objeto_de_registro);

            objeto_de_registro = new clases_aqui(374864, "Guaton qliao", false);
            lista.AddLast(objeto_de_registro);

            objeto_de_registro = new clases_aqui(34323, "Serpiente de cascabel", true);
            lista.AddLast(objeto_de_registro);

            clases_aqui[] arreglo_de_objetos = lista.ToArray();


            for (int i = 0; i < arreglo_de_objetos.Length; i++)
            {
                Console.WriteLine($"Identificación: {arreglo_de_objetos[i].Id} \nNombre: {arreglo_de_objetos[i].Name}\nEstado: {arreglo_de_objetos[i].Estado} \n\n-------------------------------------------");

            }*/


            // Práctica de polimorfismo

            /*
            mamiferos juan_el_caballo_loco = new perro("Saguaton 2000");

            mamiferos el_destructor_de_mundos = new doomslayer();

            juan_el_caballo_loco.imprimir_comportamiento();
            el_destructor_de_mundos.imprimir_comportamiento();
            */

            // Práctica del video de programación en c#

            /*
                        vehiculo carro = new coche();
                        vehiculo avion = new avion();

                        carro.arrancar_motor();

                        carro.conducir();
                        carro.apagar_motor();

                        Console.WriteLine("\n\n");

                        avion.arrancar_motor();
                        avion.conducir();
                        avion.apagar_motor();
            */
            // Práctica con librerias
            /*
                        Class1 ponte_a_chambear = new Class1();
                        ponte_a_chambear.imprimir_en_pantalla();
            */

            // Práctica con delegados
            /*delegador objeto_de_delegacion = new delegador(vehiculo.arrancar_motor);
            delegador objeto_de_delegacion = new delegador(Program.funcion_delegado);


            objeto_de_delegacion("Andrés");
            */

            // Uso de predicados
            /*
            List<clases_aqui> lista_de_personas = new List<clases_aqui>();
            clases_aqui objeto_de_retorno_de_datos = new clases_aqui();

            clases_aqui[] array = objeto_de_retorno_de_datos.retorno_de_datos();

            foreach (clases_aqui objeto in array) 
            {
                if (objeto == null)
                {
                    break;
                }
              lista_de_personas.Add(objeto);
            }

           
            
            Predicate<clases_aqui> el_predicador = new Predicate<clases_aqui>(pares);
            List<clases_aqui> lista_filtrada = lista_de_personas.FindAll(el_predicador);

            int numero_de_nombres_existentes = 0;
            foreach (clases_aqui item in lista_filtrada)
            {
                numero_de_nombres_existentes++;
            }

            Console.WriteLine($"Personas con el nombre cenicienta son: {numero_de_nombres_existentes}");
           */

            List<clases_aqui> lista_de_personas = new List<clases_aqui>();
            clases_aqui objeto_de_retorno_de_datos = new clases_aqui();

            clases_aqui[] array = objeto_de_retorno_de_datos.retorno_de_datos();

            foreach (clases_aqui objeto in array)
            {
                if (objeto == null)
                {
                    break;
                }
                lista_de_personas.Add(objeto);
            }

            List<clases_aqui> lista_filtrada = lista_de_personas.FindAll(i => i.Name == "Cenicienta"); // Esta es la función lamnda

            int numero_de_nombres_existentes = 0;
            foreach (clases_aqui item in lista_filtrada)
            {
                numero_de_nombres_existentes++;
            }

            Console.WriteLine($"Personas con el nombre cenicienta son: {numero_de_nombres_existentes}");

            Console.ReadKey();
        }

        private delegate bool delegador_2(String frase);

        static bool pares( clases_aqui cuantos_sujetos_hay) 
        {
            //String nombre = cuantos_sujetos_hay.Name.ToString();
            if (cuantos_sujetos_hay.Name == "Cenicienta")
            { 
                return true;
            
            }
            else
            return false;
        }
        
        
        
        private delegate clase_de_retorno[] delegador(); 


        public static void funcion_delegado(String nombre_de_la_persona)
        {

            Console.WriteLine($"Soy un desastre de persona y mi nombre es {nombre_de_la_persona}");

        }

    }

   



    public class vehiculo 
    {

        public virtual void conducir() 
        {
            
        }

        public static void arrancar_motor()
        {

            Console.WriteLine("Se prendió el motor.");
        }

        public void apagar_motor()
        {

            Console.WriteLine("Se apagó el motor.");
        }
    }

    public class coche : vehiculo 
    {
        public static void pitar()
        {
            Console.WriteLine("El carro esta pitando");
        }


        public  override void conducir()
        {
            Console.WriteLine("Estoy conduciendo un carro");
        }
    }

    public class avion : vehiculo
    {
       

        public override void conducir()
        {
            Console.WriteLine("Estoy piloteando un avión");
        }
    }


















    public class mamiferos
    {
        private String nombre_del_animal;
        public mamiferos()
        {
        }

        public mamiferos(String nombre_del_individuo)
        {
            nombre_del_animal = nombre_del_individuo;
        }

        public virtual void imprimir_comportamiento()
        {

            Console.WriteLine("Hola soy un mamifero y soy un mamador.");

        }

        protected void prueba_de_protected() 
        { 
        
            Console.WriteLine("\nEstoy protegido\n");
        }

    }


    public class perro : mamiferos
    {

        private String nombre_del_animal;


        public perro()
        {
            

        }
        public perro(String nombre_del_animal): base(nombre_del_animal) 
        {
            this.nombre_del_animal = nombre_del_animal;
        
        }

        public override void imprimir_comportamiento() 
        { 
        
        
             Console.WriteLine($"Hola soy un perro y me llamo {nombre_del_animal}");
            prueba_de_protected();
        
        }

    }


    public class doomslayer : mamiferos
    {

        private String nombre_del_animal;

        public doomslayer()
        {
           

        }
        public doomslayer(String nombre_del_animal) : base(nombre_del_animal)
        {
            this.nombre_del_animal = nombre_del_animal;

        }

        public override void imprimir_comportamiento()
        {

            Console.WriteLine("En la primera guerra, en la primera batalla, en su sed de sangre, en su sendero de muerte y destrucción\n, jamás encontro la paz en su corazón, deseando la muerte de los señores del infierno, su nombre era 'El asesino de la muerte'.");
            prueba_de_protected();
        }

    }


}
