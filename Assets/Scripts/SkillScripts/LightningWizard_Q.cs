using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[CreateAssetMenu(fileName = "LightningWizard_Q", menuName = "Skill/LightningWizard_Q")]
public class LightningWizard_Q : SkillBase
{
    GameObject skillInstance;
    Vector2 direction;
    public override void SpawnSkill(Vector3 mousePosition, Quaternion skillRotation, Vector3 characterPosition)
    {
        direction = mousePosition - characterPosition;
        skillInstance = Instantiate(skillObejct, characterPosition, skillRotation);
        skillInstance.GetComponent<ProjectileMovement>()?.Initialize(direction, speed);
        skillInstance.GetComponent<SkillSoundPlayer>()?.PlaySound(skillSound);
        Destroy(skillInstance, destroyerTime);
        Debug.Log("LightningWizard_Q scripti calisti");
    }
}
