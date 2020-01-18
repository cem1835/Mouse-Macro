using J3M.Entities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace J3M.Business
{
    public class GunService:IGunService
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Guns.json");

        public IEnumerable<Gun> GetGuns()
        {
            var jsonData = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<JsonModel>(jsonData).Guns;
        }

        public (bool result,string message) AddOrUpdateGun(Gun gun)
        {
            var guns = GetGuns();


            var  gunExists = guns.Any(x => x.Name == gun.Name);


            return gunExists ? Update(guns.ToList(), gun) : Add(guns.ToList(), gun);
        }

        private (bool result,string message) Add(List<Gun> guns,Gun gun)
        {
            guns.Add(gun);

            return Save(guns);
        }

        private (bool result, string message) Update(List<Gun> guns,Gun gun)
        {
            var currentGun = guns.Where(x => x.Name == gun.Name).FirstOrDefault();

            currentGun.Name = gun.Name;
            currentGun.NumpadNo = gun.NumpadNo;
            currentGun.OrderNo = gun.OrderNo;
            currentGun.Values = gun.Values;
            currentGun.WaitTime = gun.WaitTime;

            return Save(guns);
        }

        private (bool result,string message) Save(List<Gun> guns)
        {
            try
            {
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(guns, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, "{\"Guns\": " + output + "}");

                return (true, "succes");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }


    }
}
