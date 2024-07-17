using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public class EmptyParameters : IParameters
    {
        ParameterInfo[] IParameters.GetDescription()
        {
           return new ParameterInfo[0];
        }
        void IParameters.SetValues(double[] values) {}
    }
}
