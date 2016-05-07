using UnityEngine;
using System.Collections;

public class LightFader : MonoBehaviour {

	public Light cleanFadingLight;
	public Light cookieFadingLight;

	public float fadeRate;

	public Material startMaterial;
	public Material endMaterial;

	public float fadeDelay;

	void Start () {
		StartCoroutine(LightFade(cleanFadingLight, cookieFadingLight));
		print("Faders started.");
	}

	IEnumerator LightFade (Light cleanFadingLight, Light cookieFadingLight)
	{
		
		while (Application.isPlaying) {
			if (cleanFadingLight.intensity > 0f && Time.timeSinceLevelLoad <= 60f*20f) {
				cleanFadingLight.intensity = Mathf.Lerp (cleanFadingLight.intensity, cleanFadingLight.intensity - 0.1f, fadeRate);
			
			} else if (cookieFadingLight.intensity > 0f && Time.timeSinceLevelLoad > 60f*20f) {

				if (RenderSettings.skybox == startMaterial) {
					RenderSettings.skybox = endMaterial;
				}

				if (cleanFadingLight.isActiveAndEnabled) {
					cleanFadingLight.enabled = !cleanFadingLight.enabled;
				}
				cookieFadingLight.intensity = Mathf.Lerp (cookieFadingLight.intensity, cookieFadingLight.intensity - 0.1f, fadeRate);

				if (cookieFadingLight.isActiveAndEnabled && Time.timeSinceLevelLoad > 60f * 60f) {
					cookieFadingLight.enabled = !cookieFadingLight.enabled;
				}
			}

			RenderSettings.ambientIntensity = Mathf.Lerp (RenderSettings.ambientIntensity, RenderSettings.ambientIntensity - 0.1f, fadeRate);

			print ("Fade Tick @ " + Time.timeSinceLevelLoad);

			yield return new WaitForSeconds (fadeDelay);
		}
	}
}