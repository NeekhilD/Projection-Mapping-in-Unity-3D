// https://gist.github.com/tsubaki/7789119

using UnityEngine;
using System.Collections;

public class GetTexture : MonoBehaviour {

	public BackgroundRenderBasic target;
	public GameObject model = null;

	void Start()
	{

        target.addGameObject(gameObject);
	}
}
