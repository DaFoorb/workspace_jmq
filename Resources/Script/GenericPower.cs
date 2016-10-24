using UnityEngine;
using System.Collections;

public class GenericPower {

	int m_iIdPower ;
	string m_szPowerName ;
	int m_iDamage ;

	/*** Constructor ***/
	public GenericPower () {
		// To be erased		
		m_iIdPower= -1 ;
		m_szPowerName= "Generic Power" ;
		m_iDamage= 10 ;
	}
	
	public GenericPower (int p_iIdPower, 
						 string p_stPowerName, 
						 int p_iPowerDamage) {

		m_iIdPower= p_iIdPower ;
		m_szPowerName= p_stPowerName ;
		m_iDamage= p_iPowerDamage ;
	}


	/*** Destructor ***/

	private destroyObject()
	{
		Destroy (gameObject) ;
	}

	/*** Getter ***/

	public int getIdPower()
	{
		return m_iDamage ;
	}
}
