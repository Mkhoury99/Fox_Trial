using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabWeapon : MonoBehaviour {

	public Transform firePoint;
	public GameObject bulletPrefab;
	public bool canFire = false;
	// Update is called once per frame
	void Update () {
		if (canFire == true)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				Shoot();
			}
		}
	}

	void Shoot ()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
	void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.CompareTag("gem"))
		{
			Destroy(trig.gameObject);
			canFire = true;
		}
	}
}
