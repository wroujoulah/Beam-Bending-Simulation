﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forces
{
    public abstract class Force
    {
        public const int factor = 1;//للتحويل بين الواحدات
        public Force(double power)
        {
            Power = power;
        }
        public double Power { set; get; }
        abstract public double getMomentom(double distance);
        abstract public double getfMomentomd2x(double distance, double beamLength);
        public abstract void add(Force force);
        protected void addPower(Force force)
        {
            this.Power += force.Power;
        }
        public abstract bool canAdd(Force force);
        protected bool sameType(Force force)
        {
            return this.GetType() == force.GetType();
        }
        abstract public ReflectionBeamForce getReflectionLeft(double BeamLenght);
        abstract public ReflectionBeamForce getReflectionRight(double BeamLenght);
    }
}
