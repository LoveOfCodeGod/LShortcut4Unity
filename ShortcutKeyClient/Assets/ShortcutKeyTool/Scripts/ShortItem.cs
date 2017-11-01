using System;
using System.Linq;

[Serializable]
public class ShortItem
{
	private static string[] popupKEYStr = ShortKeyCode.popupKEYDict.Keys.ToArray();
	
	private string m_Path;
	private string m_ShortKey;
	private bool m_WriteEnable;
	private ShortType m_BlongTo;
	private int m_KeySelectIndex;
	
	/// <summary>
	/// 辅助键
	/// </summary>
	public int AIDSelectIndex { get; set; }
	
	public bool AIDShift { get; set; }
	public bool AIDCommand { get; set; }
	public bool AIDCtrl { get; set; }

	public bool AIDSingle
	{
		get
		{
			if (AIDShift || AIDCommand || AIDCtrl)
				return false;
			return true;
		}
		set
		{
			if (value)
			{
				AIDShift = false;
				AIDCommand = false;
				AIDCtrl = false;
			}
		}
	}

	/// <summary>
	/// 辅助键
	/// </summary>
	public int KeySelectIndex
	{
		get { return m_KeySelectIndex; }
		set { m_KeySelectIndex = value; }
	}

	public string Path
	{
		get { return m_Path; }
		set { m_Path = value; }
	}
	
	public string ShortKey
	{
		get { return m_ShortKey; }
		set { m_ShortKey = value; }
	}

	public bool WriteEnable
	{
		get { return m_WriteEnable; }
		set { m_WriteEnable = value; }
	}

	public ShortType BlongTo
	{
		get { return m_BlongTo; }
		set { m_BlongTo = value; }
	}
	
	public string MenuItemName
	{
		get
		{
			if (string.IsNullOrEmpty(m_Path))
				return null;
			return m_Path.Substring(m_Path.LastIndexOf('/')+1).Replace(" ","");
		}
	}

	public string FuncName
	{
		get
		{
			if (string.IsNullOrEmpty(m_Path))
				return null;
			return m_Path.Replace("/", "").Replace(" ","").Replace("...","").Replace("&","").Replace("#","");
		}
	}

	public ShortItem():this(String.Empty, String.Empty)
	{
		
	}

	public ShortItem(string path,string shortkey,ShortType shortType=ShortType.Extension)
	{
		SetData(path,shortkey,shortType);
	}

	public void SetData(string path,string shortkey,ShortType shortType=ShortType.Extension)
	{
		m_Path = path;
		m_ShortKey = shortkey;
		m_BlongTo=shortType;
		if (!string.IsNullOrEmpty(shortkey))
			UpdateKeySelectIndex(shortkey[shortkey.Length - 1].ToString());
	}

	public void SetKey(string key)
	{
		string tmpKey = String.Empty;
		if (AIDCommand)
			tmpKey += ShortKeyCode.Command;
		if (AIDShift)
			tmpKey += ShortKeyCode.Shift;
		if (AIDCtrl)
			tmpKey += ShortKeyCode.Control;
		tmpKey += key;
		if (AIDSingle)
			tmpKey = ShortKeyCode.NormalKey + key;
		if(string.IsNullOrEmpty(key))
			tmpKey=String.Empty;
		m_ShortKey = tmpKey;
	}
	
	private void UpdateKeySelectIndex(string keyword)
	{
		
		for (int i = 0; i < popupKEYStr.Length; i++)
		{
			if (ShortKeyCode.popupKEYDict[popupKEYStr[i]].Equals(keyword))
			{
				m_KeySelectIndex = i;
				break;
			}
		}
	}
}
