using System;

namespace NewPlugin
{
    internal class Script : MVRScript
    {
        private const string version = "<Version>";

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

        //public void FixedUpdate()
        //{
        //    try
        //    {
        //    }
        //    catch(Exception e)
        //    {
        //        Log.Error($"{e}");
        //    }
        //}

        //public void Update()
        //{
        //    try
        //    {
        //    }
        //    catch(Exception e)
        //    {
        //        Log.Error($"{e}");
        //    }
        //}

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
