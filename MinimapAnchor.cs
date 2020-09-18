using System;
using CitizenFX.Core.Native;

namespace Commons.Client
{
    public class MinimapAnchor : ClientScript
    {
        public static Minimap GetMinimapAnchor()
        {
            float SafezoneScale = API.GetSafeZoneSize();
            float SafezoneX = 0.05f;
            float SafezoneY = 0.05f;
            float AspectRatio = API.GetAspectRatio(false);
            if (AspectRatio > 2f)
            {
                AspectRatio = 1.77777779f;
            }
            int ResolutionX = 1920;
            int ResolutionY = 1080;
            API.GetActiveScreenResolution(ref ResolutionX, ref ResolutionY);
            float ScaleX = 1f / (float)ResolutionX;
            float ScaleY = 1f / (float)ResolutionY;
            Minimap anchor = new Minimap
            {
                Width = ScaleX * ((float)ResolutionX / (4f * AspectRatio)),
                Height = ScaleY * ((float)ResolutionY / 5.674f),
                LeftX = ScaleX * ((float)ResolutionX * (SafezoneX * (Math.Abs(SafezoneScale - 1f) * 10f)))
            };
            if (AspectRatio > 2f)
            {
                anchor.LeftX += anchor.Width * 0.2225f;
                anchor.Width *= 0.995f;
            }
            else if (AspectRatio > 1.8f)
            {
                anchor.LeftX += anchor.Width * 0.2225f;
                anchor.Width *= 0.995f;
            }
            anchor.BottomY = 1f - ScaleY * ((float)ResolutionY * (SafezoneY * (Math.Abs(SafezoneScale - 1f) * 10f)));
            anchor.RightX = anchor.LeftX + anchor.Width;
            anchor.TopY = anchor.BottomY - anchor.Height;
            anchor.X = anchor.LeftX;
            anchor.Y = anchor.TopY;
            anchor.UnitX = ScaleX;
            anchor.UnitY = ScaleY;
            return anchor;
        }
    }
}
