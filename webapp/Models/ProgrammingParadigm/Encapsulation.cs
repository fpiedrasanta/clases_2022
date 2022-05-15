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
    public class Encapsulation : Basis
    {
        public override string GetDefinition()
        {
            return @"<h2>Encapsulamiento</h2>
            
                    Significa reunir todos los elementos que pueden 
                    considerarse pertenecientes a una misma entidad, 
                    al mismo nivel de abstracción.
                    
                    <br><br>

                    Esto permite aumentar la cohesión de los componentes 
                    del sistema.
                    
                    <br><br>

                    Este concepto se suele emplear conjuntamente con el 
                    principio de ocultación.";
        }
    }
}
