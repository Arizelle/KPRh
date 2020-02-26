using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayManager
{
	public static float offsetGreen = -.43f;
	public static float offsetYellow = .21f;
	public static float offsetBlue = 0f;
	public static float offsetRed = 0f;

	public static float notespeed = 8f;


	public static float Leftmost(float _row)
	{
		switch (_row)
		{
			case (3):
				return offsetGreen - 4.5f;
			case (2):
				return offsetYellow - 4.5f;
			case (1):
				return offsetBlue - 4f;
			case (0):
				return offsetRed - 3.5f;
			default:
				Debug.Log ("Invalid RowOffset number");
				return 0;
		}
	}
}
