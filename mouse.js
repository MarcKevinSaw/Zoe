#pragma strict

function Start () 
{


}

function Update () 
{

	var rect : RectTransform = GetComponent.<RectTransform>();
	rect.anchoredPosition = Input.mousePosition;

}