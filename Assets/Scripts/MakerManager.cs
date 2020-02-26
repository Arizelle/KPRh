using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakerManager : MonoBehaviour
{
	Song song;
	Dictionary<KeyCode, bool> pressed = new Dictionary<KeyCode, bool>();
	public KeyCode[] noteInputs = {
		KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6, KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9, KeyCode.Alpha0,
		KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R, KeyCode.T, KeyCode.Y, KeyCode.U, KeyCode.I, KeyCode.O, KeyCode.P,
		KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.J, KeyCode.K, KeyCode.L,
		KeyCode.Z, KeyCode.X, KeyCode.C, KeyCode.V, KeyCode.B, KeyCode.N, KeyCode.M, KeyCode.Comma
	};


	void Update()
	{
		// NOTE INPUTS \\
		foreach (KeyCode key in noteInputs)
		{
			// Key was pressed...
			if (pressed[key])
			{
				// ... but is not anymore
				if (!Input.GetKey(key))
				{
					pressed[key] = false;
				}
			}
		}
	}
}
