﻿using DG.Tweening;
using System.Collections;
using Tools;
using UnityEngine;
using UnityEngine.UI;
using static Facade;

public class FadeScreen : MonoBehaviour
{
	[SerializeField] private Dependency<Image> _image;

	private Image image => _image.Resolve(this);

	private Color defaultFadeInColorTarget = Color.black;
	private Color defaultFadeOutColorTarget = Color.black.WithAlpha(0);

	public void FadeOut(float fadeDuration)
	{
		image.color = defaultFadeOutColorTarget;
		image.DOFade(1f, fadeDuration);
	}

	public void FadeOut()
	{
		image.color = defaultFadeOutColorTarget;
		image.DOFade(1f, Animations.sceneFadeDuration);
	}

	public IEnumerator FadeOutCore(float fadeDuration)
	{
		image.color = defaultFadeOutColorTarget;
		Tweener fade = image.DOFade(1f, fadeDuration);
		yield return fade.WaitForCompletion();
	}

	public IEnumerator FadeOutCore()
	{
		image.color = defaultFadeOutColorTarget;
		Tweener fade = image.DOFade(1f, Animations.sceneFadeDuration);
		yield return fade.WaitForCompletion();
	}

	public void FadeIn(float fadeDuration)
	{
		image.color = defaultFadeInColorTarget;
		image.DOFade(0f, fadeDuration);
	}

	public void FadeIn()
	{
		image.color = defaultFadeInColorTarget;
		image.DOFade(0f, Animations.sceneFadeDuration);
	}

	public IEnumerator FadeInCore(float fadeDuration)
	{
		image.color = defaultFadeInColorTarget;
		Tweener fade = image.DOFade(0f, fadeDuration);
		yield return fade.WaitForCompletion();
	}

	public IEnumerator FadeInCore()
	{
		image.color = defaultFadeInColorTarget;
		Tweener fade = image.DOFade(0f, Animations.sceneFadeDuration);
		yield return fade.WaitForCompletion();
	}
}