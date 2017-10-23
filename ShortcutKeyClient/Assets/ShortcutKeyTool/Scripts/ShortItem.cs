public class ShortItem
{
	private string m_Path;
	private string m_ShortKey;
	private bool m_WriteEnable;
	private ShortType m_BlongTo;

	public string Path
	{
		get { return m_Path; }
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
}
