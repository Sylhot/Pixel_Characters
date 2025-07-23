using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum SkillType
{
    Projectile,     // Uçan mermi, ok, büyü vs.
    Melee,          // Yakın dövüş (kılıç savurma gibi)
    Area,           // AoE: Belirli bir alanda etki eden (örneğin bomba)
    Buff,           // Oyuncuyu güçlendiren (hasar artırma vs.)
    Debuff,         // Düşmanı zayıflatan (yavaşlatma vs.)
    Heal,           // Can yenileyen
    Dash,           // Hızlı bir yön hareketi
    Summon,         // Yardımcı yaratık çağırma
    Trap,           // Yerleştirilen tuzak
    Channeling,     // Beklenerek güçlenen skill (örn. Kamehameha 😄)
    Toggle,         // Aç/kapa şeklinde çalışan skill (örneğin auras)
    Passive         // Oyuncunun aktif kullanmadığı, hep açık
}
public abstract class SkillBase : ScriptableObject
{
    public string skillName;
    public GameObject skillObejct;
    public Sprite skillIcon;
    public SkillType skillType;

    [TextArea]
    public string description;

    public float speed;            // Projectile hızı
    public float cooldown;         // Bekleme süresi
    public int manaCost;           // Kullanım maliyeti
    public float range;            // Etki mesafesi
    public float castTime;         // Kullanma süresi
    public AudioClip skillSound;   // Oynatılacak ses
    public float destroyerTime;    // Yetenek yok olma süresi

    // Efekt verisi
    public int power;              // Hasar / iyileştirme gücü
    public float duration;         // Buff veya debuff süresi

    public abstract void SpawnSkill(Vector3 mousePosition, Quaternion skillRotation,Vector3 characterPosition);
}
