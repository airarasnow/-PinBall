using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pointController : MonoBehaviour
{
    private GameObject PointText;

	private int point;
	// Use this for initialization
	void Start()
    {
		
		//シーン中のGameOverTextオブジェクトを取得
		this.PointText = GameObject.Find("pointText");
    }

    void Update()
	{
		
	}

	void OnCollisionEnter(Collision other)
	{
        if (other.gameObject.tag == "SmallCloudTag")
        {
            point += 10;
        }
        else if(other.gameObject.tag == "LargeCloudTag")
        {
            point += 20;
        }
        this.PointText.GetComponent<Text>().text = point.ToString();
    }
}