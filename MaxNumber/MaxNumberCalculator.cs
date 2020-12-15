namespace MaxNumber
{
    public class MaxNumberCalculator
	{
		public int? GetMaxNumber(int[] values)
		{
			int? currentMax = null;

			foreach (int element in values)
            {
				if(currentMax == null)
                {
					currentMax = element;
                }
				else if (element > currentMax)
                {
					currentMax = element;
                }
            }

			return currentMax;
		}
	}
}
