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

        public void SetCPS(string cps)
        {
            int trueCPS = Validator.validateCPS(cps);
            RGModel.SetCPS(trueCPS);
        }

        public void SetFrame(string[] coords)
        {
            int[] trueCoords = Validator.validateCoord(coords);
            RGModel.SetFrame(trueCoords);
        }

        public void SetRunState(bool isChecked)
        {
            RGModel.Run(isChecked);
        }

        public void SetFrameVisible(bool FrameVisibleIsChecked)
        {
            RGModel.ShowFrame(FrameVisibleIsChecked);
        }

        public Dictionary<MainFormFields, string> refreshFields()
        {
            return new Dictionary<MainFormFields, string>() {
                { MainFormFields.CPSValue, RGModel.CPS.ToString()},
                { MainFormFields.LeftUpX, RGModel.Frame.FirstPoint.X.ToString()},
                { MainFormFields.LeftUpY, RGModel.Frame.FirstPoint.Y.ToString()},
                { MainFormFields.RightDownX, RGModel.Frame.SecondPoint.X.ToString()},
                { MainFormFields.RightDownY, RGModel.Frame.SecondPoint.Y.ToString()},
            };
        }
    }

    public enum MainFormFields
    {
        CPSValue, LeftUpX, LeftUpY, RightDownX, RightDownY,
    }
}
