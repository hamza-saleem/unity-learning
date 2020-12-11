using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;



public class PlayerCasting : MonoBehaviour

{

    public static float DistanceFromTarget;

   public float ToTarget;

    



    // Update is called once per frame

    void Update()

    {

          RaycastHit hit;

       if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit))

       {

           ToTarget = hit.distance;

           DistanceFromTarget= ToTarget;

       } 

    }

}
