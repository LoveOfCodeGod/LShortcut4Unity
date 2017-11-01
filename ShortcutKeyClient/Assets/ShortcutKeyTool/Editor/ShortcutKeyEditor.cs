using UnityEditor;

public class ShortcutKeyEditor
{
		[MenuItem("LLL/ShortcutKey/ShortcutWindow _o")]
		static void ShortcutKey_LLLToolsShortcutWindow()
		{
			EditorApplication.ExecuteMenuItem("LLL/Tools/ShortcutWindow");
		}

}