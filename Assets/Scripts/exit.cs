﻿using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour {

	public Button butt;

	void Start()
	{
		Button btn = butt.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Application.Quit();
	}
}

