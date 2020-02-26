using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Song")]
public class Song : ScriptableObject
{
	public string songName;
	float bpm;

	[SerializeField] List<Note> notes = new List<Note>();
	[SerializeField] List<Chord> chords = new List<Chord>();
	[SerializeField] List<Phrase> phrase = new List<Phrase>();


	void Spawn()
	{
	}
}
