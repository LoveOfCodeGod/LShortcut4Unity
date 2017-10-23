//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;
//using System;
//using System.IO;
//using System.Xml;
//using System.Text;
//using UnityEngine.UI;
//
//public class ShortcutWindowEditor : EditorWindow
//{
//	private static string tipsLabelText = "* %->commond #->shift &->ctrl _a->keyboard[A]";
//	
//	private static string ShortcutSystemPath 
//	{
//		get { return Application.dataPath + "/ShortcutKeyTool/Editor/ShortcutKeySystemEditor.cs";}
//	}
//	
//	private static string ShortcutPath 
//	{
//		get { return Application.dataPath + "/ShortcutKeyTool/Editor/ShortcutKeyEditor.cs";}
//	}
//	
//	private static string ShortcutSystemSavePath 
//	{
//		get { return Application.dataPath + "/ShortcutKeyTool/Res/ShortcutSystemKeyData.xml";}
//	}
//
//	private static string ShortcutSavePath 
//	{
//		get { return Application.dataPath + "/ShortcutKeyTool/Res/ShortcutKeyData.xml";}
//	}
//
//	[MenuItem("LLL/Tools/ShortcutWindow _o",false,3)]
//	static void SetUpShortcutWindow()
//	{
//		ShortcutWindowEditor myWindow =
//			(ShortcutWindowEditor) EditorWindow.GetWindow(typeof(ShortcutWindowEditor), true, "Shortcut Key");
//		myWindow.Show();
//	}
//
//	private ShortItem ski;
//	private List<ShortItem> mSkiList;
//	private Vector2 scrollPositon;
//	private bool folderOut1;
//	private bool folderOut2;
//	private bool folderOut3;
//	private bool folderOut4;
//	private bool folderOut5;
//	private bool folderOut6;
//	private bool folderOut7;
//	private bool folderOut8;
//
//	private Dictionary<ShortType, List<ShortItem>> m_ShortKeyDict;
//	
//	void Awake()
//	{
//		if (m_ShortKeyDict == null)
//		{
//			m_ShortKeyDict=new Dictionary<ShortType, List<ShortItem>>()
//			{
//				{ShortType.File,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.File)},
//				{ShortType.Edit,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.Edit)},
//				{ShortType.Assets,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.Assets)},
//				{ShortType.GameObject,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.GameObject)},
//				{ShortType.Component,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.Component)},
//				{ShortType.Window,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.Window)},
//				{ShortType.Help,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.Help)},
//				{ShortType.Extension,LoadShortcutKeyFromFile (ShortcutSavePath,ShortType.Extension)}
//			};
//		}
//		
//		ski=new ShortItem("","");
//		scrollPositon = new Vector2(300, 500);
//	}
//
//	void OnGUI()
//	{
//		//绘制标题
//		GUILayout.Space(10);
//		GUI.skin.label.fontSize = 24;
//		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
//		GUILayout.Label("Shortcut Style");
//		GUI.skin.label.fontSize = 12;
//		GUILayout.Space(10);
//		//tips
//		EditorGUILayout.LabelField(tipsLabelText);
//		GUILayout.Space(10);
//		//Show
//		ShowList();
//		//button
//		EditorGUILayout.BeginHorizontal();
//		if(GUILayout.Button("add"))
//		{
//			ski=new ShortItem("Editor1/Editor2/Editor3","");
//			Debug.LogFormat("add {0} {1} {2} {3} ",ski.Path,ski.ShortKey,ski.MenuItemName,ski.FuncName);
//			if(m_ShortKeyDict[ShortType.Extension]==null)
//				m_ShortKeyDict[ShortType.Extension]=new List<ShortItem>();
//			m_ShortKeyDict[ShortType.Extension].Add(ski);
//		}
//		if (GUILayout.Button("save"))
//		{
//			//save to script
//			SaveShortcutKey2File (ShortcutSavePath,m_ShortKeyDict[ShortType.Extension]);
//			SaveShortcutKey2EditorCode(ShortcutPath,m_ShortKeyDict[ShortType.Extension]);
//		}
//		EditorGUILayout.EndHorizontal();
//		GUILayout.Space(10);
//	}
//
//	void OnDestroy()
//	{
//		if (m_ShortKeyDict[ShortType.Extension] != null)
//		{
//			m_ShortKeyDict[ShortType.Extension] = null;
//		}
//	}
//
//	void ShowList()
//	{
//		foreach (var sType in m_ShortKeyDict.Keys)
//		{
//			switch (sType)
//			{
//				case ShortType.File:
//					folderOut1 = EditorGUILayout.Foldout(folderOut1,ShortType.File.ToString());
//					if (folderOut1)
//					{
//						ShowItemList(ShortType.File);
//					}
//					break;
//				case ShortType.Edit:
//					folderOut2 = EditorGUILayout.Foldout(folderOut2,ShortType.Edit.ToString());
//					if (folderOut2)
//					{
//						ShowItemList(ShortType.Edit);
//					}
//					break;
//				case ShortType.Assets:
//					folderOut3 = EditorGUILayout.Foldout(folderOut3,ShortType.Assets.ToString());
//					if (folderOut3)
//					{
//						ShowItemList(ShortType.Assets);
//					}
//					break;
//				case ShortType.GameObject:
//					folderOut4 = EditorGUILayout.Foldout(folderOut4,ShortType.GameObject.ToString());
//					if (folderOut4)
//					{
//						ShowItemList(ShortType.GameObject);
//					}
//					break;
//				case ShortType.Component:
//					folderOut5 = EditorGUILayout.Foldout(folderOut5,ShortType.Component.ToString());
//					if (folderOut5)
//					{
//						ShowItemList(ShortType.Component);
//					}
//					break;
//				case ShortType.Window:
//					folderOut6 = EditorGUILayout.Foldout(folderOut6,ShortType.Window.ToString());
//					if (folderOut6)
//					{
//						ShowItemList(ShortType.Window);
//					}
//					break;
//				case ShortType.Help:
//					folderOut7 = EditorGUILayout.Foldout(folderOut7,ShortType.Help.ToString());
//					if (folderOut7)
//					{
//						ShowItemList(ShortType.Help);
//					}
//					break;
//				case ShortType.Extension:
//					folderOut8 = EditorGUILayout.Foldout(folderOut8,ShortType.Extension.ToString());
//					if (folderOut8)
//					{
//						ShowItemList(ShortType.Extension);
//					}
//					break;
//			}
//		}
//	}
//
//	void ShowItemList(ShortType sType)
//	{
//		//show
//		scrollPositon =EditorGUILayout.BeginScrollView(scrollPositon);
//		if (m_ShortKeyDict[sType]!=null && m_ShortKeyDict[sType].Count > 0)
//		{
//			for (int i = 0; i < m_ShortKeyDict[sType].Count; i++)
//			{
//				ShowItem(m_ShortKeyDict[sType][i]);
//			}
//		}
//		EditorGUILayout.EndScrollView();
//	}
//
//	void ShowItem(ShortItem codeItem)
//	{
//		EditorGUILayout.BeginHorizontal();
//		EditorGUILayout.LabelField("TargetName:",GUILayout.Width(85));
//		codeItem.Path = EditorGUILayout.TextField(codeItem.Path, GUILayout.Width(200));
//		EditorGUILayout.LabelField("ShortcutName:",GUILayout.Width(85));
//		codeItem.ShortKey = EditorGUILayout.TextField(codeItem.ShortKey, GUILayout.Width(85));
//		if (GUILayout.Button("delete",GUILayout.Width(70),GUILayout.Height(20)))
//		{
//			if (mSkiList.Contains(codeItem))
//			{
//				mSkiList.Remove(codeItem);
//			}
//		}
//		EditorGUILayout.EndHorizontal();
//	}
//	
//	private void SaveShortcutKey2EditorCode(string strFilePath,List<ShortItem> skiList)
//	{
//		if (!File.Exists(strFilePath))
//		{
//			FileStream fl = File.Create(strFilePath);
//			fl.Close();
//		}
//		string strDlg = strFilePath.Substring(strFilePath.LastIndexOf('/')+1).Split('.')[0];
//		if (File.Exists(strFilePath) == true)
//		{
//			StreamWriter sw = new StreamWriter(strFilePath, false, Encoding.UTF8);
//			StringBuilder strBuilder = new StringBuilder();
//
//			strBuilder.AppendLine("using UnityEditor;");
//			strBuilder.AppendLine();
////			strBuilder.AppendLine("namespace " );
////			strBuilder.AppendLine("{");
////			strBuilder.AppendLine();
//			
//			//类名开始
//			strBuilder.AppendFormat("public class {0}", strDlg); 
//			strBuilder.AppendLine();
//			strBuilder.AppendLine("{");
//			
//			//方法开始
//			for (int i = 0; i < skiList.Count; i++)
//			{
//				strBuilder.Append("\t\t").AppendFormat("[MenuItem(\"LLL/ShortcutKey/{0} {1}\")]",skiList[i].MenuItemName,skiList[i].ShortKey).AppendLine();
//				strBuilder.Append("\t\t").AppendFormat("static void ShortcutKey_{0}()",skiList[i].FuncName).AppendLine();
//				strBuilder.Append("\t\t").AppendLine("{");
//				strBuilder.Append("\t\t").Append("\t").AppendFormat("EditorApplication.ExecuteMenuItem(\"{0}\");",skiList[i].Path).AppendLine();
//				strBuilder.Append("\t\t").AppendLine("}").AppendLine();
//			}
//			//方法结束
//			
//			//类名结束
//			strBuilder.Append("}");		
////			strBuilder.Append("}");
//
//			sw.Write(strBuilder);
//			sw.Flush();
//			sw.Close();
//		}
//		AssetDatabase.Refresh();
//
//		Debug.Log(">>>>>>>Success Create UIPrefab Code: " + strDlg);
//	}
//
//	private void SaveShortcutKey2File(string savePath,List<ShortItem> list)
//	{
//		if (!File.Exists(savePath))
//		{
//			FileStream fl = File.Create(savePath);
//			fl.Close();
//		}
//		XmlDocument xml = new XmlDocument ();
//		XmlElement root = xml.CreateElement ("KeyData");
//		//创建子节点
//		for (int i = 0; i < list.Count; i++) 
//		{
//			XmlElement element=xml.CreateElement("ShortcutKeyItem");
//			element.SetAttribute ("id", (i+1).ToString());
//			XmlElement elementChild1 = xml.CreateElement("TargetName");
//			elementChild1.InnerText = list [i].Path;
//			XmlElement elementChild2 = xml.CreateElement("ShortKeyName");
//			elementChild2.InnerText = list [i].Path;
//			//把节点一层一层的添加至xml中，注意他们之间的先后顺序，这是生成XML文件的顺序
//			element.AppendChild(elementChild1);
//			element.AppendChild(elementChild2);
//			root.AppendChild(element);
//		}
//		xml.AppendChild (root);
//		xml.Save(savePath);
//	}
//
//	private List<ShortItem> LoadShortcutKeyFromFile(string savePath,ShortType sType)
//	{
//		if (!File.Exists (savePath))
//			return null;
//		List<ShortItem> itemList = new List<ShortItem> ();
//		XmlDocument xml = new XmlDocument ();
//		xml.Load (savePath);
//		XmlNodeList xnlList = xml.SelectSingleNode ("KeyData").ChildNodes;
//		string tn = "", sn = "";
//		for (int i = 0; i < xnlList.Count; i++) 
//		{
//			XmlElement xel = xnlList [i] as XmlElement;
//			if(xel.GetAttribute("id")==(i+1).ToString())
//			{
//				foreach (XmlNode item in xel.ChildNodes) 
//				{
//					if (item.Name.Equals ("TargetName"))
//						tn = item.InnerText;
//					if (item.Name.Equals ("ShortKeyName"))
//						sn = item.InnerText;
//				}
//				if (tn.Split('/')[0].Equals(sType.ToString()))
//					itemList.Add(new ShortItem(tn, sn));
//			}
//
//		}
//		return itemList;
//	}
//}