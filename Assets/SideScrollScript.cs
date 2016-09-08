using UnityEngine;
using System.Collections;

public class SideScrollScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
            MeshRenderer mr = GetComponent<MeshRenderer>();

            Material mat = mr.material;

            Vector2 offset = mat.mainTextureOffset;

            offset.x += Time.deltaTime;

            mat.mainTextureOffset = offset;

            gameObject.GetComponent<Animation>()["animationName"].wrapMode = WrapMode.PingPong;

    }
}
