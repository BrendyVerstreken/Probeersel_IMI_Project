﻿using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class ProductionHouseResponseDto : DtoBase
    {
        public string Name { get; set; }
        public string Headquarters { get; set; }
    }
}
