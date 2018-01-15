using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	void Start () {
        if (GameObject.FindGameObjectsWithTag("Music").Length >=2)
        {
            GameObject[] musics = GameObject.FindGameObjectsWithTag("Music");
            GameObject.Destroy(musics[1]);
        }
	}
}
