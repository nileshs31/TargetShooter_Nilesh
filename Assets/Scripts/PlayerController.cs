using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public GameObject projectilePrefab;

	public float speed = 10f;
	public float rotateSpeed = 10f;

	private Vector3 movement;
	private float rotation;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftShift))
        {
			speed *= 2;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			speed /= 2;
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();

		}

		movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
	}

	void FixedUpdate()
	{
		transform.Translate(movement, Space.Self);
		transform.Rotate(0f, rotation, 0f); 
	}
	public void Shoot()
	{
		// Instantiate the projectile at the spawn point.
		Instantiate(projectilePrefab, this.transform.position, this.transform.rotation);
	}
}
