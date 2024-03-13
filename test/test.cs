class Test()
{
	static Test()
	{
		
	}

	public void Execute()
	{
		// Test white bulb
		this.White();

		// Test Color bulb
		this.Color();	
	}

	private void Color()
	{
		Color bulb = new Color();
		
		byte istates = bulb.GetStates();
		sbyte icurrentstate = bulb.CurrentState();
		sbyte istate = 0;

		while (istates > icurrentstate)
		{
			bulb.ChangeState(istate);
			icurrentstate = bulb.CurrentState();
			bulb.Execute();

			if (istate == icurrentstate)
			{
				Console.WriteLine("PASSED");
			}else
			{
				Console.WriteLine("FAILED state should be " + icurrentstate.ToString() + " but is: " + istate.ToString());
			}
			istate += 1;
		}	
	}

	private void White()
	{
		White bulb = new White();

		byte istates = bulb.GetStates();
		sbyte icurrentstate = bulb.CurrentState();
		sbyte istate = 0;

		while (istates > icurrentstate)
		{
			bulb.ChangeState(istate);
			icurrentstate = bulb.CurrentState();
			bulb.Execute();

			if (istate == icurrentstate)
			{
				Console.WriteLine("PASSED");
			}else
			{
				Console.WriteLine("FAILED state should be " + icurrentstate.ToString() + " but is: " + istate.ToString());
			}
			istate += 1;
		}

			
	}
}
