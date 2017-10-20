using System;
using UnityEngine;
using UnityEngine.UI;

public class OpenNote : MonoBehaviour {

	public void GetTitle(string title)
	{
		Text titleText = GetComponentInChildren<Text>();
		titleText.text = title;
	}
}
