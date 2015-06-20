﻿using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
	public Sprite	attachedSprite;
	public Sprite	bulletSprite;
	public uint		ammo;
	public Object	bulletPrefab;

	public void	Fire()
	{
		Vector2		position;
		Quaternion	rotation;
		GameObject	go;
		Bullet		bullet;

		if (ammo == 0)
			return ;

		position = GameManager.hero.transform.position;
		rotation = GameManager.hero.transform.rotation;
		go = (GameObject) Instantiate(bulletPrefab, position, rotation);

		bullet = go.GetComponent<Bullet>();
		bullet.direction = Vector3.Normalize(GameManager.hero.aimDirection);

		ammo--;
	}
}
