using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Vector3 startPos;
    private float min = -7f;
    private float max = 7f;
    public float timeLeft = 10f;
 
void Start() {
    startPos = transform.position;
}

void Update(){
     if(Input.GetKeyDown("b")){
        transform.position = startPos + new Vector3(Random.Range(min,max),0f,Random.Range(min,max)); 
    }
    transform.Translate(0.1f*Input.GetAxis("Horizontal"),0f,0.1f*Input.GetAxis("Vertical"));

    timeLeft -= Time.deltaTime;
     if ( timeLeft < 0 )
     {
         timeLeft = 10f;
         transform.position = startPos + new Vector3(Random.Range(min,max),0f,Random.Range(min,max));

     }
}

 
void OnCollisionEnter(Collision col){
    if (col.gameObject.name == "Em" || col.gameObject.name == "Lou")
    {
    	
       transform.position = startPos + new Vector3(Random.Range(min,max),0f,Random.Range(min,max)); 
       
    }
    
    }
}
