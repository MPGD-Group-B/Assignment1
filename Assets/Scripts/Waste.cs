using UnityEngine;
using System.Collections;

public class Waste : MonoBehaviour
{
    //    public Transform cube;
    bool isShowTip;
    public bool WindowShow = false;
    //    // Use this for initialization
    void Start()
    {
        isShowTip = false;
    }
    void OnMouseEnter()
    {
        isShowTip = true;
        //Debug.Log (cube.name);//Get the name of object

    }
    void OnMouseExit()
    {
        isShowTip = false;
    }
    void OnGUI()
    {
        if (isShowTip)
        {
            GUIStyle style1 = new GUIStyle();
            style1.fontSize = 30;
            style1.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 400, 50), "Nuclear Waste", style1);

        }
        if (WindowShow)
            GUI.Window(0, new Rect(30, 30, 200, 100), MyWindow, "Nuclear Waste");
    }

    //GUI Function
    void MyWindow(int WindowID)
    {
        GUILayout.Label("Nuclear Waste");
    }
    //On mouse Click
    void OnMouseDown()
    {
        Debug.Log("show");
        if (WindowShow)
            WindowShow = false;
        else
            WindowShow = true;
    }
}

