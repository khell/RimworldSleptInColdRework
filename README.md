# About
When colonists sleep, they receive the "Slept in the cold" debuff based on if they weren't wearing all of their clothing. The room can be 10C and you can be insulated up to -127C and still receive "Slept in the cold" as apparently colonists would prefer to be cold even when it is within their means to sleep comfortably.

This mod changes this behaviour so that they do in fact wear their clothes to sleep. Instead of slept in the cold, there are now three stages of increasingly worsening debuffs:
* Slept in clothes (-2), when the room is below the original threshold.
* Slept in clothes uncomfortably (-5), when the room is 70% below their Gear's minimum comfortable temperature.
* Slept in near death conditions (-8). when the room is 100% below their Gear's minimum comfortable temperature.

In some cases this reduces the difficulty whilst increasing it in other cases. You can also adjust the mood effect modifiers via the Mod Settings menu provided by HugsLib.

# Dependencies
Requires HugsLib.

# Compatibility
Please note this mod uses the detour technique to redirect flow when the following methods are invoked:
* RimWorld.Toils_LayDown.LayDown

# License
Please feel free to use and modify, but provide attribution. If you want to create a translation, please submit a pull request and do not republish the mod separately.