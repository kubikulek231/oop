using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    internal class Radio
    {
        public bool isOn { get; set; } = false;
        public double tunedFrequncy { get; private set; }
        private Dictionary<int, double> SavedPresets = new Dictionary<int, double>();
        
        public void SavePreset(int number, double frequency)
        {
            if (!SavedPresets.ContainsKey(number))
            {
                SavedPresets.Add(number, frequency);
            }
        }
        public void LoadPreset(int number)
        {
            if (SavedPresets.ContainsKey(number))
            {
                tunedFrequncy = SavedPresets[number];
            }
        }
    }

}
