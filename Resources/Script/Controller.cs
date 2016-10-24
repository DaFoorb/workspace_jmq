using UnityEngine;
using System.Collections;




public class Controller : MonoBehaviour {

	public int i_vitesse ;

	void Update()
	{
		Move() ;
	}


	/*** Getter ***/

	public int getVitesse()
	{
		return i_vitesse;
	}


	/*** Fonction membres ***/

	void Move () {
		
		if (Input.GetKey("right"))
			this.transform.position= new Vector3 (this.transform.position.x + i_vitesse*Time.deltaTime, 
												  this.transform.position.y, 
												  this.transform.position.z);
		else if (Input.GetKey("left")) 
			this.transform.position= new Vector3 (this.transform.position.x - i_vitesse*Time.deltaTime, 
				this.transform.position.y, 
				this.transform.position.z);
	}
}

