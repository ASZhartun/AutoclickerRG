using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoclickerRG
{
    public class MainController
    {
        RGModel RGModel { get; set; }
        Validator Validator { get; set; }

        public MainController(RGModel rGModel, Validator validator)
        {
            RGModel = rGModel;
            Validator = validator;
        }

        public void SetCPS(string cps) {
            int trueCPS = Validator.validateCPS(cps);
            RGModel.SetCPS(trueCPS);
        }

        public void SetFrame(string[] coords) {
            int[] trueCoords = Validator.validateCoord(coords);
            RGModel.SetFrame(trueCoords);
        }

        public void SetRunState(bool isChecked) {
            RGModel.Run(isChecked);
        }

        internal void SetFrameVisible(bool FrameVisibleIsChecked)
        {
            RGModel.ShowFrame(FrameVisibleIsChecked);
        }
    }
}
