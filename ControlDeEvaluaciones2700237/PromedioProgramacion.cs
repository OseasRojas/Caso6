using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeEvaluaciones2700237
{
    public class PromedioProgramacion : Promedio
    {
        public override double calculapromedio()
        {
            return evaluacion1 * 0.15 + evaluacion2 * 0.3 + evaluacion3 * 0.5 + actitudinal * 0.05;
        }
    }
}
