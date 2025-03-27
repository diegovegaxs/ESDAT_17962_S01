using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaS
{
    class Locomotora
    {
        Vagon Primero {  get; set; }

        public void AgregaPrimero(int valor)
        {
            // Crear un nuevo vagón con el valor dado
            Vagon nuevo = new Vagon(valor);

            // Si la locomotora está vacía (Primero es null), el nuevo vagón será el primero
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                // Si ya hay vagones, hacemos que el nuevo vagón apunte al anterior primero
                nuevo.Sig = this.Primero;
                // Ahora el nuevo vagón es el primero
                this.Primero = nuevo;
            }
        }

        public void AgregaFinal(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) //caso 1
            {
                this.Primero = nuevo;
            }
            else 
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
        
        public string VerVagones()
        {
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null) 
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }
    }
}
