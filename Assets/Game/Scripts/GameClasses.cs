using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BaseCharacterClass;

public class GameClasses : BaseCharacterClass
{
    public void BarbarianClass(){
        CharacterClassName = "Barbarian";
        CharacterClassDescription = "Barbarians are all about getting angry and dealing damage. They have a ton of hit points, resistance to damage, and Rage gives a wonderful bonus to damage. Barbarians don’t get much in the way of skills, so generally they’re stuck as combat monsters, but they function equally well as a Defender and a Striker, and certain character options can even expand them into a limited Support role.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void BardClass(){
        CharacterClassName = "Bard";
        CharacterClassDescription = "The Bard is fantastically versatile. With access to every skill, expertise, full casting, and a decent set of proficiencies, the Bard can fill essentially every role in the party. Subclasses like College of Lore are more of the classic supportive Bard, with improved magical options and support abilities, while College of Swords and College of Valor can serve as front-line melee characters who can bring their spellcasting and support capabilities into the heat of battle.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void ClericClass(){
        CharacterClassName = "Cleric";
        CharacterClassDescription = "Clerics are among the most diverse and interesting classes in 5e DnD. Because your choice of Divine Domain so greatly affects your capabilities, Clerics can fit a variety of roles and play styles. More generally, Clerics are the best healers in the game, and have among the best support, utility, and divination options in the game. However, they are by no means limited to healing and support roles. Clerics have abundant offensive options, and can even be effective with weapons.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void DruidClass(){
        CharacterClassName = "Druid";
        CharacterClassDescription = "Druids are a very versatile class. Between their available archetypes, they’re able to serve mixes roles as scouts, strikers, blaster, support casters, and controllers. Their spell list has a lot of unique options. There is a strong emphasis on area control spells, and most of the Druid’s best spells require Concentration. By spellcaster standards, the Druid is relatively simple to play because you so rarely need to track more than one ongoing spell effect, but it certainly doesn’t make them less fun or less powerful.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void FighterClass(){
        CharacterClassName = "Fighter";
        CharacterClassDescription = "The Fighter is a fantastic addition to any party. While their skill and tool proficiencies are extremely limited, Fighters excel in combat. They are durable, have great armor, and provide plenty of damage output. Fighters get more Ability Score Increases than any other class, allowing them to easily explore feats without sacrificing crucial ability scores. They also notably get more attacks than any other class, which can be a lot of fun.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void MonkClass(){
        CharacterClassName = "Monk";
        CharacterClassDescription = "The Monk is the iconic martial-artist, popular among those who prefer to punch things rather than stabbing them or setting them on fire (though stabbing things and setting them on fire is still a possibility for the Monk). Monks are excellent Defenders and Strikers, and typically fill a role in party as a Fighter-equivalent or Rogue-equivalent depending on your subclass and proficiencies. Certain subclasses also introduce healing and Support capabilities, allowing monks to thrive in new roles depending on your build.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void PaladinClass(){
        CharacterClassName = "Paladin";
        CharacterClassDescription = "Paladins are the most durable, survivable, and self-sufficient class in the game. As such, they both make excellent solo characters and are excellent additions to nearly any party regardless of existing capabilities. In a party, they serve as a Defender, Face, and Striker. They do have some healing and utility options, but not enough to replace a full spellcaster in most parties. Your choice of subclass will influence which of those roles your character emphasizes, though typically it’s just a sliding scale between Defender and Striker.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void RangerClass(){
        CharacterClassName = "Ranger";
        CharacterClassDescription = "The Ranger is an interesting mix of Druid-style spellcasting, Fighter-style combat capabilities, and Rogue-style skills. Themed around nature and exploration, the Ranger is a welcome asset in parties exploring untamed lands above or below ground.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void RogueClass(){
        CharacterClassName = "Rogue";
        CharacterClassDescription = "Rogues are the quintessential Face, Scout and Striker. Sneak Attack allows them to do a huge pile of damage in a single attack, and their pile of skills allows them to easily handle locks, traps, guards, and many other challenges. While a party can function just fine without a Rogue, it’s hard to compete with the sheer number of important skill and tool proficiencies offered by the Rogue.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void SorcererClass(){
        CharacterClassName = "Sorcerer";
        CharacterClassDescription = "Sorcerers are a challenge, but at the same time they can be less complex than most spellcasting classes. The Sorcerer’s spell list allows them to serve as a Blaster, Controller, Striker, and Utility Caster, and sorcerers make one of the easiest Faces in the game due to their skill list and their dependence on Charisma";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void WarlockClass(){
        CharacterClassName = "Warlock";
        CharacterClassDescription = "The Warlock is likely the easiest of any spellcaster to play. You get only a handful of spell slots at a time, and never have to juggle multiple spell slot levels. Warlocks have a liGst of spells known, so you don’t need to worry about changing your spells on a daily basis. Warlocks also get the most powerful damage cantrip in the game, giving them a solid, reliable option for damage output in between your big spells.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
    public void WizardClass(){
        CharacterClassName = "Wizard";
        CharacterClassDescription = "The Wizard is the iconic arcane spellcaster, capable of doing all manner of fantastic tricks, and generally limited only by their spellbook and their spell slots. A Wizard with a comprehensive spellbook can do essentially anything in the game, often as well as or better than a non-magical character who is built to do that thing. A Wizard with Invisibility is as stealthy as a Rogue. A Wizard with a summoned pet can replace a fighter (at least temporarily). A clever Wizard could even find a way to heal their allies and replace a Cleric.";
        str = 1;
        dex = 1;
        con = 1;
        wis = 1;
        inte = 1;
        chari = 1;
    }
}
