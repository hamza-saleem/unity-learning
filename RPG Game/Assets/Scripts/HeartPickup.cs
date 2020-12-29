﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPickup : MonoBehaviour
{

	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject ThisHeart;


	void Update()
	{
		RotateSpeed = 2;
		transform.Rotate(0, RotateSpeed, 0, Space.World);
	}


	void OnTriggerEnter()
	{
		if (HealthMonitor.HealthValue < 3)
		{
			CollectSound.Play();
			HealthMonitor.HealthValue += 1;
			ThisHeart.SetActive(false);
		}
	}
}