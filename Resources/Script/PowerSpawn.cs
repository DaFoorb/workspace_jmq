using UnityEngine;
using System.Collections;

public class PowerSpawn : MonoBehaviour {

	static int m_iIdPower ;

	// Use this for initialization
	void Start () {}

	// Update is called once per frame
	void Update () {}

	/*** Getter ***/

	// Gets the power identifier.
	public int getIdPower () 
	{
		return m_iIdPower;
	}


	/*** Setter ***/
	
	public void setIdPower(int p_i_idPower) 
	{
		m_iIdPower = p_i_idPower ;
	}


	/*** Members functions ***/ 

	private void OnCollisionEnter(Collision collisionInfo)
	{
		if ("Joueur" == collisionInfo.collider.name)
			destroyObject() ;
	}

	private void destroyObject()
	{
		Destroy (gameObject) ;
	}
}
