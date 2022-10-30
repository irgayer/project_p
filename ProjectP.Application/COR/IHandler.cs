using ProjectP.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.Application.COR;

public interface IHandler
{
    void SetNextHandler(IHandler next);
    bool Handle(Post post);
}
