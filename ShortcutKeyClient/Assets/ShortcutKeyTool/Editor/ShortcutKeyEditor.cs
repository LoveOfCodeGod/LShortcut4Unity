using UnityEditor;

public class ShortcutKeyEditor
{
		[MenuItem("LLL/ShortcutKey/NewScene ")]
		static void ShortcutKey_FileNewScene()
		{
			EditorApplication.ExecuteMenuItem("File/New Scene");
		}

		[MenuItem("LLL/ShortcutKey/OpenScene ")]
		static void ShortcutKey_FileOpenScene()
		{
			EditorApplication.ExecuteMenuItem("File/Open Scene");
		}

		[MenuItem("LLL/ShortcutKey/SaveScenes ")]
		static void ShortcutKey_FileSaveScenes()
		{
			EditorApplication.ExecuteMenuItem("File/Save Scenes");
		}

		[MenuItem("LLL/ShortcutKey/SaveSceneas... ")]
		static void ShortcutKey_FileSaveSceneas()
		{
			EditorApplication.ExecuteMenuItem("File/Save Scene as...");
		}

		[MenuItem("LLL/ShortcutKey/NewProject... ")]
		static void ShortcutKey_FileNewProject()
		{
			EditorApplication.ExecuteMenuItem("File/New Project...");
		}

		[MenuItem("LLL/ShortcutKey/OpenProject... ")]
		static void ShortcutKey_FileOpenProject()
		{
			EditorApplication.ExecuteMenuItem("File/Open Project...");
		}

		[MenuItem("LLL/ShortcutKey/SaveProject ")]
		static void ShortcutKey_FileSaveProject()
		{
			EditorApplication.ExecuteMenuItem("File/Save Project");
		}

		[MenuItem("LLL/ShortcutKey/BuildSettings... ")]
		static void ShortcutKey_FileBuildSettings()
		{
			EditorApplication.ExecuteMenuItem("File/Build Settings...");
		}

		[MenuItem("LLL/ShortcutKey/Build&Run ")]
		static void ShortcutKey_FileBuildRun()
		{
			EditorApplication.ExecuteMenuItem("File/Build & Run");
		}

		[MenuItem("LLL/ShortcutKey/Close ")]
		static void ShortcutKey_FileClose()
		{
			EditorApplication.ExecuteMenuItem("File/Close");
		}

		[MenuItem("LLL/ShortcutKey/Undo ")]
		static void ShortcutKey_EditUndo()
		{
			EditorApplication.ExecuteMenuItem("Edit/Undo");
		}

		[MenuItem("LLL/ShortcutKey/Redo ")]
		static void ShortcutKey_EditRedo()
		{
			EditorApplication.ExecuteMenuItem("Edit/Redo");
		}

		[MenuItem("LLL/ShortcutKey/Cut ")]
		static void ShortcutKey_EditCut()
		{
			EditorApplication.ExecuteMenuItem("Edit/Cut");
		}

		[MenuItem("LLL/ShortcutKey/Copy ")]
		static void ShortcutKey_EditCopy()
		{
			EditorApplication.ExecuteMenuItem("Edit/Copy");
		}

		[MenuItem("LLL/ShortcutKey/Paste ")]
		static void ShortcutKey_EditPaste()
		{
			EditorApplication.ExecuteMenuItem("Edit/Paste");
		}

		[MenuItem("LLL/ShortcutKey/Duplicate ")]
		static void ShortcutKey_EditDuplicate()
		{
			EditorApplication.ExecuteMenuItem("Edit/Duplicate");
		}

		[MenuItem("LLL/ShortcutKey/Delete ")]
		static void ShortcutKey_EditDelete()
		{
			EditorApplication.ExecuteMenuItem("Edit/Delete");
		}

		[MenuItem("LLL/ShortcutKey/FrameSelected ")]
		static void ShortcutKey_EditFrameSelected()
		{
			EditorApplication.ExecuteMenuItem("Edit/Frame Selected");
		}

		[MenuItem("LLL/ShortcutKey/LockViewtoSelected ")]
		static void ShortcutKey_EditLockViewtoSelected()
		{
			EditorApplication.ExecuteMenuItem("Edit/Lock View to Selected");
		}

		[MenuItem("LLL/ShortcutKey/Find ")]
		static void ShortcutKey_EditFind()
		{
			EditorApplication.ExecuteMenuItem("Edit/Find");
		}

		[MenuItem("LLL/ShortcutKey/SelectAll ")]
		static void ShortcutKey_EditSelectAll()
		{
			EditorApplication.ExecuteMenuItem("Edit/Select All");
		}

		[MenuItem("LLL/ShortcutKey/Play ")]
		static void ShortcutKey_EditPlay()
		{
			EditorApplication.ExecuteMenuItem("Edit/Play");
		}

		[MenuItem("LLL/ShortcutKey/Pause ")]
		static void ShortcutKey_EditPause()
		{
			EditorApplication.ExecuteMenuItem("Edit/Pause");
		}

		[MenuItem("LLL/ShortcutKey/Step ")]
		static void ShortcutKey_EditStep()
		{
			EditorApplication.ExecuteMenuItem("Edit/Step");
		}

		[MenuItem("LLL/ShortcutKey/Signin... ")]
		static void ShortcutKey_EditSignin()
		{
			EditorApplication.ExecuteMenuItem("Edit/Sign in...");
		}

		[MenuItem("LLL/ShortcutKey/Signout ")]
		static void ShortcutKey_EditSignout()
		{
			EditorApplication.ExecuteMenuItem("Edit/Sign out");
		}

		[MenuItem("LLL/ShortcutKey/Input #i")]
		static void ShortcutKey_EditProjectSettingsInput()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Input");
		}

		[MenuItem("LLL/ShortcutKey/TagsandLayers #l")]
		static void ShortcutKey_EditProjectSettingsTagsandLayers()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Tags and Layers");
		}

		[MenuItem("LLL/ShortcutKey/Audio #a")]
		static void ShortcutKey_EditProjectSettingsAudio()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Audio");
		}

		[MenuItem("LLL/ShortcutKey/Time #t")]
		static void ShortcutKey_EditProjectSettingsTime()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Time");
		}

		[MenuItem("LLL/ShortcutKey/Player _p")]
		static void ShortcutKey_EditProjectSettingsPlayer()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
		}

		[MenuItem("LLL/ShortcutKey/Physics #p")]
		static void ShortcutKey_EditProjectSettingsPhysics()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Physics");
		}

		[MenuItem("LLL/ShortcutKey/Physics2D #&p")]
		static void ShortcutKey_EditProjectSettingsPhysics2D()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Physics 2D");
		}

		[MenuItem("LLL/ShortcutKey/Quality #q")]
		static void ShortcutKey_EditProjectSettingsQuality()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Quality");
		}

		[MenuItem("LLL/ShortcutKey/Graphics #g")]
		static void ShortcutKey_EditProjectSettingsGraphics()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Graphics");
		}

		[MenuItem("LLL/ShortcutKey/Network _n")]
		static void ShortcutKey_EditProjectSettingsNetwork()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Network");
		}

		[MenuItem("LLL/ShortcutKey/Editor #e")]
		static void ShortcutKey_EditProjectSettingsEditor()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Editor");
		}

		[MenuItem("LLL/ShortcutKey/ScriptExecutionOrder _s")]
		static void ShortcutKey_EditProjectSettingsScriptExecutionOrder()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Script Execution Order");
		}

		[MenuItem("LLL/ShortcutKey/ClusterInput _c")]
		static void ShortcutKey_EditProjectSettingsClusterInput()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Cluster Input");
		}

		[MenuItem("LLL/ShortcutKey/SnapSettings... #c")]
		static void ShortcutKey_EditSnapSettings()
		{
			EditorApplication.ExecuteMenuItem("Edit/Snap Settings...");
		}

		[MenuItem("LLL/ShortcutKey/Folder #n")]
		static void ShortcutKey_AssetsCreateFolder()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Folder");
		}

		[MenuItem("LLL/ShortcutKey/C#Script #&n")]
		static void ShortcutKey_AssetsCreateCScript()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/C# Script");
		}

		[MenuItem("LLL/ShortcutKey/Javascript #&j")]
		static void ShortcutKey_AssetsCreateJavascript()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Javascript");
		}

		[MenuItem("LLL/ShortcutKey/UnlitShader #s")]
		static void ShortcutKey_AssetsCreateShaderUnlitShader()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Shader/Unlit Shader");
		}

		[MenuItem("LLL/ShortcutKey/EditorTestC#Script #&t")]
		static void ShortcutKey_AssetsCreateTestingEditorTestCScript()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Testing/Editor Test C# Script");
		}

		[MenuItem("LLL/ShortcutKey/Scene #&s")]
		static void ShortcutKey_AssetsCreateScene()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Scene");
		}

		[MenuItem("LLL/ShortcutKey/Prefab #b")]
		static void ShortcutKey_AssetsCreatePrefab()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Prefab");
		}

		[MenuItem("LLL/ShortcutKey/AudioMixer _m")]
		static void ShortcutKey_AssetsCreateAudioMixer()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Audio Mixer");
		}

		[MenuItem("LLL/ShortcutKey/Material #m")]
		static void ShortcutKey_AssetsCreateMaterial()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Material");
		}

		[MenuItem("LLL/ShortcutKey/LensFlare ")]
		static void ShortcutKey_AssetsCreateLensFlare()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Lens Flare");
		}

		[MenuItem("LLL/ShortcutKey/RenderTexture ")]
		static void ShortcutKey_AssetsCreateRenderTexture()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Render Texture");
		}

		[MenuItem("LLL/ShortcutKey/LightmapParameters ")]
		static void ShortcutKey_AssetsCreateLightmapParameters()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Lightmap Parameters");
		}

}