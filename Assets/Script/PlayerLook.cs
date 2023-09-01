using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private Transform camer;
    private void Awake() {
        camer = transform.Find("Camera").GetComponent<Transform>();
    }
   private void Update() {
    
    Movement();
    LookAround();
   }
   private void Movement()
   {
    float inputX = Input.GetAxisRaw("Horizontal");
    float inputY = Input.GetAxisRaw("Vertical");
    Vector3 moveDir = new Vector3(inputX,0f,inputY).normalized;
    float moveSpeed = 20f;
    transform.position += moveDir*moveSpeed* Time.deltaTime;
   }
   private void LookAround()
   {
    float inputMouseX = Input.GetAxisRaw("Mouse X");
    float inputMouseY = Input.GetAxisRaw("Mouse Y");

    Vector2 mouseMovement = new Vector2(inputMouseY, inputMouseX);
    camer.Rotate(mouseMovement.x,mouseMovement.y,0f,Space.Self);
   }
}
