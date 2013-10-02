using UnityEngine;
using System.Collections;

public class clamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate(Vector3.up * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(Vector3.down * Time.deltaTime);
		}
	
		Vector3 pos = this.transform.position;
		pos.y = Mathf.Clamp(pos.y, -1, 1);
		this.transform.position = pos;
	}
}
