using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

    private int MaxHealth;
    private int Health;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetMaxHealth(int NewMaxHealth)
    {
        MaxHealth = NewMaxHealth;
        Health = MaxHealth;
    }



    public void TakeGeneralDamage(int DamageToTake)
    {
        Health -= DamageToTake;
        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        BaseEnemyScript EnemyScript = gameObject.GetComponent<BaseEnemyScript>();
        if (EnemyScript != null)
        {
            Debug.Log("Give experience to the most recent attacker");
            EnemyScript.Die();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
