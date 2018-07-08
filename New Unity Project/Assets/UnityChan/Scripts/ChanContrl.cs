using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanContrl : MonoBehaviour
{

	public Animator animator;
	public Rigidbody rigidbody;


	private float h;
	private float v;

	private float moveX;
	private float moveZ;
	private float speedH = 50f;
	private float speedZ = 80f;


	// Use this for initialization
	void Start()
	{
		animator = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			animator.Play("JUMPOO", -1, 0);
		}

		animator.SetFloat("h", h);
		animator.SetFloat("v", v);

		moveX = h * speedH * Time.deltaTime;
		moveZ = v * speedZ * Time.deltaTime;

		if (moveZ <= 0)
		{
			moveX = 0;
		}

		rigidbody.velocity = new Vector3(moveX, 0, moveZ);

	}
}