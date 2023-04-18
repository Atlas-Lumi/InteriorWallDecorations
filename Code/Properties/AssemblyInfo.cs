using MelonLoader;
using System.Reflection;

//This is a C# comment. Comments have no impact on compilation.

//ModName, ModVersion, ModAuthor, and ModNamespace.ModClassInheritingFromMelonMod all need changed.

[assembly: AssemblyTitle("MyPicturesMod")]
[assembly: AssemblyCopyright("Created by stmSantana, Atlas Lumi, Thekillergreece")]

//Version numbers in C# are a set of 1 to 4 positive integers separated by periods.
//Mods typically use 3 numbers. For example: 1.2.1
//The mod version need specified in three places.
[assembly: AssemblyVersion("2.0.0")]
[assembly: AssemblyFileVersion("2.0.0")]
[assembly: MelonInfo(typeof(MyPicturesMod.Implementation), "MyPicturesMod", "2.0", "stmSantana, Atlas Lumi, Thekillergreece")]

//This tells MelonLoader that the mod is only for The Long Dark.
[assembly: MelonGame("Hinterland", "TheLongDark")]