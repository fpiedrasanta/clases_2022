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

using System.Collections.Generic;

namespace webapp.Models.ProgrammingParadigm
{
    public class ObjectOrientedParadigm : ProgrammingParadigm
    {
        public override string GetDefinition()
        {
            return @"<h2>Paradigma Orientado a Objetos (POO)</h2>
                    
                    Parte del concepto de 'objetos' como base, los 
                    cuales contienen información en forma de atributos 
                    o propiedades y código en forma de métodos.
                    
                    <br><br>
                    
                    Los objetos son capaces de interactuar y modificar 
                    los valores contenidos en sus campos o atributos 
                    (estado) a través de sus métodos (comportamiento).
                    
                    <br><br>
                    
                    Algunas características clave de la programación 
                    orientada a objetos son abstracción, encapsulamiento, 
                    modularidad, herencia y polimorfismo.
                    
                    <br><br>
                    
                    Su uso se popularizó a principios de la década de 1990. 
                    En la actualidad, existe una gran variedad de lenguajes 
                    de programación que soportan la orientación a objetos, 
                    estando la mayoría de éstos basados en el concepto de 
                    clases e instancias de clases (objetos).";
        }

        public List<Basis> Basics {
            get; set;
        } = new List<Basis>();

        public webapp.Models.ProgrammingParadigm.Object Object { get; set; }

        public webapp.Models.ProgrammingParadigm.Class Class { get; set; }

        public webapp.Models.ProgrammingParadigm.Message Message { get; set; }

        public ObjectOrientedParadigm()
        {
            this.Basics.Add(new Abstraction());
            this.Basics.Add(new Encapsulation());
            this.Basics.Add(new Modularity());
            this.Basics.Add(new Inheritance());
            this.Basics.Add(new Polymorphism());

            this.Class = new Class();
            this.Object = new webapp.Models.ProgrammingParadigm.Object();
            this.Message = new Message();
        }
    }
}
