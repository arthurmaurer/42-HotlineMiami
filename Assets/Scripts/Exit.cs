﻿using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour
{
	void	OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Hero")
			Application.LoadLevel("MainMenu");
	}
}
