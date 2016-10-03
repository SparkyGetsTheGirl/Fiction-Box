<<<<<<< HEAD
﻿using System.Collections.Generic;

using MvvmCross.Core.ViewModels;
using FictionBox.Core.Services;
using FictionBox.Core.Models;
=======
﻿using MvvmCross.Core.ViewModels;
using FictionBox.Core.Services;
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833

namespace FictionBox.Core.ViewModels
{
	public class DeckViewModel : MvxViewModel
	{
<<<<<<< HEAD
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
=======
		readonly ICreateDecks _createDecks;

		public List<DeckModel> FictionBoxDecks { get; set; }
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833

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
