using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign
{
    public class GarageStation
    {
        IGarageUtility _garageUtil;

        public GarageStation(IGarageUtility garageUtil)
        {
            this._garageUtil = garageUtil;
        }
        public void OpenForService()
        {
            _garageUtil.OpenGate();
        }
        public void CloseGarage()
        {
            _garageUtil.CloseGate();
        }
    }
    public class GarageSationUtility : IGarageUtility
    {
        public void OpenGate() 
        {
            //Open the Garage for service
        }
        public void CloseGate()
        {
            //close the garage functionality
        }
    }
    public interface IGarageUtility
    {
        void OpenGate();
        void CloseGate();
    }
}
