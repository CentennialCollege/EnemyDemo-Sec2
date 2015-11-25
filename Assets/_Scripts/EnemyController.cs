using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public Transform target;
	public float speed;


	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private float _distanceFromTarget;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		 this._distanceFromTarget = Vector3.Distance(this._transform.position, this.target.position);
		if (this._distanceFromTarget < 10) {
			// move towards the target
			this._transform.position = Vector3.MoveTowards(this._transform.position, target.position, this.speed);

			// look at the target
			Vector3 targetDir = this.target.position - this._transform.position;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, this.speed, 0.0F);
			this._transform.rotation = Quaternion.LookRotation(newDir);
		}
	}
}
