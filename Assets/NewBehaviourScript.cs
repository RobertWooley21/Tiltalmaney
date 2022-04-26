using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float runspeed = 10f;
    Vector2 moveInput;
    Rigidbody2D myRidgidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRidgidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    void Update()
    {

        Run();
    }

    



    

    

    




    
    
    
    
  




}
