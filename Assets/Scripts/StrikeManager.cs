using UnityEngine;
using System.Collections;

public class StrikeManager : MonoBehaviour 
{
	public class strikeType
	{
		public int[] allStrikes; //pode não ser necessária
		public int[] easyStrikes;
		public int[] mediumStrikes;
		public int[] hardStrikes;
	
		public strikeType()
		{
			int i = 0;


			int[] easyStrikes = new int[4];
			int[] mediumStrikes = new int[2];
			int[] hardStrikes = new int[2];
            int[] allStrikes = new int[10];

			for (i = 0; i < easyStrikes.Length; i++)
			{
				easyStrikes[i] = i;
			}

			for (i = 6; i < mediumStrikes.Length; i++)
			{
				mediumStrikes[i] = i;
			}

			for(i = 8; i < hardStrikes.Length; i++)
			{
				hardStrikes[i] = i;
			}

			for(i=0; i < (easyStrikes.Length+mediumStrikes.Length+hardStrikes.Length); i++)
            {
                allStrikes[i] = i;
            }
		}

		public void randomEasyStrikes(int[] easyStrikes)
		{
			int[] newStrikes;

			for (int i = 0; i < easyStrikes.Length; i++) 
			{
				newStrikes = new int[3];
				int tmp = easyStrikes[i];
				int r = Random.Range(i, easyStrikes.Length);
				easyStrikes[i] = easyStrikes[r];
				newStrikes[i] = easyStrikes[r];
				easyStrikes[r] = tmp;
			}

		}
		public void randomMediumStrikes(int[] mediumStrikes)
		{
			int[] newStrikes;

			for (int i = 0; i < mediumStrikes.Length; i++) 
			{
				newStrikes = new int[2];
				int tmp = mediumStrikes[i];
				int r = Random.Range(i, mediumStrikes.Length);
				mediumStrikes[i] = mediumStrikes[r];
				newStrikes[i] = mediumStrikes[r];
				mediumStrikes[r]=tmp;
			}
		}
		public void randomHardStrikes(int[] hardStrikes)
		{
			int[] newStrikes;

			for(int i = 0; i < hardStrikes.Length; i++)
			{
				newStrikes = new int[2];
				int tmp = hardStrikes[i];
				int r = Random.Range(i, hardStrikes.Length);
				hardStrikes[i] = hardStrikes[r];
				newStrikes[i] = hardStrikes[r];
				mediumStrikes[r] = tmp;
			}
		}
	}



}
