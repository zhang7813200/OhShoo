using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhShoo.Zhihu.Domain.Common
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
