using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLibrary.Models
{
    public class Effect
    {
       
        public string Name { get; set; }

        public static  List<Effect> GetEffects()
        {
            var result = new List<Effect>();
            List<string> effects = new List<string>();
            effects.Add("Effect1");//Get from appsettings.json
            effects.Add("Effect2");
            effects.Add("Effect3");

            effects.ForEach(name =>
            {
                result.Add(new Effect() { Name = name });
            });

            return result;

        }
    }
}
