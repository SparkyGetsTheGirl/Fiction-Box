using MvvmCross.Core.ViewModels;
using FictionBox.Core.Services;

namespace FictionBox.Core.ViewModels
{
	public class DeckViewModel : MvxViewModel
	{
		readonly ICreateDecks _createDecks;

		public List<DeckModel> FictionBoxDecks { get; set; }

		public DeckViewModel(ICreateDecks createDecks)
		{
			_createDecks = createDecks;
			FictionBoxDecks = null;
		}

		public override void Start()
		{
			FictionBoxDecks = _createDecks.loadDecksFromResources();
			base.Start();
		}
	}
}
