/*
Copyright (C) 2012 Chirag Raman

This file is part of Projection-Mapping-in-Unity3D.

Projection-Mapping-in-Unity3D is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Projection Mapping in Unity3D is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Projection-Mapping-in-Unity3D.  If not, see <http://www.gnu.org/licenses/>.
*/


using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Homography : MonoBehaviour {
	
    Vector3[] vertices;
    public Matrix4x4 matrix;

	// Use this for initialization
	void Start () {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;

	}
	
	// Update is called once per frame
    void Update()
    {
        int i = 0;
        Vector3[] v = new Vector3[vertices.Length];
        while (i < vertices.Length)
        {
            v[i] = matrix.MultiplyPoint(vertices[i] * 600 + new Vector3(400, 400));
            Debug.Log(v[i] + " " + vertices[i] + " " + i);
            i++;
        }
        GetComponent<MeshFilter>().mesh.vertices = v;
    }
}
