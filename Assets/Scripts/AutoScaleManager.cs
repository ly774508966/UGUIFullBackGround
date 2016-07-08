using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AutoScaleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Image image = GetComponent<Image> ();
		image.preserveAspect = true;
		RectTransform rt = (RectTransform)transform;
		rt.anchorMin = Vector2.zero;
		rt.anchorMax = Vector2.one;
		rt.offsetMin = Vector2.zero;
		rt.offsetMax = Vector2.zero;
		float screenWidth = (float)Screen.width;
		float screenHeight = (float)Screen.height;
		float imageWidth = (float)image.preferredWidth;
		float imageHeight = (float)image.preferredHeight;
		Debug.Log (imageWidth + ":" +imageHeight);
		float screenRate =screenWidth/screenHeight;
		float imageRate = imageWidth/imageHeight;

	

		if (screenRate > imageRate) {

			Debug.Log ("高度填充");
			rt.localScale = rt.localScale *
				screenWidth / (imageRate * screenHeight);

		} else {
			Debug.Log("宽度填充");


			rt.localScale = rt.localScale *
				(screenHeight/(screenWidth / imageRate) );


		}


		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
