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
	
	private static string ShortcutPath 
	{
		get { return Application.dataPath + "/ShortcutKeyTool/Editor/ShortcutKeyEditor.cs";}
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

	private ShortKeyCodeItem ski;
	private List<ShortKeyCodeItem> mSkiList;
	private Vector2 scrollPositon;
	private bool folderOut;
	
	void Awake()
	{
		ski=new ShortKeyCodeItem();
		mSkiList = new List<ShortKeyCodeItem> ();
		mSkiList = LoadShortcutKeyFromFile (ShortcutSavePath);
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
			ski=new ShortKeyCodeItem("Editor1/Editor2/Editor3","");
			Debug.LogFormat("add {0} {1} {2} {3} ",ski.TargetName,ski.ShortKeyName,ski.MenuItemName,ski.FuncName);
			if(mSkiList==null)
				mSkiList=new List<ShortKeyCodeItem>();
			mSkiList.Add(ski);
		}
		if (GUILayout.Button("save"))
		{
			//TODO: save to disk!
			//save to script
			SaveShortcutKey2File (ShortcutSavePath,mSkiList);
			SaveShortcutKey2EditorCode(ShortcutPath,mSkiList);
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

	void ShowItem(ShortKeyCodeItem codeItem)
	{
		EditorGUILayout.BeginHorizontal();
		EditorGUILayout.LabelField("TargetName:",GUILayout.Width(85));
		codeItem.TargetName = EditorGUILayout.TextField(codeItem.TargetName, GUILayout.Width(200));
		EditorGUILayout.LabelField("ShortcutName:",GUILayout.Width(85));
		codeItem.ShortKeyName = EditorGUILayout.TextField(codeItem.ShortKeyName, GUILayout.Width(85));
		if (GUILayout.Button("delete",GUILayout.Width(70),GUILayout.Height(20)))
		{
			if (mSkiList.Contains(codeItem))
			{
				mSkiList.Remove(codeItem);
			}
		}
		EditorGUILayout.EndHorizontal();
	}
	
	private void SaveShortcutKey2EditorCode(string strFilePath,List<ShortKeyCodeItem> skiList)
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

	private void SaveShortcutKey2File(string savePath,List<ShortKeyCodeItem> list)
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

	private List<ShortKeyCodeItem> LoadShortcutKeyFromFile(string savePath)
	{
		if (!File.Exists (savePath))
			return null;
		List<ShortKeyCodeItem> itemList = new List<ShortKeyCodeItem> ();
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
					if (item.Name.Equals ("TargetName"))
						tn = item.InnerText;
					if (item.Name.Equals ("ShortKeyName"))
						sn = item.InnerText;
				}					
				itemList.Add (new ShortKeyCodeItem (tn,sn));
			}

		}
		return itemList;
	}
}

[Serializable]
public class ShortKeyCodeItem
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

	public ShortKeyCodeItem()
	{
		TargetName = "";
		ShortKeyName = "";
	}

	public ShortKeyCodeItem(string _targetName,string _shortcutName)
	{
		TargetName = "";
		ShortKeyName = "";
		TargetName = _targetName;
		ShortKeyName = _shortcutName;
	}
}