using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
	public KeyCode key;
	//[SerializeField] static PlayManager gm;
	public bool played = false;

	public float beat;
	//public int noteIndex;
	public Chord chord;
	public Phrase phrase;


	void Update()
	{
		NoteInfo test = this.info();
		transform.Translate(Vector3.back * PlayManager.notespeed * Time.deltaTime);
	}


	public NoteInfo info()
	{
		Color _color = Color.white;
		float _height = -1;
		float _leftmost = 0;
		int x = 0;

		switch (key)
		{
			// Green
			case (KeyCode.Alpha1):
				_color = Color.green;
				_height = 3;
				break;
			case (KeyCode.Alpha2):
				_color = Color.green;
				_height = 3;
				x = 1;
				break;
			case (KeyCode.Alpha3):
				_color = Color.green;
				_height = 3;
				x = 2;
				break;
			case (KeyCode.Alpha4):
				_color = Color.green;
				_height = 3;
				x = 3;
				break;
			case (KeyCode.Alpha5):
				_color = Color.green;
				_height = 3;
				x = 4;
				break;
			case (KeyCode.Alpha6):
				_color = Color.green;
				_height = 3;
				x = 5;
				break;
			case (KeyCode.Alpha7):
				_color = Color.green;
				_height = 3;
				x = 6;
				break;
			case (KeyCode.Alpha8):
				_color = Color.green;
				_height = 3;
				x = 7;
				break;
			case (KeyCode.Alpha9):
				_color = Color.green;
				_height = 3;
				x = 8;
				break;
			case (KeyCode.Alpha0):
				_color = Color.green;
				_height = 3;
				x = 9;
				break;
			
			// Yellow
			case (KeyCode.Q):
				_color = Color.yellow;
				_height = 2;
				break;
			case (KeyCode.W):
				_color = Color.yellow;
				_height = 2;
				x = 1;
				break;
			case (KeyCode.E):
				_color = Color.yellow;
				_height = 2;
				x = 2;
				break;
			case (KeyCode.R):
				_color = Color.yellow;
				_height = 2;
				x = 3;
				break;
			case (KeyCode.T):
				_color = Color.yellow;
				_height = 2;
				x = 4;
				break;
			case (KeyCode.Y):
				_color = Color.yellow;
				_height = 2;
				x = 5;
				break;
			case (KeyCode.U):
				_color = Color.yellow;
				_height = 2;
				x = 6;
				break;
			case (KeyCode.I):
				_color = Color.yellow;
				_height = 2;
				x = 7;
				break;
			case (KeyCode.O):
				_color = Color.yellow;
				_height = 2;
				x = 8;
				break;
			case (KeyCode.P):
				_color = Color.yellow;
				_height = 2;
				x = 9;
				break;

			// Blue
			case (KeyCode.A):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				break;
			case (KeyCode.S):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 1;
				break;
			case (KeyCode.D):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 2;
				break;
			case (KeyCode.F):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 3;
				break;
			case (KeyCode.G):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 4;
				break;
			case (KeyCode.H):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 5;
				break;
			case (KeyCode.J):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 6;
				break;
			case (KeyCode.K):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 7;
				break;
			case (KeyCode.L):
				_color = new Color (0, .7342f, 1, 1);
				_height = 1;
				x = 8;
				break;
			
			// Red
			case (KeyCode.Z):
				_color = Color.red;
				_height = 0;
				break;
			case (KeyCode.X):
				_color = Color.red;
				_height = 0;
				x = 1;
				break;
			case (KeyCode.C):
				_color = Color.red;
				_height = 0;
				x = 2;
				break;
			case (KeyCode.V):
				_color = Color.red;
				_height = 0;
				x = 3;
				break;
			case (KeyCode.B):
				_color = Color.red;
				_height = 0;
				x = 4;
				break;
			case (KeyCode.N):
				_color = Color.red;
				_height = 0;
				x = 5;
				break;
			case (KeyCode.M):
				_color = Color.red;
				_height = 0;
				x = 6;
				break;
			case (KeyCode.Comma):
				_color = Color.red;
				_height = 0;
				x = 7;
				break;

			default:
				print ("Invalid key");
				break;
		}

		_leftmost = PlayManager.Leftmost(_height);
		return new NoteInfo(_color, new Vector2(_leftmost + x, _height));
	}
}
