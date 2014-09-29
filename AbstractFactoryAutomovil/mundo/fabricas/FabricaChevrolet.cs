using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.clases;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaChevrolet : IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoChevrolet();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaChevrolet();
        }

        public IMotor crearMotor()
        {
            return new MotorChevrolet();
        }
    }
}
