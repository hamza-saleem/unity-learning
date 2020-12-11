using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PickUpGun : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;

    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject AmmoDisplay;
    public AudioSource PickUpAudio;
    

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        
        
    }
    void OnMouseOver()
    {
        if(TheDistance<=2)
        {
            TextDisplay.GetComponent<Text>().text = "Pick Up";
        }
        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 2)
            {
                StartCoroutine(PickUp9mm());
            }
        }
    }
    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text="Pick Up";
    }

    IEnumerator PickUp9mm()
    {
        PickUpAudio.Play();
        transform.position = new Vector3(0,-1000,0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        AmmoDisplay.SetActive(true);
        yield return new WaitForSeconds(0.1f);
    }


}
