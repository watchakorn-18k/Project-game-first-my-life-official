﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RadialProgress : MonoBehaviour {
	public GameObject LoadingText;
	public Text ProgressIndicator;
	public Image LoadingBar;
	float currentValue;
	public float speed;
	void Start () { }
	void Update () {
	if (currentValue < 100) {
	currentValue += speed * Time.deltaTime;
	ProgressIndicator.text = ((int)currentValue).ToString () + "%";
	LoadingText.SetActive (true);
	} else {
	LoadingText.SetActive (false);
	Application.LoadLevel("PlayScene");
	}
	LoadingBar.fillAmount = currentValue / 100;
	}
}