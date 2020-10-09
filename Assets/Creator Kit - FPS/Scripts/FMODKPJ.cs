using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODKPJ
{
    public static void PlayPositive()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Positive");
    }

    public static void PlayNegative()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Negative");
    }

    public static void PlayLevelComplete()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/Complete");
    }

    public static void PlayFoot(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Foot", pos);
    }

    public static void PlayJump(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Jump", pos);
    }

    public static void PlayLand(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Land", pos);
    }

    public static void PlayHit(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/NPC/Hit", pos);
    }

    public static void PlayDestroyed(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Grenade/Explode", pos);
    }

    public static void PlayImpact(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Bullet/Impact", pos);
    }

    public static void PlayDead(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/NPC/Dead", pos);
    }

    // add support for specific weapons
    public static void Fire(Weapon.SoundType soundType, Vector3 pos)
    {
        switch (soundType)
        {
            case Weapon.SoundType.Pistol:
                FMODUnity.RuntimeManager.PlayOneShot("event:/Pistol/Shoot", pos);
                break;
            case Weapon.SoundType.Automatic:
                FMODUnity.RuntimeManager.PlayOneShot("event:/Automatic/Shoot", pos);
                break;
            default:
                FMODUnity.RuntimeManager.PlayOneShot("event:/Grenade/Throw", pos);
                break;
        }
    }

    public static void Reload(Weapon.SoundType soundType, Vector3 pos)
    {
        switch (soundType)
        {
            case Weapon.SoundType.Pistol:
                FMODUnity.RuntimeManager.PlayOneShot("event:/Pistol/Reload", pos);
                break;
            case Weapon.SoundType.Automatic:
                FMODUnity.RuntimeManager.PlayOneShot("event:/Automatic/Reload", pos);
                break;
            default:
                break;
        }
    }
}
