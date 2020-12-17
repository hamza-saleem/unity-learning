using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour
{
    public int DamageAmount = 5;
 public float TargetDistance;
 public float AllowedRange = 15.0f;

 public RaycastHit hit;
 public GameObject TheBullet;
 public GameObject clone;


  void Update () {
 if(GlobalAmmo.LoadedAmmo >= 1){     
  if(Input.GetButtonDown("Fire1")) {
     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
   RaycastHit Shot;
   if(Physics.Raycast(ray, out Shot)) {
       Debug.Log(Shot.point);
   }
   if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot)) {
    TargetDistance = Shot.distance;
    if (TargetDistance < AllowedRange) {
     Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
     if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
     {
        if (hit.transform.tag != "Zombie")
{
    clone = Instantiate(TheBullet, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
    clone.transform.SetParent(hit.transform);
}

    }
    }
   }
  }
 }
}
}

