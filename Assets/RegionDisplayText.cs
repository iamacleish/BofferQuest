using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RegionDisplayText : MonoBehaviour {

	public static int region;
	public static string regionName;
	Text text;
	// Use this for initialization
	void Start () {
	
	}
	void Awake(){
		text = GetComponent<Text> ();
		region = PlayerPrefs.GetInt ("PlayerRegion");
	}
	
	// Update is called once per frame
	void Update () {

		if (region == 0) {
			regionName = "error";
		}
		if (region == 1) {
			regionName = "Babylon";
		}
		if (region == 2) {
			regionName = "Calia";
		}
		if (region == 3) {
			regionName = "Mormia";
		}
		text.text = "Region selected is: " + regionName + "\nRegion number is: " + region;
	}
}
