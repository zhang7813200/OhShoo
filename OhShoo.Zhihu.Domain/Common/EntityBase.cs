﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhShoo.Zhihu.Domain.Common
{
    public abstract class EntityBase<TId> : IEntity<TId>
    {
        public TId Id { get; set; } = default!;
    }
}
