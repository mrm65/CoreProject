﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAnnouncementService:IGenericService<Announcement>
    {
        IDataResult<List<Announcement>> GetAllOrderByDesc();
       
    }
}