class Program
{
	static void Main()
	{
		Test fr = new Test();
		fr.Execute();
	}
}


class White
{
	/*
	 * States: 
	 * 0 - Idle
	 * 1 - On
	 * 2 - Off 
	 * */
	private sbyte state = 0;
	public White()
	{
		
	}

	public void Execute()
	{
		if ( this.state == 0 )
		{
			// Idle state - do nothing
			
		}else if (this.state == 1)
		{
			// On state - Light is on
			this.On();

		}else if (this.state == 2)
		{
			// Off state - Light is off
			this.Off();
		}

	}

	public void ChangeState(sbyte state)
	{
		this.state = state;
	}
	
	private void On()
	{	
		Console.WriteLine("The standard bulb is on");
	}

	private void Off()
	{
		Console.WriteLine("The standard bulb is off");
	}
	
	public sbyte CurrentState()
	{
		return this.state;
	}

	public byte GetStates()
	{
		return 3;
	}

}

class Color
{
	/*
	 * States: 
	 * 0 - idle
	 * 1 - on
	 * 2 - off
	 * 3 - red
	 * 4 - green
	 * 5 - blue
	 * */
	private sbyte state = 0;
	private sbyte active = 0;


	public Color()
	{
				
	}

	public sbyte CurrentState()
	{
		return this.active;
	}

	public byte GetStates()
	{
		return 6;
	}

	public void Execute()
	{
		if (this.state == 0)
		{
		}else if (this.state == 1)
		{
			this.On();
		}else if (this.state == 2)
		{
			this.Off();
		}else if (this.state == 3)
		{
			this.Red();
		}else if (this.state == 4)
		{
			this.Green();
		}else if (this.state == 5)
		{
			this.Blue();
		}
	}

	public void ChangeState(sbyte state)
	{
		this.state = state;
	}

	private void On()
	{
		this.active = 1;
		Console.WriteLine("Color bulb is on");
	}
	private void Off()
	{
		this.active = 2;
		Console.WriteLine("Color bulb is off");
	}
	private void Red()
	{
		this.active = 3;
		Console.WriteLine("Color bulb is Red");
	}
	private void Green()
	{
		this.active = 4;
		Console.WriteLine("Color bulb is Green");
	}
	private void Blue()
	{
		this.active = 5;
		Console.WriteLine("Color bulb is Blue");
	}
}

