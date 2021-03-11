using System;

namespace NewPlugin
{
    internal class Script : MVRScript
    {
        private Log log = new Log(nameof(Script));
        private const string version = "<Version>";

        public override void Init()
        {
            try
            {
            }
            catch(Exception e)
            {
                log.Error($"{e}");
            }
        }

        public void OnEnable()
        {
            try
            {
            }
            catch(Exception e)
            {
                log.Error($"{e}");
            }
        }

        //public void FixedUpdate()
        //{
        //    try
        //    {
        //    }
        //    catch(Exception e)
        //    {
        //        log.Error($"{e}");
        //    }
        //}

        //public void Update()
        //{
        //    try
        //    {
        //    }
        //    catch(Exception e)
        //    {
        //        log.Error($"{e}");
        //    }
        //}

        public void OnDisable()
        {
            try
            {
            }
            catch(Exception e)
            {
                log.Error($"{e}");
            }
        }

        public void OnDestroy()
        {
            try
            {
            }
            catch(Exception e)
            {
                log.Error($"{e}");
            }
        }
    }
}
