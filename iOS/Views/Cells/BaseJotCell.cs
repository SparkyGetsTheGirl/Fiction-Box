using System;
using UIKit;
using Foundation;
using Cirrious.FluentLayouts.Touch;
using Cirrious.FluentLayouts.Touch.RowSet;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.Views;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;

using FictionBox.Core.Models;

namespace FictionBox.UI.iOS.Cells
{
	[Register("BaseJotCell")]
	public class BaseJotCell : MvxTableViewCell
	{
		//private const string BindingText = "Title Title;Subtitle Subtitle; Property Property; OptionList OptionList";

		public BaseJotCell() : base()
		{
			CreateLayout();
			InitializeBindings();
		}

		public BaseJotCell(IntPtr handle) : base(handle)
		{
			CreateLayout();
			InitializeBindings();
		}

		public string Title
		{
			get { return title.Text; }
			set { title.Text = value; }
		}

		public string Subtitle
		{
			get { return subtitle.Text; }
			set { subtitle.Text = value; }
		}

		public string Property
		{
			get { return property.Text; }
			set { property.Text = value; }
		}

		/*public string OptionList
		{
			get { return optionList.Text; }
			set { optionList.Text = value; }
		}*/

		private UILabel title;
		private UILabel subtitle;
		private UILabel property;
		//private UILabel optionList;

		private void CreateLayout()
		{
			//Accessory = UITableViewCellAccessory.DisclosureIndicator;
			title = new UILabel()
			{
				TranslatesAutoresizingMaskIntoConstraints = false,
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap
			};
			subtitle = new UILabel()
			{
				TranslatesAutoresizingMaskIntoConstraints = false,
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap
			};
			property = new UILabel()
			{
				TranslatesAutoresizingMaskIntoConstraints = false,
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap
			};
			//optionList = new UILabel();

			ContentView.AddSubviews(title, subtitle, property/*, optionList*/);
			AddConstraints();
		}

		private void AddConstraints()
		{
			ContentView.AddConstraints(
				
				title.AtTopOf(ContentView, 10.0f),
				title.AtRightOf(ContentView, 10.0f),
				title.AtLeftOf(ContentView, 10.0f),

				subtitle.Below(title, 10.0f),
				subtitle.AtRightOf(ContentView, 10.0f),
				subtitle.AtLeftOf(ContentView, 10.0f),

				property.Below(subtitle, 10.0f),
				property.AtRightOf(ContentView, 10.0f),
				property.AtLeftOf(ContentView, 10.0f),
				property.AtBottomOf(ContentView, 10.0f)
			);
		}

		private void InitializeBindings()
		{
			this.DelayBind(() =>
			{
				var set = this.CreateBindingSet<BaseJotCell, BaseCardModel>();
				set.Bind(title).For(v => v.Text).To(vm => vm.Title).TwoWay();
				set.Bind(subtitle).For(v => v.Text).To(vm => vm.Subtitle).TwoWay();
				set.Bind(property).For(v => v.Text).To(vm => vm.Property).TwoWay();
				//set.Bind(optionList).For(v => v.Text).To(vm => vm.OptionList).TwoWay();
				set.Apply();
			});
		}
	}
}
