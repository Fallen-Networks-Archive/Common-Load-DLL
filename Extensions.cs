using System;
using System.Text;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace Commons.Client
{
    public static class Extensions
    {
        public static float CorrectHeading(this Entity e)
        {
            float hdg = 360f - e.Heading;
            if (hdg > 360f)
            {
                hdg -= 360f;
            }
            return hdg;
        }

        public static string[] GetStreetAndCrossAtEntityPosition(this Entity e)
        {
            return e.Position.GetStreetAndCrossAtCoords();
        }

        public static string GetStreetAndCrossWholeAtEntityPosition(this Entity e, string seperator)
        {
            return e.Position.GetStreetAndCrossWholeAtCoords(seperator);
        }

        public static async void Network(this Entity e, bool canMigrate = false)
        {
            if (!Entity.Exists(e))
            {
                Debug.WriteLine("Failed to network entity, entity does not exist!");
            }
            else
            {
                int start = Game.GameTime;
                while (!API.NetworkGetEntityIsNetworked(e.Handle) && Game.GameTime - start < 5000)
                {
                    API.NetworkRegisterEntityAsNetworked(e.Handle);
                    await BaseScript.Delay(100);
                }
                int netId = e.NetworkId;
                ClientScript.SetNetworkIdNetworked(netId, canMigrate);
                Debug.WriteLine(string.Format("Got network ID {0} from entity ID {1}", netId, e.Handle));
            }
        }

        public static float Speed(this Entity entity, string units = "mph")
        {
            if (units == "mph")
            {
                return API.GetEntitySpeed(entity.Handle) * 2.236936f;
            }
            if (!(units == "kmh"))
            {
                return 0f;
            }
            return API.GetEntitySpeed(entity.Handle) * 3.6f;
        }

        public static bool CannotDoAction(this Ped ped)
        {
            return API.DecorGetBool(ped.Handle, "IsDead") || ped.IsCuffed || ped.IsDead || ped.IsBeingStunned || ped.IsClimbing || ped.IsDiving || ped.IsFalling || ped.IsGettingIntoAVehicle || ped.IsJumping ||
            ped.IsJumpingOutOfVehicle || ped.IsRagdoll || ped.IsSwimmingUnderWater || ped.IsVaulting;
        }
    }
}
