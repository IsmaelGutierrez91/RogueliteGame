using UnityEngine;

[CreateAssetMenu(fileName = "NewSkill", menuName = "ScriptableObject/Skill")]
public class SkillData : ScriptableObject
{
    public string skillName;
    public Sprite icon;
    public string description;

    public GameObject projectilePrefab;

    public float[] damagePerLevel;
    public float[] cooldownPerLevel;
    public float[] rangePerLevel;
}
