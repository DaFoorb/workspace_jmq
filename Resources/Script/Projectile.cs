using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	GameObject go_player ;
	float m_fVelocity ; // Vitesse de déplacement
	float m_fLifeTime ; // Temps de vie
	bool m_bIsDead ; // Etat mort
	int m_iDamage ; //Dégat infligé


	void Start () {
		go_player= GameObject.FindGameObjectWithTag ("Player") ;
		transform.position= new Vector3 (go_player.transform.position.x,
											go_player.transform.position.y + 2.5f,
											-10) ;
		m_iDamage= 15 ; 
		m_fVelocity= 10 ;
		m_fLifeTime= 20.0f ;
		m_bIsDead= false ;

	}

	void Update () 
	{
		if(!getIsDead()) // On regarde si l'objet est en état mort
		{
			updateLifeTime() ; // On décrémente le temps de vie.
			Move (); // On fait bouger l'objet.
		}
		else
			destroyObject()
	}


	/*** Setter ***/

	public void setIsDead (bool p_b_isDead)
	{
		m_bIsDead= p_b_isDead;
	}

	/*** Getter ***/

	public bool getIsDead ()
	{
		return m_bIsDead ;
	}

	public int getDegats ()
	{
		return m_iDamage;
	}


	/*** Members functions ***/

	// Destroying the current object
	private void destroyObject () 
	{
		Destroy (gameObject);	
	}

	// Updating the lifetime and update the m_bIsDead member variable if the lifetime =< 0.
	private void updateLifeTime()
	{
		m_fLifeTime-= Time.deltaTime ;

		if(0 >= m_fLifeTime)
			setIsDead(true) ;
	}

	// Moving the object
	void Move ()
	{
		transform.position= new Vector3 (transform.position.x + Time.deltaTime*m_fVelocity,
										 transform.position.y,
										 -10) ;
	}
}
