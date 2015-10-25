using System;
using System.Windows.Controls;

using Hearthstone_Deck_Tracker.Plugins;

namespace CardPerformance
{
    public class MyPlugin : IPlugin
    {
		public string Author
		{
			get { return "therationalpi"; }
		}

		public string ButtonText
		{
			get { return "Setttings"; }
		}

		public string Description
		{
			get { return "Gives the card performance as measured by the win rate in games where the given card is drawn. Can be used to evaluate card choices in deck building."; }
		}

		public MenuItem MenuItem
		{
			get { return null; }
		}

		public string Name
		{
			get { return "Card Performance"; }
		}

		public void OnButtonPress()
		{
		}

		public void OnLoad()
		{
			MyCode.Load();
		}

		public void OnUnload()
		{
		}

		public void OnUpdate()
		{
		}

		public Version Version
		{
			get { return new Version(0, 0, 1); }
		}
    }
}
