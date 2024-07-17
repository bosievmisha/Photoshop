using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public abstract class ParametizedFilter : IFilter
    {
        IParameters parameters;
        public ParametizedFilter(IParameters parameters)
        {
            this.parameters = parameters;
        }

        ParameterInfo[] IFilter.GetParameters()
        {
            return parameters.GetDescription();
        }

        public Photo Process(Photo original, double[] values)
        {
            this.parameters.SetValues(values);
            return Process(original, this.parameters);
        }
        public abstract Photo Process(Photo original, IParameters parameters);
        
        
    }
}
