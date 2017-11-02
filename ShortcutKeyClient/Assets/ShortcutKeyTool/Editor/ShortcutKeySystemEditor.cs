using UnityEditor;

public class ShortcutKeySystemEditor
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

		[MenuItem("LLL/ShortcutKey/Input _i")]
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

		[MenuItem("LLL/ShortcutKey/Time _t")]
		static void ShortcutKey_EditProjectSettingsTime()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Time");
		}

		[MenuItem("LLL/ShortcutKey/Player _p")]
		static void ShortcutKey_EditProjectSettingsPlayer()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
		}

		[MenuItem("LLL/ShortcutKey/Physics #&p")]
		static void ShortcutKey_EditProjectSettingsPhysics()
		{
			EditorApplication.ExecuteMenuItem("Edit/Project Settings/Physics");
		}

		[MenuItem("LLL/ShortcutKey/Physics2D ")]
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

		[MenuItem("LLL/ShortcutKey/Prefab ")]
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

		[MenuItem("LLL/ShortcutKey/LensFlare # ")]
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

		[MenuItem("LLL/ShortcutKey/AnimatorController ")]
		static void ShortcutKey_AssetsCreateAnimatorController()
		{
			EditorApplication.ExecuteMenuItem("Assets/Create/Animator Controller");
		}

		[MenuItem("LLL/ShortcutKey/RevealinFinder %#f")]
		static void ShortcutKey_AssetsRevealinFinder()
		{
			EditorApplication.ExecuteMenuItem("Assets/Reveal in Finder");
		}

		[MenuItem("LLL/ShortcutKey/Open #o")]
		static void ShortcutKey_AssetsOpen()
		{
			EditorApplication.ExecuteMenuItem("Assets/Open");
		}

		[MenuItem("LLL/ShortcutKey/Delete #d")]
		static void ShortcutKey_AssetsDelete()
		{
			EditorApplication.ExecuteMenuItem("Assets/Delete");
		}

		[MenuItem("LLL/ShortcutKey/OpenC#Project %#o")]
		static void ShortcutKey_AssetsOpenCProject()
		{
			EditorApplication.ExecuteMenuItem("Assets/Open C# Project");
		}

		[MenuItem("LLL/ShortcutKey/CreateEmpty ")]
		static void ShortcutKey_GameObjectCreateEmpty()
		{
			EditorApplication.ExecuteMenuItem("GameObject/Create Empty");
		}

		[MenuItem("LLL/ShortcutKey/Cube ")]
		static void ShortcutKey_GameObject3DObjectCube()
		{
			EditorApplication.ExecuteMenuItem("GameObject/3D Object/Cube");
		}

		[MenuItem("LLL/ShortcutKey/Sphere ")]
		static void ShortcutKey_GameObject3DObjectSphere()
		{
			EditorApplication.ExecuteMenuItem("GameObject/3D Object/Sphere");
		}

		[MenuItem("LLL/ShortcutKey/Plane ")]
		static void ShortcutKey_GameObject3DObjectPlane()
		{
			EditorApplication.ExecuteMenuItem("GameObject/3D Object/Plane");
		}

		[MenuItem("LLL/ShortcutKey/Quad ")]
		static void ShortcutKey_GameObject3DObjectQuad()
		{
			EditorApplication.ExecuteMenuItem("GameObject/3D Object/Quad");
		}

		[MenuItem("LLL/ShortcutKey/DirectionalLight ")]
		static void ShortcutKey_GameObjectLightDirectionalLight()
		{
			EditorApplication.ExecuteMenuItem("GameObject/Light/Directional Light");
		}

		[MenuItem("LLL/ShortcutKey/PointLight ")]
		static void ShortcutKey_GameObjectLightPointLight()
		{
			EditorApplication.ExecuteMenuItem("GameObject/Light/Point Light");
		}

		[MenuItem("LLL/ShortcutKey/SpotLight ")]
		static void ShortcutKey_GameObjectLightSpotLight()
		{
			EditorApplication.ExecuteMenuItem("GameObject/Light/SpotLight");
		}

		[MenuItem("LLL/ShortcutKey/AudioSource ")]
		static void ShortcutKey_GameObjectAudioAudioSource()
		{
			EditorApplication.ExecuteMenuItem("GameObject/Audio/Audio Source");
		}

		[MenuItem("LLL/ShortcutKey/Text #t")]
		static void ShortcutKey_GameObjectUIText()
		{
			EditorApplication.ExecuteMenuItem("GameObject/UI/Text");
		}

		[MenuItem("LLL/ShortcutKey/Image #i")]
		static void ShortcutKey_GameObjectUIImage()
		{
			EditorApplication.ExecuteMenuItem("GameObject/UI/Image");
		}

		[MenuItem("LLL/ShortcutKey/Button #b")]
		static void ShortcutKey_GameObjectUIButton()
		{
			EditorApplication.ExecuteMenuItem("GameObject/UI/Button");
		}

		[MenuItem("LLL/ShortcutKey/Panel #p")]
		static void ShortcutKey_GameObjectUIPanel()
		{
			EditorApplication.ExecuteMenuItem("GameObject/UI/Panel");
		}

		[MenuItem("LLL/ShortcutKey/2by3 ")]
		static void ShortcutKey_WindowLayouts2by3()
		{
			EditorApplication.ExecuteMenuItem("Window/Layouts/2 by 3");
		}

		[MenuItem("LLL/ShortcutKey/SpritePacker ")]
		static void ShortcutKey_WindowSpritePacker()
		{
			EditorApplication.ExecuteMenuItem("Window/Sprite Packer");
		}

		[MenuItem("LLL/ShortcutKey/EditorTestsRunner %#e")]
		static void ShortcutKey_WindowEditorTestsRunner()
		{
			EditorApplication.ExecuteMenuItem("Window/Editor Tests Runner");
		}

		[MenuItem("LLL/ShortcutKey/Lighting #l")]
		static void ShortcutKey_WindowLighting()
		{
			EditorApplication.ExecuteMenuItem("Window/Lighting");
		}

		[MenuItem("LLL/ShortcutKey/UnityManual #u")]
		static void ShortcutKey_HelpUnityManual()
		{
			EditorApplication.ExecuteMenuItem("Help/Unity Manual");
		}

		[MenuItem("LLL/ShortcutKey/ScriptingReference #r")]
		static void ShortcutKey_HelpScriptingReference()
		{
			EditorApplication.ExecuteMenuItem("Help/Scripting Reference");
		}

}