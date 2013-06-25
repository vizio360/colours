using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomColor {
	public static Color red = Color.red;
	public static Color blue = Color.blue;
	public static Color yellow = Color.yellow;
	public static Color green = Color.green;
	public static Color purple = new Color(0.5f, 0.0f, 1.0f);
	public static Color orange = new Color(1.0f, 0.5f, 0.0f);
}

public class Colors {
	
	public static IDictionary<Color, Color> red = new Dictionary<Color, Color>()
	{
		{CustomColor.blue, CustomColor.purple},
		{CustomColor.yellow, CustomColor.orange}
	};
	
	public static IDictionary<Color, Color> blue = new Dictionary<Color, Color>()
	{
		{CustomColor.red, CustomColor.purple},
		{CustomColor.yellow, CustomColor.green}
	};
	
	public static IDictionary<Color, Color> yellow = new Dictionary<Color, Color>()
	{
		{CustomColor.red, CustomColor.orange},
		{CustomColor.blue, CustomColor.green}
	};
	
	public static IDictionary<Color, IDictionary<Color, Color>> colors = new Dictionary<Color, IDictionary<Color, Color>>()
	{
		{CustomColor.red, Colors.red},
		{CustomColor.blue, Colors.blue},
		{CustomColor.yellow, Colors.yellow}
	};
	
	public static Color getRandomPrimaryColor() {
		int randomIndex = (int)(Random.value * Colors.colors.Keys.Count);
		Color key = Colors.colors.Keys.ToList()[randomIndex];		
		return key;
	}
	
	public static Color getRandomCombinedColorFor(Color baseColor) {
		IDictionary<Color, Color> h = Colors.colors[baseColor];
		List<Color> list = h.Keys.ToList();
		int randomIndex = (int)(Random.value * list.Count);
		return h[list[randomIndex]];
	}
	
}

