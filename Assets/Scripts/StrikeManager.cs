using UnityEngine;
using System.Collections;

public class StrikeManager : MonoBehaviour 
{
	public class strikeType
	{
		public int[] allStrikes;
		public int[] easyStrikes;
		public int[] mediumStrikes;
		public int[] hardStrikes;
	
		public strikeType()
		{
			int i = 0;

			int[] easyStrikes = new int[8];
			int[] mediumStrikes = new int[4];
			int[] hardStrikes = new int[4];

			for (i = 0; i < easyStrikes.Length; i++)
			{
				easyStrikes[i] = i;
			}

			for (i = 10; i < mediumStrikes.Length; i++)
			{
				mediumStrikes[i] = i;
			}

			for(i = 13; i < hardStrikes.Length; i++)
			{
				hardStrikes[i] = i;
			}

			int[] allStrikes = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
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
