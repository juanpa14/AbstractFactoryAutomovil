using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.clases;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaMazda : IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoMazda();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaMazda();
        }

        public IMotor crearMotor()
        {
            return new MotorMazda();
        }
    }
}
