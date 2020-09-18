using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace Commons.Client
{
    public abstract class ClientScript : BaseScript
    {
        public static Player ClientPlayer
        {
            get
            {
                return Game.Player;
            }
        }

        public static Ped ClientPed
        {
            get
            {
                return Game.PlayerPed;
            }
        }

        public object ClientCharacter
        {
            get
            {
                return base.Exports["GetCurrentCharacter"];
            }
        }

        public static Vehicle ClientCurrentVehicle
        {
            get
            {
                Ped clientPed = ClientScript.ClientPed;
                if (clientPed == null)
                {
                    return null;
                }
                return clientPed.CurrentVehicle;
            }
        }

        public static Vehicle ClientLastVehicle
        {
            get
            {
                Ped clientPed = ClientScript.ClientPed;
                if (clientPed == null)
                {
                    return null;
                }
                return clientPed.LastVehicle;
            }
        }

        public static Vehicle GetClosestVehicleToClient(float limitRadius = 2f)
        {
            return ClientScript.ClientPed.GetClosestVehicleToPed(limitRadius);
        }

        public static void SetNetworkIdNetworked(int netId, bool canMigrate = false)
        {
            API.SetNetworkIdExistsOnAllMachines(netId, true);
            API.SetNetworkIdCanMigrate(netId, canMigrate);
            if (!canMigrate)
            {
                API.NetworkSetNetworkIdDynamic(netId, true);
            }
        }

        public static bool IsOnScreenKeyboardActive()
        {
            return API.UpdateOnscreenKeyboard() == 3;
        }

        public static async void PlayManagedSoundFrontend(string soundName, string soundSet  = null)
        {
            int soundId = Audio.PlaySoundFrontend(soundName, soundSet);
            while (!Audio.HasSoundFinished(soundId))
            {
                await BaseScript.Delay(200);
            }
            Audio.ReleaseSound(soundId);
        }

        public static class Hud
        {
            public static void DrawText2D(float x, float y, float scale, string text, int r, int g, int b, int a)
            {
                Minimap anchor = MinimapAnchor.GetMinimapAnchor();
                x = anchor.X + anchor.Width * x;
                y = anchor.T - y;
                API.SetTextFont(4);
                API.SetTextProportional(false);
                API.SetTextScale(scale, scale);
                API.SetTextColour(r, g, b, a);
                API.SetTextDropShadow(0, 0, 0, 255);
                API.SetTextEdge(2, 0, 0, 0, 255);
                API.SetTextOutline();
                API.SetTextEntry("STRING");
                API.AddTextComponentString(text);
                API.DrawText(screenX, screenY);
                if (drawBackground)
                {
                    API.DrawRect(screenX, screenY + 0.0125f, (float)text.Length / 300f, 0.03f, 41, 11, 41, 68);
                }
            }

            public static void DrawImageNotification(string picture, int icon, string title, string subtitle, string message)
            {
                API.SetNotificationTextEntry("STRING");
                API.AddTextComponentString(message);
                API.SetNotificationMessage(picture, picture, true, icon, title, subtitle);
            }

            public static void DisplayChatMessage(string text)
            {
                BaseScript.TriggerEvent("chat:addMessage", new object[]
                {
                    text
                });
            }
        }
    }
}
