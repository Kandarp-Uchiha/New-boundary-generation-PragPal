using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;
    private int desiredLane = 1;
    public float laneDistance = 4;
    public float jumpForce;
    public float Gravity = -20;


    void Start()
    {
        controller = GetComponent<CharacterController>();    
    }

    void Update()
    {
        direction.z = forwardSpeed;

        if(controller.isGrounded){
            direction.y = -1;
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                Jump();
            }
        }
        else{
            direction.y += Gravity*Time.deltaTime;
        }

        

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            desiredLane++;
            if(desiredLane == 3){
                desiredLane = 2;
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            desiredLane--;
            if(desiredLane == -1){
                desiredLane = 0;
            }
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if(desiredLane == 0){
            targetPosition += Vector3.left * laneDistance; 
        }
        else if(desiredLane == 2){
            targetPosition += Vector3.right * laneDistance;
        }

        // transform.position = Vector3.Lerp(transform.position,targetPosition,80*Time.fixedDeltaTime);
        // controller.center = controller.center; //JUGAAD: makes collision work properly
        if(transform.position == targetPosition){
            return;
        }
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
        if(moveDir.sqrMagnitude < diff.sqrMagnitude){
            controller.Move(moveDir);
        }
        else{
            controller.Move(diff);
        }

    }

    private void FixedUpdate() {
        controller.Move(direction*Time.fixedDeltaTime);
    }

    private void Jump(){
        direction.y = jumpForce;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) // collision detector for obstacle
    {
        if(hit.transform.tag == "Obstacle")
        {
            Debug.Log("GAME OVER due to OBSTACLE");
        }    
        // else if(hit.transform.tag == "Gate")
        // {
        //     Debug.Log(GetComponent<MeshRenderer>().material);
        //     Debug.Log(hit.gameObject.GetComponentInChildren<MeshRenderer>().material);

        //     if(GetComponent<MeshRenderer>().material != hit.gameObject.GetComponentInChildren<MeshRenderer>().material)
        //     {
        //         // Debug.Log("GAME OVER");
        //     }
        // }
    }

    private void OnTriggerEnter(Collider other) // trigger detection for gate
    {
        if(other.gameObject.tag == "Gate")
        {
            if(GetComponent<Renderer>().sharedMaterial != other.gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterial) // .material doesn't work, it doesn,t comapre instances of material, so .sharedMaterial is used
            {
                Debug.Log(GetComponent<Renderer>().sharedMaterial);
                Debug.Log(other.gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterial);
                Debug.Log("GAME OVER due to GATE");
            }
        }   
    }

    


 




}
