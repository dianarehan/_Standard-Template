#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Random), UnityEngineRandomWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mesh), UnityEngineMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.VFX.VisualEffect), UnityEngineVFXVisualEffectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collider), UnityEngineColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MeshCollider), UnityEngineMeshColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ConfigurableJoint), UnityEngineConfigurableJointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Material), UnityEngineMaterialWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Video.VideoPlayer), UnityEngineVideoVideoPlayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioSource), UnityEngineAudioSourceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.Spline), UnityEngineSplinesSplineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.SplineContainer), UnityEngineSplinesSplineContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.SplineAnimate), UnityEngineSplinesSplineAnimateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.SplineComponent), UnityEngineSplinesSplineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionAsset), UnityEngineInputSystemInputActionAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputAction), UnityEngineInputSystemInputActionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionReference), UnityEngineInputSystemInputActionReferenceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputDevice), UnityEngineInputSystemInputDeviceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionType), UnityEngineInputSystemInputActionTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionChange), UnityEngineInputSystemInputActionChangeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(TMPro.TMP_Text), TMProTMP_TextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(TMPro.TMP_Dropdown), TMProTMP_DropdownWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture2D), UnityEngineTexture2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Sprite), UnityEngineSpriteWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.Lua.LuaAsset), ImmerzaSDKLuaLuaAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMesh), UnityEngineAINavMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshAgent), UnityEngineAINavMeshAgentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshObstacle), UnityEngineAINavMeshObstacleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshPath), UnityEngineAINavMeshPathWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshHit), UnityEngineAINavMeshHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshData), UnityEngineAINavMeshDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshDataInstance), UnityEngineAINavMeshDataInstanceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshLinkData), UnityEngineAINavMeshLinkDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshLinkInstance), UnityEngineAINavMeshLinkInstanceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildSettings), UnityEngineAINavMeshBuildSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildSource), UnityEngineAINavMeshBuildSourceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildMarkup), UnityEngineAINavMeshBuildMarkupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback), UnityEngineXRInteractionToolkitFeedbackSimpleAudioFeedbackWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback), UnityEngineXRInteractionToolkitFeedbackSimpleHapticFeedbackWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite), UnityEngineXRInteractionToolkitInputsCompositesButtonFallbackCompositeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticControlActionManager), UnityEngineXRInteractionToolkitInputsHapticsHapticControlActionManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseCommandChannel), UnityEngineXRInteractionToolkitInputsHapticsHapticImpulseCommandChannelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseCommandChannelGroup), UnityEngineXRInteractionToolkitInputsHapticsHapticImpulseCommandChannelGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulsePlayer), UnityEngineXRInteractionToolkitInputsHapticsHapticImpulsePlayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup), UnityEngineXRInteractionToolkitInputsHapticsHapticImpulseSingleChannelGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.InputActionManager), UnityEngineXRInteractionToolkitInputsInputActionManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.IntegerFallbackComposite), UnityEngineXRInteractionToolkitInputsCompositesIntegerFallbackCompositeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel), UnityEngineXRInteractionToolkitInputsHapticsOpenXROpenXRHapticImpulseChannelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.QuaternionFallbackComposite), UnityEngineXRInteractionToolkitInputsCompositesQuaternionFallbackCompositeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction), UnityEngineXRInteractionToolkitInputsInteractionsSectorInteractionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.Vector3FallbackComposite), UnityEngineXRInteractionToolkitInputsCompositesVector3FallbackCompositeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator), UnityEngineXRInteractionToolkitInputsSimulationXRDeviceSimulatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer), UnityEngineXRInteractionToolkitInputsXRHandSkeletonPokeDisplacerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader), UnityEngineXRInteractionToolkitInputsReadersXRInputButtonReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceBoolValueReader), UnityEngineXRInteractionToolkitInputsReadersXRInputDeviceBoolValueReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceFloatValueReader), UnityEngineXRInteractionToolkitInputsReadersXRInputDeviceFloatValueReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.XRInputDeviceHapticImpulseChannel), UnityEngineXRInteractionToolkitInputsHapticsXRInputDeviceHapticImpulseChannelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.XRInputDeviceHapticImpulseChannelGroup), UnityEngineXRInteractionToolkitInputsHapticsXRInputDeviceHapticImpulseChannelGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.XRInputDeviceHapticImpulseProvider), UnityEngineXRInteractionToolkitInputsHapticsXRInputDeviceHapticImpulseProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceInputTrackingStateValueReader), UnityEngineXRInteractionToolkitInputsReadersXRInputDeviceInputTrackingStateValueReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceQuaternionValueReader), UnityEngineXRInteractionToolkitInputsReadersXRInputDeviceQuaternionValueReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceVector2ValueReader), UnityEngineXRInteractionToolkitInputsReadersXRInputDeviceVector2ValueReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputDeviceVector3ValueReader), UnityEngineXRInteractionToolkitInputsReadersXRInputDeviceVector3ValueReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.XRInputHapticImpulseProvider), UnityEngineXRInteractionToolkitInputsHapticsXRInputHapticImpulseProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager), UnityEngineXRInteractionToolkitInputsXRInputModalityManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader), UnityEngineXRInteractionToolkitInputsReadersXRInputValueReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer), UnityEngineXRInteractionToolkitInputsXRTransformStabilizerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs), UnityEngineXRInteractionToolkitActivateEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Attachment.AttachPointVelocityTracker), UnityEngineXRInteractionToolkitAttachmentAttachPointVelocityTrackerWrap.__Register);
        
        }
        
        static void wrapInit2(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster), UnityEngineXRInteractionToolkitInteractorsCastersCurveInteractionCasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController), UnityEngineXRInteractionToolkitInteractorsVisualsCurveVisualControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs), UnityEngineXRInteractionToolkitDeactivateEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs), UnityEngineXRInteractionToolkitFocusEnterEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs), UnityEngineXRInteractionToolkitFocusExitEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs), UnityEngineXRInteractionToolkitHoverEnterEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs), UnityEngineXRInteractionToolkitHoverExitEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController), UnityEngineXRInteractionToolkitAttachmentInteractionAttachControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs), UnityEngineXRInteractionToolkitInteractionGroupRegisteredEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.InteractionGroupUnregisteredEventArgs), UnityEngineXRInteractionToolkitInteractionGroupUnregisteredEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties), UnityEngineXRInteractionToolkitInteractorsVisualsLinePropertiesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor), UnityEngineXRInteractionToolkitInteractorsNearFarInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData), UnityEngineXRInteractionToolkitFilteringPokeThresholdDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatum), UnityEngineXRInteractionToolkitFilteringPokeThresholdDatumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatumProperty), UnityEngineXRInteractionToolkitFilteringPokeThresholdDatumPropertyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs), UnityEngineXRInteractionToolkitSelectEnterEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs), UnityEngineXRInteractionToolkitSelectExitEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster), UnityEngineXRInteractionToolkitInteractorsCastersSphereInteractionCasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter), UnityEngineXRInteractionToolkitFilteringTouchscreenHoverFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRAngleGazeEvaluator), UnityEngineXRInteractionToolkitFilteringXRAngleGazeEvaluatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor), UnityEngineXRInteractionToolkitInteractorsXRDirectInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRDistanceEvaluator), UnityEngineXRInteractionToolkitFilteringXRDistanceEvaluatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer), UnityEngineXRInteractionToolkitTransformersXRDualGrabFreeTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance), UnityEngineXRInteractionToolkitGazeXRGazeAssistanceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor), UnityEngineXRInteractionToolkitInteractorsXRGazeInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer), UnityEngineXRInteractionToolkitTransformersXRGeneralGrabTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume), UnityEngineXRInteractionToolkitInteractablesXRInteractableSnapVolumeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup), UnityEngineXRInteractionToolkitInteractorsXRInteractionGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual), UnityEngineXRInteractionToolkitInteractorsVisualsXRInteractorLineVisualWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual), UnityEngineXRInteractionToolkitInteractorsVisualsXRInteractorReticleVisualWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRLastSelectedEvaluator), UnityEngineXRInteractionToolkitFilteringXRLastSelectedEvaluatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter), UnityEngineXRInteractionToolkitFilteringXRPokeFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor), UnityEngineXRInteractionToolkitInteractorsXRPokeInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable), UnityEngineXRInteractionToolkitInteractablesXRSimpleInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer), UnityEngineXRInteractionToolkitTransformersXRSingleGrabFreeTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer), UnityEngineXRInteractionToolkitTransformersXRSocketGrabTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor), UnityEngineXRInteractionToolkitInteractorsXRSocketInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual), UnityEngineXRInteractionToolkitInteractablesVisualsXRTintInteractableVisualWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator), UnityEngineXRInteractionToolkitLocomotionCharacterControllerBodyManipulatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable), UnityEngineXRInteractionToolkitLocomotionClimbingClimbInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider), UnityEngineXRInteractionToolkitLocomotionClimbingClimbProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbSettings), UnityEngineXRInteractionToolkitLocomotionClimbingClimbSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbSettingsDatum), UnityEngineXRInteractionToolkitLocomotionClimbingClimbSettingsDatumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbSettingsDatumProperty), UnityEngineXRInteractionToolkitLocomotionClimbingClimbSettingsDatumPropertyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor), UnityEngineXRInteractionToolkitLocomotionClimbingClimbTeleportInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider), UnityEngineXRInteractionToolkitLocomotionMovementContinuousMoveProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider), UnityEngineXRInteractionToolkitLocomotionTurningContinuousTurnProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation), UnityEngineXRInteractionToolkitLocomotionDelegateXRBodyTransformationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.FurthestTeleportationAnchorFilter), UnityEngineXRInteractionToolkitLocomotionTeleportationFurthestTeleportationAnchorFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter), UnityEngineXRInteractionToolkitLocomotionTeleportationGazeTeleportationAnchorFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.LocomotionMediator), UnityEngineXRInteractionToolkitLocomotionLocomotionMediatorWrap.__Register);
        
        }
        
        static void wrapInit3(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider), UnityEngineXRInteractionToolkitLocomotionComfortLocomotionVignetteProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider), UnityEngineXRInteractionToolkitLocomotionTurningSnapTurnProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportationAnchorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportationAreaWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationMultiAnchorVolume), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportationMultiAnchorVolumeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportationProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportingEventArgs), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportingEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportVolumeDestinationSettings), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportVolumeDestinationSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportVolumeDestinationSettingsDatum), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportVolumeDestinationSettingsDatumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportVolumeDestinationSettingsDatumProperty), UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportVolumeDestinationSettingsDatumPropertyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController), UnityEngineXRInteractionToolkitLocomotionComfortTunnelingVignetteControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider), UnityEngineXRInteractionToolkitLocomotionMovementTwoHandedGrabMoveProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.UnderCameraBodyPositionEvaluator), UnityEngineXRInteractionToolkitLocomotionUnderCameraBodyPositionEvaluatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyGroundPosition), UnityEngineXRInteractionToolkitLocomotionXRBodyGroundPositionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyScale), UnityEngineXRInteractionToolkitLocomotionXRBodyScaleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer), UnityEngineXRInteractionToolkitLocomotionXRBodyTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyYawRotation), UnityEngineXRInteractionToolkitLocomotionXRBodyYawRotationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRCameraForwardXZAlignment), UnityEngineXRInteractionToolkitLocomotionXRCameraForwardXZAlignmentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody), UnityEngineXRInteractionToolkitLocomotionXRMovableBodyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginMovement), UnityEngineXRInteractionToolkitLocomotionXROriginMovementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginUpAlignment), UnityEngineXRInteractionToolkitLocomotionXROriginUpAlignmentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility), UnityEngineXRInteractionToolkitUtilitiesGradientUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Unity.XR.CoreUtils.XROrigin), UnityXRCoreUtilsXROriginWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.BreathingDetection), ImmerzaSDKBreathingDetectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.ImmerzaEvents), ImmerzaSDKImmerzaEventsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.MultipathContainer), ImmerzaSDKMultipathContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.Lua.LuaComponent), ImmerzaSDKLuaLuaComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            wrapInit2(luaenv, translator);
            
            wrapInit3(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
