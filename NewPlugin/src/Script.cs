using System;

namespace NewPlugin
{
    public class Script : MVRScript
    {
        public override void Init()
        {
            try
            {
            }
            catch(Exception e)
            {
                Log.Error($"{e}");
            }
        }

        public void OnEnable()
        {
            try
            {
            }
            catch(Exception e)
            {
                Log.Error($"{e}");
            }
        }

        public void OnDisable()
        {
            try
            {
            }
            catch(Exception e)
            {
                Log.Error($"{e}");
            }
        }

        public void OnDestroy()
        {
            try
            {
            }
            catch(Exception e)
            {
                Log.Error($"{e}");
            }
        }
    }
}
