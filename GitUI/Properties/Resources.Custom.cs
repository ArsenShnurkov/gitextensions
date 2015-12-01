﻿namespace GitUI.Properties
{
    /// <remarks>
    /// DESIGNER USAGE INFO!
    ///
    /// This partial class helps to modify the Resources.resx using the designer AND having some custom
    /// code inside the designer generated Resources class.
    /// The only thing to do whenever the Designer is used is to add the partial class modifier in Resources.Designer.cs
    /// which is not generated by the designer code generator.
    ///
    /// As soon as the preprocessor if statements are no longer necessary this class can / should be removed.
    /// </remarks>
    internal partial class Resources
    {
        public static System.Drawing.Bitmap loadingpanel
        {
            get
            {
                if(GitCommands.Utils.EnvUtils.IsMonoRuntime())
                    return loadingpanel_static;
                else
                    return loadingpanel_animated;

            }
        }
    }
}
