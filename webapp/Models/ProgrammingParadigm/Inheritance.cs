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
    public class Inheritance : Basis
    {
        public override string GetDefinition()
        {
            return @"<h2>Herencia</h2>
                    
                    Las clases no se encuentran aisladas, sino 
                    que se relacionan entre sí, formando una 
                    jerarquía de clasificación. Los objetos heredan 
                    las propiedades y el comportamiento de todas las 
                    clases a las que pertenecen permitiendo a los 
                    objetos ser definidos y creados como tipos 
                    especializados de objetos preexistentes.
                    
                    <br><br>
                    
                    Estos pueden compartir (y extender) su 
                    comportamiento sin tener que volver a implementarlo.";
        }
    }
}
