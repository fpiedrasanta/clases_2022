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
    public class Modularity : Basis
    {
        public override string GetDefinition()
        {
            return @"<h2>Modularidad</h2>
                    
                    Propiedad que permite subdividir una 
                    aplicación en partes más pequeñas 
                    (llamadas módulos), cada una de las cuales 
                    debe ser tan independiente como sea posible 
                    de la aplicación en sí y de las restantes 
                    partes. 
                    
                    <br><br>
                    
                    Estos módulos se pueden compilar por separado, 
                    pero tienen conexiones con otros módulos.";
        }
    }
}
