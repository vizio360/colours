using UnityEngine;
using System.Collections;

public class VertexPainter : MonoBehaviour {

	public void changeVertexesColor(Color c) {
		Mesh m = this.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = m.vertices;
        Color[] colors = new Color[vertices.Length];
		for(int i = 0; i < colors.Length; i++) {
			colors[i] = c;
		}
		m.colors = colors;
	}
}
