using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public struct NoteInfo
{
	public Color color;
	public Vector2 pos;

	public NoteInfo(Color _color, Vector2 _pos)
	{
		color = _color;
		pos = _pos;
	}
}


//	public static KeyCode[] noteInputs = {
//		KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6, KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9, KeyCode.Alpha0,
//		KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R, KeyCode.T, KeyCode.Y, KeyCode.U, KeyCode.I, KeyCode.O, KeyCode.P,
//		KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.J, KeyCode.K, KeyCode.L,
//		KeyCode.Z, KeyCode.X, KeyCode.C, KeyCode.V, KeyCode.B, KeyCode.N, KeyCode.M, KeyCode.Comma
//	};


//public struct Song
//{
//	List<Note> notes = new List<Note>();
//	List<int> chords = new list<int>(); // which indices
//	List<int> phrases = new List<int>();
//}


/*
public enum Note
{
	One,Two,Three,Four,Five,Six,Seven,Eight,Nine,Zero,
	Q,W,E,R,T,Y,U,I,O,P,
	A,S,D,F,G,H,J,K,L,
	Z,X,C,V,B,N,M,Comma
};


public static Color NoteColor(Note name)
{
	if ((int)name < 10)
		return Color.green;
	if ((int)name < 20)
		return Color.yellow;
	if ((int)name < 29)
		return Color.cyan;
	if ((int)name < 37)
		return Color.red;
	else 
		return Color.black;
}


public static float NoteHeight(Note name)
{
	if ((int)name < 10)
		return 3;
	if ((int)name < 20)
		return 2;
	if ((int)name < 29)
		return 1;
	if ((int)name < 37)
		return 0;
}*/