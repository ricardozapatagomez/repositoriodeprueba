using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {//private string _name;//va
        //lo bueno de aca me da facilidad de variables de entrada a diferencia del metodo cobn doble tab

        //public string getName()
        //{
        //    return _name;
        //}

        //public void setName(string name)
        //{
        //    _name = name;//o  tambien this.name=name;
        //}

        //propiamente de c# de su getters  y setters
        //no es una variable es una propiedad
        /*
         * aca si necesito mi variable de instancia
         * _name
        public string Name//no puede ser exactamente igual pra facilidad le coloco name conin mayuscula
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }*/

        //prop y doble tab//abreviacion de lo de arriba 
        //ocultando mi variable de instancia 
        //aca no me permite validar
        public string Name { get; set; }

        //ctor + doble tab

        //constructor por defecto
        public Account()
        {

        }
        //constructor personalizado 
        //primero construir un constructor por defecto y dejarlo asi
        public Account(string name)
        {
            Name = name;
        }
        //por buenas practicas crear uno vacio y uno personalizado




    }
}
