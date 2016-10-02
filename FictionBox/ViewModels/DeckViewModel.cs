using MvvmCross.Core.ViewModels;
using FictionBox.Core.Services;

namespace FictionBox.Core.ViewModels
{
	public class DeckViewModel : MvxViewModel
	{
		readonly ICreateDecks _createDecks;

		public DeckViewModel(ICreateDecks createDecks)
		{
			_createDecks = createDecks;
		}

		public override void Start()
		{
			_createDecks.loadDecksFromResources();
			base.Start();
		}
	}
}
