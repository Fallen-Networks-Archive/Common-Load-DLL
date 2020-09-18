using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace Fnrp.Fivem.Common.Client
{
	public class Controls : BaseScript
	{
		public static bool IsKeyJustPressed(Controls.Keys k, int inputGroup = 0)
		{
			return Game.IsControlJustPressed(inputGroup, k) && Game.CurrentInputMode == null && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsKeyJustPressed(int k, int inputGroup = 0)
		{
			return Game.IsControlJustPressed(inputGroup, k) && Game.CurrentInputMode == null && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsKeyPressed(Controls.Keys k, int inputGroup = 0)
		{
			return Game.IsControlPressed(inputGroup, k) && Game.CurrentInputMode == null && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsKeyPressed(int k, int inputGroup = 0)
		{
			return Game.IsControlPressed(inputGroup, k) && Game.CurrentInputMode == null && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsKeyJustPressedRegardless(Controls.Keys k, int inputGroup = 0)
		{
			return Controls.IsControlJustPressedRegardless(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsDisabledKeyJustPressed(Controls.Keys k, int inputGroup = 0)
		{
			return Controls.IsDisabledControlJustPressed(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsKeyPressedRegardless(Controls.Keys k, int inputGroup = 0)
		{
			return Controls.IsControlPressedRegardless(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsDisabledKeyPressed(Controls.Keys k, int inputGroup = 0)
		{
			return Controls.IsDisabledControlPressed(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsKeyJustPressedRegardless(int k, int inputGroup = 0)
		{
			return Controls.IsControlJustPressedRegardless(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsKeyPressedRegardless(int k, int inputGroup = 0)
		{
			return Controls.IsControlPressedRegardless(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsDisabledKeyJustPressed(int k, int inputGroup = 0)
		{
			return Controls.IsDisabledControlJustPressed(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsDisabledKeyPressed(int k, int inputGroup = 0)
		{
			return Controls.IsDisabledControlPressed(k, inputGroup) && Game.CurrentInputMode == 0;
		}

		public static bool IsControlJustPressedRegardless(Control c, int inputGroup = 0)
		{
			return (Game.IsControlJustPressed(inputGroup, c) || Game.IsDisabledControlJustPressed(inputGroup, c)) && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsDisabledControlJustPressed(Control c, int inputGroup = 0)
		{
			return Game.IsDisabledControlJustPressed(inputGroup, c) && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsControlPressedRegardless(Control c, int inputGroup = 0)
		{
			return (Game.IsControlPressed(inputGroup, c) || Game.IsDisabledControlPressed(inputGroup, c)) && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsDisabledControlPressed(Control c, int inputGroup = 0)
		{
			return Game.IsDisabledControlPressed(inputGroup, c) && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsControlJustPressed(Control c, int inputGroup = 0)
		{
			return (Game.IsControlJustPressed(inputGroup, c) || Game.IsDisabledControlJustPressed(inputGroup, c)) && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsControlPressed(Control c, int inputGroup = 0)
		{
			return Game.IsControlPressed(inputGroup, c) && API.UpdateOnscreenKeyboard() != 0;
		}

		public static bool IsButtonJustPressed(Controls.Buttons b, int inputGroup = 0)
		{
			return Game.IsControlJustPressed(inputGroup, b) && Game.CurrentInputMode == 1;
		}

		public static bool IsButtonJustPressed(int b, int inputGroup = 0)
		{
			return Game.IsControlJustPressed(inputGroup, b) && Game.CurrentInputMode == 1;
		}

		public static bool IsButtonPressed(Controls.Buttons b, int inputGroup = 0)
		{
			return Game.IsControlPressed(inputGroup, b) && Game.CurrentInputMode == 1;
		}

		public static bool IsButtonPressed(int b, int inputGroup = 0)
		{
			return Game.IsControlPressed(inputGroup, b) && Game.CurrentInputMode == 1;
		}

		public static bool IsButtonJustPressedRegardless(Controls.Buttons b, int inputGroup = 0)
		{
			return Controls.IsControlJustPressedRegardless(b, inputGroup) && Game.CurrentInputMode == 1;
		}

		public static bool IsDisabledButtonJustPressed(Controls.Buttons b, int inputGroup = 0)
		{
			return Controls.IsDisabledControlJustPressed(b, inputGroup) && Game.CurrentInputMode == 1;
		}

		public static bool IsButtonPressedRegardless(Controls.Buttons b, int inputGroup = 0)
		{
			return Controls.IsControlPressedRegardless(b, inputGroup) && Game.CurrentInputMode == 1;
		}

		public static bool IsDisabledButtonPressed(Controls.Buttons b, int inputGroup = 0)
		{
			return Controls.IsDisabledControlPressed(b, inputGroup) && Game.CurrentInputMode == 1;
		}

		public static bool IsButtonJustPressedRegardless(int b, int inputGroup = 0)
		{
			return Controls.IsControlJustPressedRegardless(b, inputGroup) && Game.CurrentInputMode == 1;
		}

		public static bool IsDisabledButtonPressed(int b, int inputGroup = 0)
		{
			return Controls.IsDisabledControlPressed(b, inputGroup) && Game.CurrentInputMode == 1;
		}

		public static bool IsDisabledButtonRegardless(Controls.Buttons b, int inputGroup = 0)
		{
			return Controls.IsDisabledControlPressed(b, inputGroup) && Game.CurrentInputMode == 1;
		}

		public enum Keys
		{
			ESC = 322,
			F1 = 288,
			F2,
			F3 = 170,
			F5 = 166,
			F6,
			F7,
			F8,
			F9 = 56,
			F10,
			TILDE = 243,
			ONE = 157,
			TWO,
			THREE = 160,
			FOUR = 164,
			FIVE,
			SIX = 159,
			SEVEN = 161,
			EIGHT,
			NINE,
			MINUS = 84,
			EQUAL = 83,
			BACKSPACE = 177,
			TAB = 37,
			Q = 44,
			W = 32,
			E = 38,
			R = 45,
			T = 245,
			Y,
			U = 303,
			P = 199,
			OPENBRACKET = 39,
			CLOSEBRACKET,
			ENTER = 18,
			CAPS = 137,
			A = 34,
			S = 8,
			D,
			F = 23,
			G = 47,
			H = 74,
			K = 311,
			L = 182,
			LEFTSHIFT = 21,
			Z = 20,
			X = 73,
			C = 26,
			V = 0,
			B = 29,
			N = 249,
			M = 244,
			COMMA = 82,
			PERIOD = 81,
			LEFTCTRL = 36,
			LEFTALT = 19,
			SPACE = 22,
			RIGHTCTRL = 70,
			HOME = 213,
			PAGEUP = 316,
			PAGEDOWN,
			DELETE = 178,
			LEFT = 174,
			RIGHT,
			TOP = 27,
			DOWN = 173,
			NENTER = 201,
			N4 = 108,
			N5 = 60,
			N6 = 107,
			NADD = 96,
			NMINUS,
			N7 = 117,
			N8 = 61,
			N9 = 118
		}

		public enum Buttons
		{
			XBoxA = 191,
			XBoxB = 194,
			XBoxY = 192,
			XBoxX,
			DpadLeft = 189,
			DpadRight,
			DpadUp = 188,
			DpadDown = 187,
			RT = 228,
			LT,
			LB = 226,
			RB,
			L3 = 230,
			R3,
			SELECT,
			PAUSE = 199,
			PsX = 191,
			PsCircle = 194,
			PsSquare = 193,
			PsTriangle = 192,
			L2 = 226,
			R2
		}

		public enum InputGroups
		{
			UNK = -1,
			MOVE,
			LOOK,
			WHEEL,
			CELLPHONE_NAVIGATE,
			CELLPHONE_NAVIGATE_UD,
			CELLPHONE_NAVIGATE_LR,
			FRONTEND_DPAD_ALL,
			FRONTEND_DPAD_UD,
			FRONTEND_DPAD_LR,
			FRONTEND_LSTICK_ALL,
			FRONTEND_RSTICK_ALL,
			FRONTEND_GENERIC_UD,
			FRONTEND_GENERIC_LR,
			FRONTEND_GENERIC_ALL,
			FRONTEND_BUMPERS,
			FRONTEND_TRIGGERS,
			FRONTEND_STICKS,
			SCRIPT_DPAD_ALL,
			SCRIPT_DPAD_UD,
			SCRIPT_DPAD_LR,
			SCRIPT_LSTICK_ALL,
			SCRIPT_RSTICK_ALL,
			SCRIPT_BUMPERS,
			SCRIPT_TRIGGERS,
			WEAPON_WHEEL_CYCLE,
			FLY,
			SUB,
			VEH_MOVE_ALL,
			CURSOR,
			CURSOR_SCROLL,
			SNIPER_ZOOM_SECONDARY,
			VEH_HYDRAULICS_CONTROL
		}
	}
}
