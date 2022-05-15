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
    public class Car
    {
        public double VelocityInKilometersPerHour { get; set; }
        
        public double AccelerationInKilometersPerHour { get; set; }
        
        public double SpeedUp(double timeInSeconds)
        {
            this.VelocityInKilometersPerHour += 
                (this.AccelerationInKilometersPerHour *
                timeInSeconds);
            
            return this.VelocityInKilometersPerHour;
        }
    }
}
