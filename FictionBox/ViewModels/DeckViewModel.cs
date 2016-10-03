using System.Collections.Generic;

using MvvmCross.Core.ViewModels;
using FictionBox.Core.Services;
using FictionBox.Core.Models;

namespace FictionBox.Core.ViewModels
{
	public class DeckViewModel : MvxViewModel
	{
		private readonly ICreateDecks _createDecks;
		private List<DeckModel> _fictionBoxDecks;

		public List<DeckModel> FictionBoxDecks { 
			get
			{
				return _fictionBoxDecks; 
			}
			set
			{
				_fictionBoxDecks = value;
				RaisePropertyChanged(() => FictionBoxDecks);
			}
		}

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
