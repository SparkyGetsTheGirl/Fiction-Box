<<<<<<< HEAD
﻿using System.Collections.Generic;
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
=======
﻿using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using FictionBox.Core.ViewModels;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace FictionBox.UI.iOS.Views
{
	public sealed class DeckView : MvxView
	{
		public DeckView()
		{
		}
	}

	[Register("DeckView")]
	public class DeckViewController : MvxViewController
	{

		public override void ViewDidLoad()
		{
			View = new UIView() { BackgroundColor = UIColor.White };
			base.ViewDidLoad();

			// ios7 layout
			/*if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
				EdgesForExtendedLayout = UIRectEdge.None;

			var table = new UITableView(new RectangleF(0, 0, 320, 720));
			Add(table);

			var source = new MvxStandardTableViewSource(table, "TitleText FirstName");
			table.Source = source;

			var currentPersonView = new PersonView();
			currentPersonView.Frame = new RectangleF(320, 10, 320, 900);
			Add(currentPersonView);

			var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
			set.Bind(source).To(vm => vm.People);
			set.Bind(source).For(s => s.SelectedItem).To(vm => vm.Current);
			set.Bind(currentPersonView).For(s => s.DataContext).To(vm => vm.Current);
			set.Apply();

			FirstViewModel.WeakSubscribe(ViewModelPropertyChanged);*/
		}

		/*private void ViewModelPropertyChanged(object sender, PropertyChangedEventArgs args)
		{
			if (args.PropertyName == "Current")
			{
				if (FirstViewModel.Current != null)
				{
					OpenNewDisplay(FirstViewModel.Current);
				}
			}
		}

		private int _offsetX = 600;
		private int _offsetY = 10;
		private void OpenNewDisplay(PersonViewModel current)
		{
			var personView = new PersonView();
			personView.Frame = new RectangleF(_offsetX, _offsetY, 320, 900);
			personView.DataContext = current;
			Add(personView);

			_offsetX += 40;
			_offsetY += 40;
		}*/
	}
}
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
