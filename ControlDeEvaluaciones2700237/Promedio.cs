using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeEvaluaciones2700237
{
    public class Promedio
    {
        public string estudiante { get; set; }
        public int evaluacion1 { get; set; }
        public int evaluacion2 { get; set; }
        public int evaluacion3 { get; set; }
        public int actitudinal { get; set; }

        public virtual double calculapromedio()
        {
            return (evaluacion1 + evaluacion2 + evaluacion3 + actitudinal) / 4;
        }
        public string determinaCondicion()
        {
            if (calculapromedio() < 12.5)
                return "Desaprobado";
            else
                return "Aprobado";
        }
    }
}
