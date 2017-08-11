using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7
{
    public class MethodDeconstruction
    {

        public class Ball
        {
            public int Diameter { get; }
            public float Weight { get; }

            public Ball(int diameter, float weight)
            {
                this.Diameter = diameter;
                this.Weight = weight;
            }

            /// <summary>
            /// The Deconstruct method is required if you want to deconstruct any object.
            /// </summary>
            /// <param name="ballDiameter"></param>
            /// <param name="ballWeight"></param>
            public void Deconstruct(out int ballDiameter, out float ballWeight)
            {
                ballDiameter = this.Diameter;
                ballWeight = this.Weight;
            }
        }

        public void BeforeBounceBall()
        {
            Ball ball = new Ball(diameter: 22, weight: 32.1f);

            // This is not deconstructing the type.
            int diameter = ball.Diameter;
            float weight = ball.Weight;
        }

        public void NowBounceBall()
        {
            Ball ball = new Ball(diameter: 22, weight: 32.1f);
            // This is deconstructing.
            (int bWidth, float bWeight) = ball;
            int finalBallWidth = bWidth;
            float finalBallWeight = bWeight;
        }
    }
}