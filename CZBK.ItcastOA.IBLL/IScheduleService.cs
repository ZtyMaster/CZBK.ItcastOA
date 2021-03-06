﻿using CZBK.ItcastOA.Model;
using CZBK.ItcastOA.Model.SearchParam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastOA.IBLL
{
    public partial interface IScheduleService : IBaseService<Schedule>
    {
        IQueryable<Schedule> LoadSearchEntities(Model.SearchParam.UserInfoParam uip);
    }     
}
