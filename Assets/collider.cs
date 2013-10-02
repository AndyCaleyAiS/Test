using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {
	
	public int speed = 3;
	
	// Use this for initialization
	void Start () {
	
		Vector3 pos = new Vector3(1,3,5);
		Vector3 pos2 = new Vector3(2,6,1);
		
		Vector3 output = pos * 4;
		
		float angle = Vector3.Angle(pos2 - pos, Vector3.right);
		Debug.Log(angle);
		
		Debug.Log (Vector3.ClampMagnitude(new Vector3(2,1,4), 2));
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
	
	void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("Collided");
		speed = -speed;		
		
		float angle = Vector3.Angle(this.transform.forward,  collider.transform.position - this.transform.position);
		Debug.Log ("Angle: " + angle);
		Debug.Log ("Distance: " + Vector3.Distance(this.transform.position, collider.transform.position));
	}
}
