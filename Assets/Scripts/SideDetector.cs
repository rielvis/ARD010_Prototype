/// This script is AI generated. I am having a hard time wrapping my head around AR project structures compared to traditional structures.

using UnityEngine;

public class SideDetector : MonoBehaviour
{
    public Transform wall;
    public Camera arCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localPos = wall.InverseTransformPoint(arCamera.transform.position);

        bool onSideA = localPos.z > 0f;

        Debug.Log(onSideA ? "Side A" : "Side B");
    }
}
