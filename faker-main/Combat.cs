using DouElfaqarBenazzouz_225040009_GameProgramming;
using System;

public class Combat
{
	private Game _theGame;

	public Player Player { get; private set; }

    public Combat(Game game)
	{
		_theGame = game;
		Player = game.Player;
	}
}
