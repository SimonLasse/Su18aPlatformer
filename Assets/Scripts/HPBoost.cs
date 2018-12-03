using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBoost : MonoBehaviour {
    private PlayerHealth PH;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player");
        {
            GameObject controller = GameObject.FindWithTag("Player");
            if (controller != null)
            {
                PlayerHealth tracker = controller.GetComponent<PlayerHealth>();
                if (tracker != null)
                {
                    tracker.DealDamage(-25);

                }
                else
                {
                    Debug.LogError("");
                }
            }
                else
                {
                    Debug.LogError("");
                }
            Destroy(gameObject);
        }

    }
}
