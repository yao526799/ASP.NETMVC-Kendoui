﻿using System.Linq;
using Fzrain.Core.Domain.Configuration;

namespace Fzrain.Service.Configuration
{
   public  interface ISettingService
   {
       Setting GetById(int id);
       IQueryable<Setting> GetAll();

        string GetValueByName(string name);

        void AddSetting(Setting setting);
        void UpdateSetting(Setting setting);
        void RemoveSetting(Setting setting);

    }
}
