using UnityEngine;
using System.Collections;

class CustomColor {
	public static Color red = Color.red;
	public static Color blue = Color.blue;
	public static Color yellow = Color.yellow;
	public static Color green = Color.green;
	public static Color purple = new Color(0.5f, 0.0f, 1.0f);
	public static Color orange = new Color(1.0f, 0.5f, 0.0f);
}

public class Colorss {
	public static Hashtable red = new Hashtable()
	{
		{CustomColor.blue, CustomColor.purple},
		{CustomColor.yellow, CustomColor.orange}
	};
	
	public static Hashtable blue = new Hashtable()
	{
		{CustomColor.red, CustomColor.purple},
		{CustomColor.yellow, CustomColor.green}
	};
	
	public static Hashtable yellow = new Hashtable()
	{
		{CustomColor.red, CustomColor.orange},
		{CustomColor.blue, CustomColor.green}
	};
	
}

