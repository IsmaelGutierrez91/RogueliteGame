using UnityEngine;

public class SkillBehaviour : MonoBehaviour
{
    private SkillData data;
    private int currentLevel;
    private float lastCastTime;

    public void Init(SkillData skillData)
    {
        data = skillData;
        currentLevel = 0;
        lastCastTime = -999f;
    }

    public void LevelUp()
    {
        currentLevel = Mathf.Min(currentLevel + 1, data.damagePerLevel.Length - 1);
    }

    private void Update()
    {
        if (Time.time >= lastCastTime + data.cooldownPerLevel[currentLevel])
        {
            Cast();
            lastCastTime = Time.time;
        }
    }

    private void Cast()
    {
        if (data.projectilePrefab == null) return;

        Vector3 dir = Vector3.right;

        GameObject proj = Instantiate(data.projectilePrefab, transform.position, Quaternion.identity);
        proj.GetComponent<Projectile>().Init(data.damagePerLevel[currentLevel], data.rangePerLevel[currentLevel], dir);
    }
}