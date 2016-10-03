using System.Collections.Generic;
using FictionBox.Core.ViewModels;
using FictionBox.UI.iOS.Views;

namespace FictionBox.UI.iOS.Views
{
	public class DeckView : BaseDeckTableView
	{
		public DeckView()
		{
			Title = "Deck View";
		}

		public DeckViewModel DynamicViewModel
		{
			get
			{
				return base.ViewModel as DeckViewModel;
			}
		}

		/*protected override void AddKittensPressed()
		{
			DynamicViewModel.AddKittenCommand.Execute(null);
		}

		protected override void KillKittensPressed()
		{
			DynamicViewModel.KillKittensCommand.Execute(null);
		}*/
	}
}