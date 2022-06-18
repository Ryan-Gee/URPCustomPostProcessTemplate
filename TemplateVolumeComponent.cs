using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Serializable, VolumeComponentMenuForRenderPipeline("Custom/CustomEffectComponent", typeof(UniversalRenderPipeline))]
public class TemplateVolumeComponent : VolumeComponent, IPostProcessComponent
{
	// For example, an intensity parameter that goes from 0 to 1
	public ClampedFloatParameter intensity = new ClampedFloatParameter(value: 0, min: 0, max: 20, overrideState: true);


	// Tells when our effect should be rendered
	public bool IsActive() => intensity.value > 0;

	public bool IsTileCompatible() => true;
}