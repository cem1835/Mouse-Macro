using J3M.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace J3M.Business
{
    public interface IGunService
    {
        IEnumerable<Gun> GetGuns();

        (bool result, string message) AddOrUpdateGun(Gun gun);
    }
}
