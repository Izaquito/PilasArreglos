using System;
using System.Collections.Generic;
using System.Text;

namespace PilasArreglos
{
    internal class Pilas
    {
        string[] _pila;
        int _tope;
        int _topefijo;

        public Pilas(int elementos)
        {
            _pila = new string[elementos];
            _tope = 0;
            _topefijo = _pila.Length;
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
            
            _tope--;
            if (_tope == -1)
            {
                _tope = _pila.Length;
            }
            _pila[_tope] = string.Empty;

        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            for (int i = 0; i < _topefijo; i++)
            {
                datos.AppendLine(_pila[i]);
            }
            return datos.ToString();

        }
    }
}
