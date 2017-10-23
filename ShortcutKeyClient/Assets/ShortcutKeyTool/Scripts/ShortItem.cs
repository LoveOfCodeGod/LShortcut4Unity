using System;

[Serializable]
public class ShortItem
{
	private string m_Path;
	private string m_ShortKey;
	private bool m_WriteEnable;
	private ShortType m_BlongTo;

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

	public ShortItem(string path,string shortkey)
	{
		m_Path = path;
		m_ShortKey = shortkey;
		m_BlongTo=ShortType.Extension;
	}
}
