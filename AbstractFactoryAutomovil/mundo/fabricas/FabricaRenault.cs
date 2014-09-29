using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.clases;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaRenault : IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoRenault();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaRenault();
        }

        public IMotor crearMotor()
        {
            return new MotorRenault();
        }
    }
}
