using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        } = Vector2.zero;

        public float mass = 1.0f;
        public float force = 150.0f;
        public float dragCoefficient = .47f;
        public float fluidDensity = 1.225f;
        public float area = 1024 * (float)Math.PI;

        public void AddForce(Vector2 forceDirection, float deltaTime)
        {
                ////(kracht in richting) + (kracht tegen richting in) * tijd;
                ////float Fz = mass * 9.81f;
                ////float Fw = dragCoefficient * Fz;
                ////Vector2 Fres = (Velocity + force * forceDirection) * deltaTime;
                ////Velocity = Fres - (Fw * Fres);

                ////Vector2 Fv = (Velocity + ((forceDirection * force) * deltaTime));
                ////Velocity = Fv + ((Fv * dragCoefficient * -1) * deltaTime);

                ////Vector2 resulterendeVector = Velocity + forceDirection * force;
                ////Velocity = ((resulterendeVector - (Velocity * dragCoefficient)) / mass) * deltaTime;

                ////Vector2 resultingVector = (Velocity + (force * forceDirection)) * deltaTime;
                ////Vector2 fluidResistance = 0.5f * fluidDensity * dragCoefficient * area * (new Vector2(resultingVector.x * resultingVector.x, resultingVector.y * resultingVector.y)) * deltaTime;
                //////Vector2 resultingVector = Velocity + (force * forceDirection);
                ////Vector2 newVelocity = resultingVector - fluidResistance;
                ////Velocity = Velocity + (newVelocity / mass) * deltaTime;

            /// Hier heb ik het berekend volgens de natuurkundige formules. Echter kan Unity het niet aan.
            /// 
            /// 
            //Vector2 Fadded = force * forceDirection;
            //Vector2 Fdrag = 0.5f * fluidDensity * dragCoefficient * area * Velocity.Magnitude * Velocity.Magnitude * forceDirection;
            //Vector2 Fres = Fadded - Fdrag;
            //Vector2 acceleration = Fres / mass;
            //Velocity = Velocity + acceleration * deltaTime;

            Vector2 acceleration = ((forceDirection * force) / mass) * deltaTime;
            Velocity = (1 / dragCoefficient) * (float)Math.Exp(-dragCoefficient / mass * deltaTime) * (Velocity * dragCoefficient + acceleration * mass) - (acceleration * mass / dragCoefficient);
        }
    }
}
