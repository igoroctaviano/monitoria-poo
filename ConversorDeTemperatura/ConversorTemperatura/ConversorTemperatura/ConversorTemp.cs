//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversorTemperatura
{
    public static class ConversorTemp
    {
        public static Double CelsiusFahrenheit(double tempCelsius)
        {
            return (tempCelsius * 9 / 5) + 32;

        }

        public static Double FahrenheitCelsius(double tempFahrenheit)
        {
            return (tempFahrenheit - 32) * 5 / 9;

        }
    }
}
