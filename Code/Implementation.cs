using MelonLoader;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace MyPicturesMod
{
    internal class Implementation : MelonMod
    {
        public override void OnSceneWasInitialized(int level, string name)
        {
            Implementation.UpdatePicsTexture();
        }

        public static void UpdatePicsTexture()
        {
            string[] array = new string[]
            {
                "GEAR_WallMyPicCalA",
                "GEAR_WallMyPicCalB",
                "GEAR_WallMyPicCalC",
                "GEAR_WallMyPicFrameB",
                "GEAR_WallMyPicFrameG",
                "GEAR_WallMyPicFrameR",
                "GEAR_WallMyPicPosterA",
                "GEAR_WallMyPicPosterB",
                "GEAR_WallMyPicPosterC",
                "GEAR_WallMyPicSqr01",
                "GEAR_WallMyPicSqr02",
                "GEAR_WallMyPicSqr03",
                "GEAR_WallMyPicSqr04",
                "GEAR_WallMyPicSqr05",
                "GEAR_WallMyPicSqr06",
                "GEAR_WallMyPicSqr07",
                "GEAR_WallMyPicSqr08",
                "GEAR_WallMyPicSqr09",
                "GEAR_WallMyPicSqr10",
                "GEAR_WallMyPicSqr11",
                "GEAR_WallMyPicSqr12",
                "GEAR_WallMyPicSqr13",
                "GEAR_WallMyPicSqr14",
                "GEAR_WallMyPicSqr15",
                "GEAR_WallMyPicSqr16",
                "GEAR_WallMyPicSqr17",
                "GEAR_WallMyPicSqr18",
                "GEAR_WallMyPicSqr19",
                "GEAR_WallMyPicSqr20"
            };
            string[] array2 = new string[]
            {
                "Mods/WallMyPictures/c00a.png",
                "Mods/WallMyPictures/c00b.png",
                "Mods/WallMyPictures/c00c.png",
                "Mods/WallMyPictures/f00b.png",
                "Mods/WallMyPictures/f00g.png",
                "Mods/WallMyPictures/f00r.png",
                "Mods/WallMyPictures/p00a.png",
                "Mods/WallMyPictures/p00b.png",
                "Mods/WallMyPictures/p00c.png",
                "Mods/WallMyPicturesSqr/MPSqr01.png",
                "Mods/WallMyPicturesSqr/MPSqr02.png",
                "Mods/WallMyPicturesSqr/MPSqr03.png",
                "Mods/WallMyPicturesSqr/MPSqr04.png",
                "Mods/WallMyPicturesSqr/MPSqr05.png",
                "Mods/WallMyPicturesSqr/MPSqr06.png",
                "Mods/WallMyPicturesSqr/MPSqr07.png",
                "Mods/WallMyPicturesSqr/MPSqr08.png",
                "Mods/WallMyPicturesSqr/MPSqr09.png",
                "Mods/WallMyPicturesSqr/MPSqr10.png",
                "Mods/WallMyPicturesSqr/MPSqr11.png",
                "Mods/WallMyPicturesSqr/MPSqr12.png",
                "Mods/WallMyPicturesSqr/MPSqr13.png",
                "Mods/WallMyPicturesSqr/MPSqr14.png",
                "Mods/WallMyPicturesSqr/MPSqr15.png",
                "Mods/WallMyPicturesSqr/MPSqr16.png",
                "Mods/WallMyPicturesSqr/MPSqr17.png",
                "Mods/WallMyPicturesSqr/MPSqr18.png",
                "Mods/WallMyPicturesSqr/MPSqr19.png",
                "Mods/WallMyPicturesSqr/MPSqr20.png"
            };
            for (int i = 0; i < array2.Length; i++)
            {
                if (File.Exists(array2[i]))
                {
                    Texture2D texture2D = new Texture2D(2, 2);
                    ImageConversion.LoadImage(texture2D, File.ReadAllBytes(array2[i]));
                    if (!(Addressables.LoadAssetAsync<GameObject>(array[i]) == null))
                    {
                        Addressables.LoadAssetAsync<GameObject>(array[i]).WaitForCompletion().GetComponent<MeshRenderer>().materials[1].mainTexture = texture2D;
                    }
                }
            }
        }
    }
}