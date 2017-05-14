using UnityEngine;  
using UnityEngine.UI;  
using System.Collections;  
/// <summary>  
/// 脚本功能：MVC模式 —— View视图，控制背包的显示方式  
/// 添加对象：Bag 背包 (Canvas下的空对象)  
/// 版权声明：Copyright (c) 2015 duzixi.com  All Rights Reserved  
/// 创建时间：2015.05.08  
/// 修改记录：2015.05.18 添加编号  
/// 修改记录：2015.07.03 封装显示物品格子方法  
/// 知识要点：  
/// 1. MVC  
/// 2. UGUI   
/// </summary>  
public class Bag : MonoBehaviour {  
	// 背包规格  
	public static int row = 3;  // 行  
	public static int col = 5;  // 列

	public int x;
	public int y;

	// 背包格子  
	public GameObject grid;  
	float width;  // 格子宽度  
	float height; // 格子高度  

	// 根据格子预设体获取宽和高  
	void Awake() {  
		width = grid.GetComponent<RectTransform>().rect.width;  
		height = grid.GetComponent<RectTransform>().rect.height;  
	}  

	// 初始状态：平铺格子，创建背包  
	void Start () {  
		for (int i = 0; i < row; i++) {  
			for (int j = 0; j < col; j++) {  
				// 计算ID值(物品列表下标)  
				int id = j + i * col;  

				// 实例化格子预设，按宽高布局  
				GameObject itemGrid = Instantiate(grid, new Vector3(j * width + x, -i * height + y, 0), Quaternion.identity) as GameObject;  
				// 将实例化的格子对象设置为背包的子对象  
				itemGrid.transform.SetParent(transform);  

				// 调用自定义方法：显示某个id的格子内容    

				// 给格子 PickUpDrop 组件编号，拾取放下时用  
				itemGrid.GetComponent<PickUpDrop>().gridID = id;  
			}  
		}  
	}  

}
