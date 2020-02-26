using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phrase : ScriptableObject
{
	public List<Note> notes;
	public List<Chord> chords;
	public Song song;
	public float beatStart;
	public float beatEnd;


}
