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

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models.ProgrammingParadigm;
using webapp.Models.ViewModel.ProgrammingParadigm;

namespace webapp.Controllers
{
    public class ProgrammingParadigmController : Controller
    {
        private readonly ILogger<ProgrammingParadigmController> _logger;

        public ProgrammingParadigmController(ILogger<ProgrammingParadigmController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Paradigm paradigm = new Paradigm();

            webapp.Models.ProgrammingParadigm.ProgrammingParadigm programmingParadigm = 
                new webapp.Models.ProgrammingParadigm.ProgrammingParadigm();

            ObjectOrientedParadigm objectOrientedParadigm = new ObjectOrientedParadigm();
            
            ProgrammingParadigmViewModel programmingParadigmViewModel
                = new ProgrammingParadigmViewModel();
            
            
            programmingParadigmViewModel.Sections.Add(paradigm.GetDefinition());
            programmingParadigmViewModel.Sections.Add(programmingParadigm.GetDefinition());
            programmingParadigmViewModel.Sections.Add(objectOrientedParadigm.GetDefinition());
            
            foreach(Basis basis in objectOrientedParadigm.Basics)
            {
                programmingParadigmViewModel.Sections.Add(basis.GetDefinition());
            }

            programmingParadigmViewModel.Sections.Add(objectOrientedParadigm.Class.GetDefinition());
            programmingParadigmViewModel.Sections.Add(objectOrientedParadigm.Object.GetDefinition());
            programmingParadigmViewModel.Sections.Add(objectOrientedParadigm.Message.GetDefinition());

            programmingParadigmViewModel.Sections.Add(@"
                <h3>Primer ejemplo: Abstracción</h3>

                <p>En este ejemplo vamos a ver que para 'mi sistema' una persona es únicamente
                un nombre completo, un dni y un correo electrónico.</p>
                
                <p>Sin embargo una persona en la realidad tiene muchos otros atributos,
                sin embargo, nos abstraemos de esos attrs y solo modelamos los que nos sirven.</p>

                <a href='/ProgrammingParadigm/AbstractionExample'>Haga clic aqui para ir al ejemplo</a>
            ");

            programmingParadigmViewModel.Sections.Add(@"
                <h3>Segundo ejemplo: Encapsulamiento</h3>

                <p>En este ejemplo vamos a ver lo importante del encapsulamiento
                y la posibilidad de 'ocultar' métodos o atributos.</p>
                
                <p>En la implementación del patrón de diseño Singleton, yo requiero tener
                una única instancia del objeto, para ello necesito que el Contructor esté
                innaccesible desde fuera (private).</p>

                <a href='/ProgrammingParadigm/EncapsulationExample'>Haga clic aqui para ir al ejemplo</a>
            ");

            programmingParadigmViewModel.Sections.Add(@"
                <h3>Tercer ejemplo: Herencia</h3>

                <p>En este ejemplo vamos a ver cómo funciona la herencia, donde tenemos Animal,
                el Mono (que ES UN animal) y Humano (que ES UN mono). Todos van a heredar
                los atributos públicos, internal o protected y vemos también cómo ir pasando
                hacia arriba los parámetros de construcción.</p>
                
                <a href='/ProgrammingParadigm/InheritanceExample'>Haga clic aqui para ir al ejemplo</a>
            ");

            programmingParadigmViewModel.Sections.Add(@"
                <h3>Cuarto ejemplo: Polimorfismo</h3>

                <p>Ejemplo de polimorfismo usando Animales Domésticos (Perros y Gatos)
                y haciendo que estos 'hablen'. Si es un perro dirá una cosa, si es un gato, dirá otra.
                Los diferentes objetos responderán de diferentes maneras a los mismos mensajes.</p>
                
                <a href='/ProgrammingParadigm/PolymorphismExample'>Haga clic aqui para ir al ejemplo</a>
            ");

            programmingParadigmViewModel.Sections.Add(@"
                <h3>Quinto y último ejemplo: Clases y objetos</h3>

                <p>En este caso programamos la Clase Car, e instanciamos 2 Objetos (que lo guardamos en 2
                variables diferentes) y en función de la aceleración de cada auto en particular
                ganará uno u otro para una misma cantidad de tiempo acelerando (9 segundos por ejemplo).</p>

                <p>Es probable que en este ejemplo haya errores de lógica de cálculos de velocidad
                y aceleración, sobre todo porque no tuve en cuenta la resistencia, pero pongamos
                un poco de imaginación :D</p>
                
                <a href='/ProgrammingParadigm/ClassAndObjectExample'>Haga clic aqui para ir al ejemplo</a>
            ");

            return View(programmingParadigmViewModel);
        }

        [HttpGet]
        public IActionResult AbstractionExample()
        {
            AbstractionExampleViewModel abstractionExampleViewModel = 
                new AbstractionExampleViewModel();
            
            abstractionExampleViewModel.Person = new Person
            {
                Name = "José",
                Surname = "Rodriguez",
                Email = "jrodriguez@gmail.com",
                DocumentNumber = 12345678
            };

            return View(abstractionExampleViewModel);
        }

        [HttpGet]
        public IActionResult EncapsulationExample()
        {
            EncapsulationExampleViewModel encapsulationExampleViewModel = 
                new EncapsulationExampleViewModel();
            
            Singleton.Instance.AccessCounter++;

            encapsulationExampleViewModel.AccessCounter = 
                Singleton.Instance.AccessCounter;

            /***********************************************************
             * Intento crear una nueva instancia
             * Que haria que tenga 2 contadores
             * Lo cual está mal, porque justamente eso es Singleton 
             * (una sola instancia).
             * Descomentar el código de abajo para ver cuál es el error.
            ************************************************************/

            //Singleton singleton = new Singleton();

            return View(encapsulationExampleViewModel);
        }

        [HttpGet]
        public IActionResult InheritanceExample()
        {
            InheritanceExampleViewModel inheritanceExampleViewModel = 
                new InheritanceExampleViewModel();
            
            inheritanceExampleViewModel.Animal = 
                new Animal("This is an animal!");

            inheritanceExampleViewModel.Monkey = 
                new Monkey("This is a monkey!");

            inheritanceExampleViewModel.Human = 
                new Human("This is a Human!");

            return View(inheritanceExampleViewModel);
        }

        [HttpGet]
        public IActionResult PolymorphismExample()
        {
            PolymorphismExampleViewModel polymorphismExampleViewModel
                = new PolymorphismExampleViewModel();

            polymorphismExampleViewModel.Pets = this.getDomesticAnimals(5);

            return View(polymorphismExampleViewModel);
        }

        [HttpGet]
        public IActionResult ClassAndObjectExample()
        {
            Random random = new Random();
            Car chevy = new Car
            {
                AccelerationInKilometersPerHour = random.Next(38, 43),
                VelocityInKilometersPerHour = 0
            };

            Car falcon = new Car
            {
                AccelerationInKilometersPerHour = random.Next(38, 43),
                VelocityInKilometersPerHour = 0
            };

            chevy.SpeedUp(2.8);
            falcon.SpeedUp(2.8);

            ClassAndObjectExampleViewModel classAndObjectExampleViewModel =
                new ClassAndObjectExampleViewModel();

            if(chevy.VelocityInKilometersPerHour > falcon.VelocityInKilometersPerHour)
            {
                classAndObjectExampleViewModel.Result = "¡Ganó el Chevy! (¡aguante Canapino!)";
            }
            else if(chevy.VelocityInKilometersPerHour < falcon.VelocityInKilometersPerHour)
            {
                classAndObjectExampleViewModel.Result = "¡Ganó el Falcón! (ya quisiera Mariano Werner...)";
            }
            else
            {
                classAndObjectExampleViewModel.Result = "Empate.";
            }

            return View(classAndObjectExampleViewModel);
        }

        private List<DomesticAnimal> getDomesticAnimals(int count)
        {
            List<DomesticAnimal> domesticAnimals = 
                new List<DomesticAnimal>();

            Random random = new Random();

            for(int i = 0; i < count; i++)
            {
                int value = random.Next(1, 4);
                if(value == 1)
                {
                    domesticAnimals.Add(new Dog());
                }
                else if(value == 2)
                {
                    domesticAnimals.Add(new Cat());
                }
                else
                {
                    domesticAnimals.Add(new Bird());
                }
            }

            return domesticAnimals;
        }
    }
}
