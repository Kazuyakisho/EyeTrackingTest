using EyeTrackingMouseV03Lib.Helper;
using System;

namespace EyeTrackingMouseV03Lib.Settings
{
    public class ETSettings
    {


        private static readonly Lazy<ETSettings> _instance = new Lazy<ETSettings>(() => new ETSettings());

        public static ETSettings Instance
        {
            get
            {
                return _instance.Value;
            }


        }



        public ETSettingsEyeTracker EtSettingsEyes { get; } = new ETSettingsEyeTracker(EnumROI.BothEyes);
        public ETSettingsFace EtSettingsFace { get; } = new ETSettingsFace(EnumROI.Face);
        public ETSettingsNose EtSettingsNose { get; } = new ETSettingsNose(EnumROI.Nose);
        public ETSettingsVideo EtSettingsVideo { get; } = new ETSettingsVideo();



    }
}
