using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro.Models
{
    public class JsonData
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Guns.json");

        public List<Guns> Guns { get; set; }

        public static List<Guns> GetGuns()
        {
            var jsonData = File.ReadAllText(filePath);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<JsonData>(jsonData).Guns;
        }

        public static void SaveGun(Guns gun)
        {
            var guns = GetGuns();

            var currentGun = guns.Where(x => x.Name == gun.Name).FirstOrDefault();

            currentGun.ToIncrease = gun.ToIncrease;
            currentGun.IncreaseSpeed = gun.IncreaseSpeed;
            currentGun.FromIncrease = gun.FromIncrease;
            currentGun.Value = gun.Value;

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(guns, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, "{\"Guns\": " +output+"}");
        }
    }
}
