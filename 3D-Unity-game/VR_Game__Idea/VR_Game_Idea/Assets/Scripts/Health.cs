using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "PlayerTron"){
            FindObjectOfType<AudioManager>().PlaySound("HealthRecharge");
            PlayerManager.health += 50f;
            Destroy(gameObject);
        }
    }
}
