using System;
using System.Collections.Generic;
using System.Text;

namespace PilasArreglos
{
    internal class Pilas
    {
        string[] _pila;
        int _tope;

        public Pilas(int elementos)
        {
            _pila = new string[elementos];
            _tope = 0;
        }

        public void Agregar(string dato)
        {
            if (_tope == _pila.Length) 
            {
                _tope = 0; 
            }
            _pila[_tope] = dato;
            _tope++;
        }

        public void Eliminar()
        {
            if (_tope == -1)
            {
                _tope = _pila.Length;
            }
            _tope--;
            _pila[_tope] = string.Empty;
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            for (int i = 0; i < _tope; i++)
            {
                datos.AppendLine(_pila[i]);
            }
            return datos.ToString();

        }
    }
}
