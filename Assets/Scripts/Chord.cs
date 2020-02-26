using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Chord : ScriptableObject
{
	public List<Note> notes;
	public Phrase phrase;
	public Song song;


	public void Check(Note note)
	{
		foreach (Note n in notes)
		{
			if (!n.played)
				return;
		}

		// Chord is played
		Destroy(notes[1].transform.parent.gameObject);
	}
}
