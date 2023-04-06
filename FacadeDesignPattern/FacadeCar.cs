﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class FacadeCar
    {
        private Model Model =new Model();
        private Motor Motor = new Motor();
        private Body Body = new Body();
        private Features Features = new Features();

        public void CreateCar()
        {
            Model.CreateModel();
            Motor.CreateMotor();
            Body.CreateBody();
            Features.CreateFeature();
        }
    }
}
