using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strummer : MonoBehaviour
{
	List<Note> activeNotes = new List<Note>();


	void OnTriggerEnter(Collider other)
	{
		activeNotes.Add(other.gameObject.GetComponent<Note>());
	}

	void OnTriggerExit(Collider other)
	{
		if (!other.gameObject.GetComponent<Note>().played)
		{
			// miss
			Destroy(other.gameObject);
		}
	}


	void Update()
	{
		List<KeyCode> pressed = new List<KeyCode>();
		foreach (Note n in activeNotes)
		{
			if (Input.GetKeyDown(n.key))
			{
				if (!pressed.Contains(n.key))
				{
					pressed.Add(n.key);
					n.played = true;
					// hit
					if (!n.chord)
						Destroy(n.gameObject);
				}
			}
		}
	}
}
