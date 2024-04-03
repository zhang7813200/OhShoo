using OhShoo.Zhihu.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhShoo.Zhihu.Domain.Entities
{
    public class AppUser(string UserName) : EntityBase<int>, IAggregateRoot;
}
