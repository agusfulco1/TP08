using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP08.Models
{
    public class Actores
    {
        private int _IdActor;
        private int _IdSerie;
        private string _Nombre;
        public Actores(){

        }
        public Actores(int idActor, int idSerie, string nombre)
        {
            _IdActor = idActor;
            _IdSerie = idSerie;
            _Nombre = nombre;
        }
        public int idActor
        {
            get {return _IdActor;}
            set {_IdActor = value;}
        }
        public int idSerie
        {
            get {return _IdSerie;}
            set {_IdSerie = value;}
        }
        public string nombre
        {
            get {return _Nombre;}
            set {_Nombre = value;}
        }
    }
}