using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP08.Models
{
    public class Temporadas
    {
        private int _IdTemporada;
        private int _IdSerie;
        private int _NumeroTemporada;
        private string _TituloTemporada;
        public Temporadas(){

        }
        public Temporadas(int idTemporada, int idSerie, int numeroTemporada, string tituloTemporada)
        {
            _IdTemporada = idTemporada;
            _IdSerie = idSerie;
            _NumeroTemporada = numeroTemporada;
            _TituloTemporada = tituloTemporada;
        }
        public int idTemporada
        {
            get {return _IdTemporada;}
            set {_IdTemporada= value;}
        }
        public int idSerie
        {
            get {return _IdSerie;}
            set {_IdSerie = value;}
        }
        public int numeroTemporada
        {
            get {return _NumeroTemporada;}
            set {_NumeroTemporada = value;}
        }
        public string tituloTemporada
        {
            get {return _TituloTemporada;}
            set {_TituloTemporada = value;}
        }
    }
}