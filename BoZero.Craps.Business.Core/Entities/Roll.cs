namespace BoZero.Craps.Business.Core.Entities
{
	public class Roll
	{
		public int Die1 { get; }

		public int Die2 { get; }

		public Roll(int die1, int die2)
		{
			Die1 = die1;
			Die2 = die2;
		}
	}
}
