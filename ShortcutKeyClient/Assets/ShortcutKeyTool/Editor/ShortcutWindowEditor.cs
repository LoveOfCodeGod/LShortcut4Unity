using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
using System.IO;
using System.Xml;
using System.Text;
using UnityEngine.UI;

public class ShortcutWindowEditor : EditorWindow
{
	private static string tipsLabelText = "* %->commond #->shift &->ctrl _a->keyboard[A]";
	
	private static string ShortcutSystemPath 
	{
		get { return Application.dataPath + "/ShortcutKeyTool/Editor/ShortcutKeySystemEditor.cs";}
	}
	
	private static string ShortcutPath 
	{
		get { return Application.dataPath + "/ShortcutKeyTool/Editor/ShortcutKeyEditor.cs";}
	}
	
	private static string ShortcutSystemSavePath 
	{
		get { return Application.dataPath + "/ShortcutKeyTool/Res/ShortcutSystemKeyData.xml";}
	}

	private static string ShortcutSavePath 
	{
		get { return Application.dataPath + "/ShortcutKeyTool/Res/ShortcutKeyData.xml";}
	}

	[MenuItem("LLL/Tools/ShortcutWindow _o",false,3)]
	static void SetUpShortcutWindow()
	{
		ShortcutWindowEditor myWindow =
			(ShortcutWindowEditor) EditorWindow.GetWindow(typeof(ShortcutWindowEditor), true, "Shortcut Key");
		myWindow.Show();
	}

	private ShortItem ski;
	private List<ShortItem> mSkiList;

	private string[] m_PopListNames = new string[]
		{"File", "Edit", "Assets", "GameObject", "Component", "Help", "Extension"};
	private ShortType m_SType;

	private Vector2 scrollPositon1,
		scrollPositon2,
		scrollPositon3,
		scrollPositon4,
		scrollPositon5,
		scrollPositon6,
		scrollPositon7,
		scrollPositon8;

	private bool folderOut1, folderOut2, folderOut3, folderOut4, folderOut5, folderOut6, folderOut7, folderOut8;

	private Dictionary<ShortType, List<ShortItem>> m_ShortKeyDict;
	
	void Awake()
	{
		InitSystemData();
		ski=new ShortItem("","");
		mSkiList=new List<ShortItem>();
		scrollPositon1 = scrollPositon2 = scrollPositon3 = scrollPositon4 =
			scrollPositon5 = scrollPositon6 = scrollPositon7 = scrollPositon8 = new Vector2(300, 500);
	}

	void OnGUI()
	{
		//绘制标题
		GUILayout.Space(10);
		GUI.skin.label.fontSize = 24;
		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		GUILayout.Label("Shortcut Style");
		GUI.skin.label.fontSize = 12;
		GUILayout.Space(10);
		//tips
		EditorGUILayout.LabelField(tipsLabelText);
		GUILayout.Space(10);
		//Show
		ShowList();
		//button
		EditorGUILayout.BeginHorizontal();
		m_SType =(ShortType) EditorGUILayout.Popup((int)m_SType,m_PopListNames);
		if(GUILayout.Button("add"))
		{
			ski=new ShortItem("Editor1/Editor2/Editor3","");
			Debug.LogFormat("add {0} {1} {2} {3} ",ski.Path,ski.ShortKey,ski.MenuItemName,ski.FuncName);
			if(m_ShortKeyDict[m_SType]==null)
				m_ShortKeyDict[m_SType]=new List<ShortItem>();
			m_ShortKeyDict[m_SType].Add(ski);
		}
		if (GUILayout.Button("save"))
		{
			foreach (ShortType st in m_ShortKeyDict.Keys)
			{
				if (st != ShortType.Extension)
				{
					mSkiList.AddRange(m_ShortKeyDict[st]);
				}
			}
			SaveShortcutKey2File (ShortcutSystemSavePath,mSkiList);
			SaveShortcutKey2EditorCode(ShortcutSystemPath,mSkiList);
			//save to script
			SaveShortcutKey2File (ShortcutSavePath,m_ShortKeyDict[ShortType.Extension]);
			SaveShortcutKey2EditorCode(ShortcutPath,m_ShortKeyDict[ShortType.Extension]);
		}
		EditorGUILayout.EndHorizontal();
		GUILayout.Space(10);
	}

	void OnDestroy()
	{
		if (m_ShortKeyDict == null)
		{
			m_ShortKeyDict.Clear();
			m_ShortKeyDict = null;
		}
	}

	void InitSystemData()
	{
		if (m_ShortKeyDict == null)
		{
			m_ShortKeyDict=new Dictionary<ShortType, List<ShortItem>>()
			{
				{ShortType.File,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.File)},
				{ShortType.Edit,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.Edit)},
				{ShortType.Assets,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.Assets)},
				{ShortType.GameObject,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.GameObject)},
				{ShortType.Component,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.Component)},
				{ShortType.Window,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.Window)},
				{ShortType.Help,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.Help)},
				{ShortType.Extension,LoadShortcutKeyFromFile (ShortcutSystemSavePath,ShortType.Extension)}
			};
		}
	}

	void ShowList()
	{
		if (m_ShortKeyDict == null)
		{
			InitSystemData();
		}
		foreach (var sType in m_ShortKeyDict.Keys)
		{
			switch (sType)
			{
				case ShortType.File:
					folderOut1 = EditorGUILayout.Foldout(folderOut1,ShortType.File.ToString());
					if (folderOut1)
					{
						ShowItemList(ShortType.File,scrollPositon1);
					}
					break;
				case ShortType.Edit:
					folderOut2 = EditorGUILayout.Foldout(folderOut2,ShortType.Edit.ToString());
					if (folderOut2)
					{
						ShowItemList(ShortType.Edit,scrollPositon2);
					}
					break;
				case ShortType.Assets:
					folderOut3 = EditorGUILayout.Foldout(folderOut3,ShortType.Assets.ToString());
					if (folderOut3)
					{
						ShowItemList(ShortType.Assets,scrollPositon3);
					}
					break;
				case ShortType.GameObject:
					folderOut4 = EditorGUILayout.Foldout(folderOut4,ShortType.GameObject.ToString());
					if (folderOut4)
					{
						ShowItemList(ShortType.GameObject,scrollPositon4);
					}
					break;
				case ShortType.Component:
					folderOut5 = EditorGUILayout.Foldout(folderOut5,ShortType.Component.ToString());
					if (folderOut5)
					{
						ShowItemList(ShortType.Component,scrollPositon5);
					}
					break;
				case ShortType.Window:
					folderOut6 = EditorGUILayout.Foldout(folderOut6,ShortType.Window.ToString());
					if (folderOut6)
					{
						ShowItemList(ShortType.Window,scrollPositon6);
					}
					break;
				case ShortType.Help:
					folderOut7 = EditorGUILayout.Foldout(folderOut7,ShortType.Help.ToString());
					if (folderOut7)
					{
						ShowItemList(ShortType.Help,scrollPositon7);
					}
					break;
				case ShortType.Extension:
					folderOut8 = EditorGUILayout.Foldout(folderOut8,ShortType.Extension.ToString());
					if (folderOut8)
					{
						ShowItemList(ShortType.Extension,scrollPositon8,false);
					}
					break;
			}
		}
	}

	void ShowItemList(ShortType sType,Vector2 scrollPositon,bool isSystem=false)
	{
		//show
		scrollPositon =EditorGUILayout.BeginScrollView(scrollPositon);
		if (m_ShortKeyDict[sType]!=null && m_ShortKeyDict[sType].Count > 0)
		{
			for (int i = 0; i < m_ShortKeyDict[sType].Count; i++)
			{
				ShowItem(m_ShortKeyDict[sType][i],m_ShortKeyDict[sType],isSystem);
			}
		}
		EditorGUILayout.EndScrollView();
	}

	void ShowItem(ShortItem codeItem,List<ShortItem> list,bool isSystem=false)
	{
		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField("Path:",GUILayout.Width(85));
		codeItem.Path = EditorGUILayout.TextField(codeItem.Path, GUILayout.Width(200));
		EditorGUILayout.LabelField("ShortcutName:",GUILayout.Width(85));
		codeItem.ShortKey = EditorGUILayout.TextField(codeItem.ShortKey, GUILayout.Width(85));
		if (!isSystem && GUILayout.Button("delete",GUILayout.Width(70),GUILayout.Height(20)))
		{
			if (list.Contains(codeItem))
			{
				list.Remove(codeItem);
			}
		}
		EditorGUILayout.EndHorizontal();
	}
	
	private void SaveShortcutKey2EditorCode(string strFilePath,List<ShortItem> skiList)
	{
		if (!File.Exists(strFilePath))
		{
			FileStream fl = File.Create(strFilePath);
			fl.Close();
		}
		string strDlg = strFilePath.Substring(strFilePath.LastIndexOf('/')+1).Split('.')[0];
		if (File.Exists(strFilePath) == true)
		{
			StreamWriter sw = new StreamWriter(strFilePath, false, Encoding.UTF8);
			StringBuilder strBuilder = new StringBuilder();

			strBuilder.AppendLine("using UnityEditor;");
			strBuilder.AppendLine();
//			strBuilder.AppendLine("namespace " );
//			strBuilder.AppendLine("{");
//			strBuilder.AppendLine();
			
			//类名开始
			strBuilder.AppendFormat("public class {0}", strDlg); 
			strBuilder.AppendLine();
			strBuilder.AppendLine("{");
			
			//方法开始
			for (int i = 0; i < skiList.Count; i++)
			{
				strBuilder.Append("\t\t").AppendFormat("[MenuItem(\"LLL/ShortcutKey/{0} {1}\")]",skiList[i].MenuItemName,skiList[i].ShortKey).AppendLine();
				strBuilder.Append("\t\t").AppendFormat("static void ShortcutKey_{0}()",skiList[i].FuncName).AppendLine();
				strBuilder.Append("\t\t").AppendLine("{");
				strBuilder.Append("\t\t").Append("\t").AppendFormat("EditorApplication.ExecuteMenuItem(\"{0}\");",skiList[i].Path).AppendLine();
				strBuilder.Append("\t\t").AppendLine("}").AppendLine();
			}
			//方法结束
			
			//类名结束
			strBuilder.Append("}");		
//			strBuilder.Append("}");

			sw.Write(strBuilder);
			sw.Flush();
			sw.Close();
		}
		AssetDatabase.Refresh();

		Debug.Log(">>>>>>>Success Create UIPrefab Code: " + strDlg);
	}

	private void SaveShortcutKey2File(string savePath,List<ShortItem> list)
	{
		if (!File.Exists(savePath))
		{
			FileStream fl = File.Create(savePath);
			fl.Close();
		}
		XmlDocument xml = new XmlDocument ();
		XmlElement root = xml.CreateElement ("KeyData");
		//创建子节点
		for (int i = 0; i < list.Count; i++) 
		{
			XmlElement element=xml.CreateElement("ShortcutKeyItem");
			element.SetAttribute ("id", (i+1).ToString());
			XmlElement elementChild1 = xml.CreateElement("Path");
			elementChild1.InnerText = list [i].Path;
			XmlElement elementChild2 = xml.CreateElement("ShortKeyName");
			elementChild2.InnerText = list [i].ShortKey;
			//把节点一层一层的添加至xml中，注意他们之间的先后顺序，这是生成XML文件的顺序
			element.AppendChild(elementChild1);
			element.AppendChild(elementChild2);
			root.AppendChild(element);
		}
		xml.AppendChild (root);
		xml.Save(savePath);
	}

	private List<ShortItem> LoadShortcutKeyFromFile(string savePath,ShortType sType)
	{
		if (!File.Exists (savePath))
			return null;
		List<ShortItem> itemList = new List<ShortItem> ();
		XmlDocument xml = new XmlDocument ();
		xml.Load (savePath);
		XmlNodeList xnlList = xml.SelectSingleNode ("KeyData").ChildNodes;
		string tn = "", sn = "";
		for (int i = 0; i < xnlList.Count; i++) 
		{
			XmlElement xel = xnlList [i] as XmlElement;
			if(xel.GetAttribute("id")==(i+1).ToString())
			{
				foreach (XmlNode item in xel.ChildNodes) 
				{
					if (item.Name.Equals ("Path"))
						tn = item.InnerText;
					if (item.Name.Equals ("ShortKeyName"))
						sn = item.InnerText;
				}
				if (tn.Split('/')[0].Equals(sType.ToString()))
					itemList.Add(new ShortItem(tn, sn));
			}

		}
		return itemList;
	}
}