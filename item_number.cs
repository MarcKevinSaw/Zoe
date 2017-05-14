using UnityEngine;  
using UnityEngine.EventSystems;  
using System.Collections;  
/// <summary>  
/// 脚本功能：MVC模式 —— Control控制，背包内物品摆放  
/// 添加对象：Item 物品格子预设体   
/// 版权声明：Copyright (c) 2015 duzixi.com  All Rights Reserved  
/// 创建日期：2015.05.18 duzixi.com  
/// 修改记录：2015.07.03 添加射线忽略  
/// 知识要点：  
/// 1. UGUI、MVC设计模式  
/// </summary>  
public class item_number : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {  

	public int gridID; 
	public bool In;
	public static GameObject Cell;
	public int child;
	public bool Enter;
	public bool Stay;

	public static ITEM.Item pickedItem; // 当前拾取的物品   

	void OnTriggerEnter2D(Collider2D item)
	{

		if(item.CompareTag("Item"))
		Enter = true;

	}

	void OnTriggerStay2D(Collider2D item)
	{

		if(item.CompareTag("Item"))
		Stay = true;

	}

	void OnTriggerExit2D(Collider2D item)
	{

		Stay = false;

	}

	void Update () 
	{

		gridID = GetComponent<PickUpDrop> ().gridID;



		if (Stay == true) {

			Cell = this.gameObject;
			Enter = false;


		}

		if (move_goods._mouse == true)
			GetComponent<item_null> ().enabled = false;
		else if (move_goods._mouse == false)
			GetComponent<item_null> ().enabled = true;

	}

	public void OnPointerEnter(PointerEventData eventData)
	{

		In = true;

	}
	public void OnPointerExit(PointerEventData eventData)
	{

		In = false;

	}

}  