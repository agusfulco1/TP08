using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP08.Models
{
    public class Series
    {
        private int _IdSerie;
        private string _Nombre;
        private int _AñoInicio;
        private string _Sinopsis;
        private string _ImagenSerie;
        public Series(){

        }
        public Series(int idSerie, string nombre, int añoInicio, string sinopsis, string imagenSerie)
        {
            _IdSerie = idSerie;
            _Nombre = nombre;
            _AñoInicio = añoInicio;
            _Sinopsis = sinopsis;
            _ImagenSerie = imagenSerie;
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
        public int añoInicio
        {
            get {return _AñoInicio;}
            set {_AñoInicio = value;}
        }
        public string sinopsis
        {
            get {return _Sinopsis;}
            set {_Sinopsis = value;}
        }
        public string imagenSerie
        {
            get {return _ImagenSerie;}
            set {_ImagenSerie = value;}
        }
    }
}