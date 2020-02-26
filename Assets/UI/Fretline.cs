using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Fretline : MonoBehaviour
{
	public Transform note;

	void Update()
	{
		if (note)
		{
			transform.position = new Vector3(
				note.position.x,
				(note.position.y / 2),
				note.position.z
			);

			transform.localScale = new Vector3(
				1,
				note.position.y / note.localScale.y,
				1
			);

			GetComponent<SpriteRenderer>().color = note.gameObject.GetComponent<Note>().info().color;
		}
	}
}
