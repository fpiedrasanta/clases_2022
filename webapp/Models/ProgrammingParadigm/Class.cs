/********************************************************************************************
* Copyright (C) 2022 Ing. de Software, 3er año, ITSC
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <https://www.gnu.org/licenses/>.
*******************************************************************************************/

namespace webapp.Models.ProgrammingParadigm
{
    public class Class
    {
        public string GetDefinition()
        {
            return @"<h2>Clase</h2>
                    
                    Una clase es una especie de 'plantilla' en la que se 
                    definen los <strong>atributos</strong> y 
                    <strong>métodos</strong> predeterminados de un tipo de 
                    <strong>objeto</strong>.
                    
                    <br><br>
                                        
                    Esta plantilla se crea para poder crear 
                    <strong>objetos</strong> fácilmente.
                    
                    <br><br>

                    Al método de crear nuevos <strong>objetos</strong> 
                    mediante la lectura y recuperación de los 
                    <strong>atributos</strong> y <strong>métodos</strong> 
                    de una <strong>clase</strong> se le conoce como 
                    <strong>instanciación</strong>.";
        }
    }
}
