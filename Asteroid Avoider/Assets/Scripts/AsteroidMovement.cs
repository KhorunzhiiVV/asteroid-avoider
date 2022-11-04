using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();


        if (playerHealth == null)
		{
            return;
		}

        playerHealth.Crash();
	}

	private void OnBecameInvisible()
	{
        Destroy(gameObject);
	}

}
