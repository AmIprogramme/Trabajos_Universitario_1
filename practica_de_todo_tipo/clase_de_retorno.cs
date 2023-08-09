using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_de_todo_tipo
{
    public class clase_de_retorno
    {
        private static int cantidad_de_posiciones_arreglo = 0;

        public int cantidad_de_puestos() 
        {
            return cantidad_de_posiciones_arreglo;

        }

        public  clases_aqui[] retorno_de_datos() 
        {
            clases_aqui[] elemento_a_retornar = new clases_aqui[20];

            elemento_a_retornar[0] = new clases_aqui(1, "Pancho Lopez", true);
            elemento_a_retornar[1] = new clases_aqui(2, "Ignacio", true);
            elemento_a_retornar[2] = new clases_aqui(3, "Samantha", true);
            elemento_a_retornar[3] = new clases_aqui(4, "Pachamamam", true);
            elemento_a_retornar[4] = new clases_aqui(5, "Soleimar", true);
            elemento_a_retornar[5] = new clases_aqui(6, "Valeria", false);
            elemento_a_retornar[6] = new clases_aqui(7, "Calcetin", true);
            elemento_a_retornar[7] = new clases_aqui(8, "Jean Claud Vaan Damn", true);


            elemento_a_retornar[8] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[9] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[10] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[11] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[12] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[13] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[14] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[15] = new clases_aqui(9, "Cenicienta", true);

            elemento_a_retornar[16] = new clases_aqui(9, "Cenicienta", true);
            elemento_a_retornar[17] = new clases_aqui(9, "Cenicienta", true);
            ;

            foreach (clases_aqui g in elemento_a_retornar) 
            {
                if (g == null)
                {
                    break;
                }
                cantidad_de_posiciones_arreglo++;
            }
            
           
            return elemento_a_retornar;
        }
    }

    public class clases_aqui: clase_de_retorno
    {
        private int id;
        private string name;
        private bool estado;

        public clases_aqui()
        {
        }

        public clases_aqui(int id, string name, bool estado)
        {
            Id = id;
            Name = name;
            Estado = estado;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Estado { get => estado; set => estado = value; }

        public String retorno_de_nombre() 
        {
            return Name;
        
        
        }


    }
}
