using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveWallpaper.Store.Models.Settngs
{
    public class GeneralSetting
    {
        public string WallpaperSaveDir { get; private set; } = @"%userprofile%\videos\LivewallpaperCache (因为UWP权限问题，本参数无法修改。更多高级功能请加qq群:641405255 ）";

        internal static GeneralSetting GetDefault()
        {
            return new GeneralSetting();
        }
    }
}
