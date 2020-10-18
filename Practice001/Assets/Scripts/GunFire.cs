using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    void Update () {
  if(Input.GetButtonDown("Fire1")) {
   AudioSource gunsound  = GetComponent<AudioSource>();
   gunsound.Play();
   GetComponent<Animation>().Play("GunShot");
   GlobalAmmo.LoadedAmmo -= 1;
  }
 }
}
