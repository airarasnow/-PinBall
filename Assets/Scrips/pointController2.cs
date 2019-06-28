using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pointController2 : MonoBehaviour
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
        this.PointText.GetComponent<Text>().text = point.ToString();
    }

    void OnCollisionEnter(Collision other)
    {
        if (tag == "LargeCloudTag")
        {
            point += 20;
        }
    }
}