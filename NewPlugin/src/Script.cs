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
                TitleUITextField();
            }
            catch(Exception e)
            {
                Log.Error($"{e}");
            }
        }

        private void TitleUITextField()
        {
            JSONStorableString storable = new JSONStorableString("title", "");
            UIDynamicTextField field = CreateTextField(storable);
            field.UItext.fontSize = 36;
            field.height = 100;
            storable.val = $"<b>{nameof(NewPlugin)}</b>\n<size=28>v{version}</size>";
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
