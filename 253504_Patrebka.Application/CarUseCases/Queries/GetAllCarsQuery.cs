using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253504_Patrebka.Application.CarUseCases.Queries
{
    public record GetAllCarsQuery : IRequest<List<Car>>
    {
    }
}
