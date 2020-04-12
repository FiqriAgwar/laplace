using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float terminalForwardSpeed;
    public float terminalBackwardSpeed;
    public float acceleration;
    public float decceleration;
    public float friction;

    private float currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = 0f;
        terminalBackwardSpeed = -terminalBackwardSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Accelerate") > 0){
            currentSpeed += acceleration;
            if(currentSpeed >= terminalForwardSpeed){
                currentSpeed = terminalForwardSpeed;
            }
        }
        else if(Input.GetAxisRaw("Accelerate") < 0){
            currentSpeed -= decceleration;
            if(currentSpeed <= terminalBackwardSpeed){
                currentSpeed = terminalBackwardSpeed;
            }
        }
        else{
            currentSpeed -= friction;
            if(currentSpeed <= 0){
                currentSpeed = 0;
            }
        }

        Debug.Log(currentSpeed);

        transform.Translate(0, 0, currentSpeed * Time.deltaTime);
        
    }
}
