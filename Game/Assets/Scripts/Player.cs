using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
   
    [SerializeField] public float moveSpeed = 9f;


    private void Update() {

        Vector2 inputVector = new Vector2(0, 0);
        

        if (Input.GetKey(KeyCode.W)) 
            inputVector.y = +1;
        
        if (Input.GetKey(KeyCode.A))
            inputVector.x = -1;

        if (Input.GetKey(KeyCode.S))
            inputVector.y = -1;

        if (Input.GetKey(KeyCode.D))
            inputVector.x = 1;


        Vector3 controlVector = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += controlVector * Time.deltaTime * moveSpeed;

        rotationSpeed = 10f;

        transform.forward = Vector3.Slerp(transform.forwars, controlVector, time.deltaTime * rotationSpeed);

        Debug.Log(Time.deltaTime);



    }


}