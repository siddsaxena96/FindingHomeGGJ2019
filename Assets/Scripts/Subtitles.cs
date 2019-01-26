using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Subtitles : MonoBehaviour {
	FileStream file;
	StreamReader inp_stm;
	string data,inp_ln;
	public GameObject sub;
	// Use this for initialization
	void Start () {
		string Path =Application.dataPath;
		Debug.Log(Path);
		file = new FileStream(Application.dataPath+"/Resources/subtitle.txt",FileMode.Open,FileAccess.Read);
		inp_stm = new StreamReader(file);
		StartCoroutine(setText());
		//sub = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	 IEnumerator setText ()
	{
   		while(!inp_stm.EndOfStream)
  		{
      		inp_ln = inp_stm.ReadLine( );
       // Do Something with the input. 
	   		// Debug.Log(inp_ln);	
			sub.GetComponent<Text>().text = inp_ln;
			yield return new WaitForSeconds(2);
  		}
   		inp_stm.Close( );
	}

}
