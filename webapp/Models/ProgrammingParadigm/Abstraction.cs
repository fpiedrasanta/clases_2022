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
    public class Abstraction : Basis
    {
        public override string GetDefinition()
        {
            return @"<h2>Abstracción</h2>
            
                    Denota las características esenciales de 
                    un objeto, donde se capturan sus comportamientos. 
                    Cada objeto en el sistema sirve como modelo de un 
                    'agente' abstracto que puede realizar trabajo, 
                    informar y cambiar su estado, y 'comunicarse' 
                    con otros objetos en el sistema sin revelar 'cómo' 
                    se implementan estas características. El proceso de 
                    abstracción permite seleccionar las características 
                    relevantes dentro de un conjunto e identificar 
                    comportamientos comunes para definir nuevos tipos de 
                    entidades en el mundo real.";
        }
    }
}
