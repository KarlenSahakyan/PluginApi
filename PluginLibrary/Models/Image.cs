using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLibrary.Models
{
    public class Image
    {
        string effectState = "";
        public int Id { get; set; }
        public int Size { get; set; }

        public string ImageObject { get; set; }
        public int Radius { get; set; }

        public string GetImmageEffects() => effectState;

        public void AddEffect(Effect effect)=>effectState += effect.Name;
        
        public void ChangeSize(int size) => Size = size;
        public void ChangeRadius(int radius) => Radius = radius;
        public void RemoveEffect(Effect effect)
        {
            if (!effectState.Contains(effect.Name))
            {
                effectState = effectState.Remove(effectState.IndexOf("None"), effect.Name.Length);
            }
        }
    }
}
