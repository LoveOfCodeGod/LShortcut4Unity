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
	private static string shortcutPath = "";
	private static string shortcutSavePath="";
	private static string tipsLabelText = "* %->commond #->shift &->ctrl _a->keyboard[A]";
	
	[MenuItem("LLL/Tools/ShortcutWindow _o",false,3)]
	static void SetUpShortcutWindow()
	{
		ShortcutWindowEditor myWindow =
			(ShortcutWindowEditor) EditorWindow.GetWindow(typeof(ShortcutWindowEditor), true, "Shortcut Key");
		myWindow.Show();
	}

	private ShortcutKeyItem ski;
	private List<ShortcutKeyItem> mSkiList;
	private Vector2 scrollPositon;
	private bool folderOut;
	
	void Awake()
	{
		shortcutPath = Application.dataPath + "/ShortcutKeyTool/Editor/ShortcutKeyEditor.cs";
		shortcutSavePath = Application.dataPath + "/ShortcutKeyTool/Res/ShortcutKeyData.xml";
		ski=new ShortcutKeyItem();
		mSkiList = new List<ShortcutKeyItem> ();
		mSkiList = LoadShortcutKeyFromFile (shortcutSavePath);
		scrollPositon = new Vector2(300, 500);
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
		folderOut = EditorGUILayout.Foldout(folderOut,"File");
		if (folderOut)
		{
			//show
			scrollPositon =EditorGUILayout.BeginScrollView(scrollPositon);
			if (mSkiList!=null && mSkiList.Count > 0)
			{
				for (int i = 0; i < mSkiList.Count; i++)
				{
					ShowItem(mSkiList[i]);
				}
			}
			EditorGUILayout.EndScrollView();
		}
		//button
		EditorGUILayout.BeginHorizontal();
		if(GUILayout.Button("add"))
		{
			ski=new ShortcutKeyItem("Editor1/Editor2/Editor3","");
			Debug.LogFormat("add {0} {1} {2} {3} ",ski.TargetName,ski.ShortKeyName,ski.MenuItemName,ski.FuncName);
			if(mSkiList==null)
				mSkiList=new List<ShortcutKeyItem>();
			mSkiList.Add(ski);
		}
		if (GUILayout.Button("save"))
		{
			//TODO: save to disk!
			//save to script
			SaveShortcutKey2File (shortcutSavePath,mSkiList);
			SaveShortcutKey2EditorCode(shortcutPath,mSkiList);
			Debug.Log("Save!");
		}
		EditorGUILayout.EndHorizontal();
		GUILayout.Space(10);
	}

	void OnDestroy()
	{
		if (mSkiList != null)
		{
			mSkiList.Clear ();
			mSkiList = null;
		}
	}

	void ShowItem(ShortcutKeyItem item)
	{
		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField("TargetName:",GUILayout.Width(85));
		item.TargetName = EditorGUILayout.TextField(item.TargetName, GUILayout.Width(200));
		EditorGUILayout.LabelField("ShortcutName:",GUILayout.Width(85));
		item.ShortKeyName = EditorGUILayout.TextField(item.ShortKeyName, GUILayout.Width(85));
		if (GUILayout.Button("delete",GUILayout.Width(70),GUILayout.Height(20)))
		{
			if (mSkiList.Contains(item))
			{
				mSkiList.Remove(item);
			}
		}
		EditorGUILayout.EndHorizontal();
	}
	
	private void SaveShortcutKey2EditorCode(string path,List<ShortcutKeyItem> skiList)
	{
		Debug.Log(path);
		string strDlg = path.Substring(path.LastIndexOf('/')+1).Split('.')[0];
		string strFilePath = path;
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
				strBuilder.Append("\t\t").AppendFormat("[MenuItem(\"LLL/ShortcutKey/{0} {1}\")]",skiList[i].MenuItemName,skiList[i].ShortKeyName).AppendLine();
				strBuilder.Append("\t\t").AppendFormat("static void ShortcutKey_{0}()",skiList[i].FuncName).AppendLine();
				strBuilder.Append("\t\t").AppendLine("{");
				strBuilder.Append("\t\t").Append("\t").AppendFormat("EditorApplication.ExecuteMenuItem(\"{0}\");",skiList[i].TargetName).AppendLine();
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

	private void SaveShortcutKey2File(string savePath,List<ShortcutKeyItem> list)
	{
		FileStream fs=null;
		if (!File.Exists (savePath))
			fs = File.Create (savePath);
		XmlDocument xml = new XmlDocument ();
		XmlElement root = xml.CreateElement ("KeyData");
		//创建子节点
		for (int i = 0; i < list.Count; i++) 
		{
			Debug.Log (list [i].TargetName);
			XmlElement element=xml.CreateElement("ShortcutKeyItem");
			element.SetAttribute ("id", (i+1).ToString());
			XmlElement elementChild1 = xml.CreateElement("TargetName");
			elementChild1.InnerText = list [i].TargetName;
			XmlElement elementChild2 = xml.CreateElement("ShortKeyName");
			elementChild2.InnerText = list [i].ShortKeyName;
			//把节点一层一层的添加至xml中，注意他们之间的先后顺序，这是生成XML文件的顺序
			element.AppendChild(elementChild1);
			element.AppendChild(elementChild2);
			root.AppendChild(element);
		}
		xml.AppendChild (root);
		xml.Save (savePath);
	}

	private List<ShortcutKeyItem> LoadShortcutKeyFromFile(string savePath)
	{
		if (!File.Exists (savePath))
			return null;
		List<ShortcutKeyItem> itemList = new List<ShortcutKeyItem> ();
		XmlDocument xml = new XmlDocument ();
		xml.Load (savePath);
		Debug.Log ("lalalallalal"+typeof(ShortcutKeyItem).Name);
		XmlNodeList xnlList = xml.SelectSingleNode ("KeyData").ChildNodes;
		string tn = "", sn = "";
		for (int i = 0; i < xnlList.Count; i++) 
		{
			XmlElement xel = xnlList [i] as XmlElement;
			if(xel.GetAttribute("id")==(i+1).ToString())
			{
				foreach (XmlNode item in xel.ChildNodes) 
				{
					if (item.Name.Equals ("TargetName"))
						tn = item.InnerText;
					if (item.Name.Equals ("ShortKeyName"))
						sn = item.InnerText;
				}					
				itemList.Add (new ShortcutKeyItem (tn,sn));
			}

		}
		return itemList;
	}
}

[Serializable]
public class ShortcutKeyItem
{
	public string TargetName;
	public string ShortKeyName;

	public string MenuItemName
	{
		get
		{
			if (string.IsNullOrEmpty(TargetName))
				return null;
			return TargetName.Substring(TargetName.LastIndexOf('/')+1).Replace(" ","");
		}
	}

	public string FuncName
	{
		get
		{
			if (string.IsNullOrEmpty(TargetName))
				return null;
			return TargetName.Replace("/", "").Replace(" ","").Replace("...","").Replace("&","").Replace("#","");
		}
	}

	public ShortcutKeyItem()
	{
		TargetName = "";
		ShortKeyName = "";
	}

	public ShortcutKeyItem(string _targetName,string _shortcutName)
	{
		TargetName = "";
		ShortKeyName = "";
		TargetName = _targetName;
		ShortKeyName = _shortcutName;
	}
}
//
//[MenuItem("LLL/ShortcutKey/Player _p")]
//static void ShortcutKey_ProjectSettingsPlayer()
//{
//EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
//}
//	
//[MenuItem("LLL/ShortcutKey/CreateFolder #f")]
//static void ShortcutKey_CreateFolder()
//{
//EditorApplication.ExecuteMenuItem("Assets/Create/Folder");
//}
//[MenuItem("LLL/ShortcutKey/RevealInFinder #r")]
//static void ShortcutKey_RevealInFinder()
//{
//EditorApplication.ExecuteMenuItem("Assets/Reveal in Finder");
//}
//	
//[MenuItem("LLL/ShortcutKey/Open #o")]
//static void ShortcutKey_Open()
//{
//EditorApplication.ExecuteMenuItem("Assets/Open");
//}