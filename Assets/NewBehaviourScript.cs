using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float runspeed = 10f;
    Vector2 moveInput;
    Rigidbody2D myRidgidbody;
     //Start is called before the first frame update
    void Start()
    {
        myRidgidbody = GetComponent<Rigidbody2D>();
        CapsuleCollider2D capsuleCollider;
   
    }

    //Update is called once per frame


    //void Update()
    {

      //  Run();
    }
}

      //Run();
    }

     //void OnMove(InputValue value)
    {
    //moveInput = value.Get<Vector2>();
    //Debug.Log(moveInput);
    }

void Run()
{
    //Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
    //myRigidbody.velocity = playerVelocity;
}
   void //Onjump(Inputvalue value)
         //if (!myCapulecollider.IsTouchingLayers(LayerMask.GetMask("Ground"))) { return; }
         ////////////////////////if (KeyValuePair.ispassed)
         void Climbladder() 
         {
          Vector2 playerVelocity = new Vector2(moveIuput.x * runSpeed, myRigidbody.velocity.y);
    //myRigidbody.velocity = playerVelocity;


          MyAnimator.SetBool("Climbing", true);
         }








