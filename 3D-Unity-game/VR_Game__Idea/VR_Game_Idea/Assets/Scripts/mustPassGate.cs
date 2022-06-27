using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mustPassGate : MonoBehaviour
{
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag == "gate");
        Debug.Log(!playerController.isGatePassed);
        if(other.gameObject.tag == "gate" && !playerController.isGatePassed){
            PlayerManager.gameOver = true;
            Debug.Log("GAME OVER due to GATE");
        }
    }
}
