using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetExperienceReward() //redo this later...
    {
        return 0;
    }

    public void Die()
    {
        Debug.Log("Make enemy deahts do things!");
        Destroy(gameObject);
    }
}
